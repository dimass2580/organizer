using NUnit.Framework;
using orgainizer.Data.Deleate;
using orgainizer.Data.Add;
using orgainizer.Data.Get;
using orgainizer.DataModels;
using System;
using System.Data.OleDb;

namespace OrganizerTestProject
{
    class DeleateEventTest
    {
        [SetUp]
        public void Setup()
        {
            connection.Open();
            OleDbCommand TruncateCommand = new OleDbCommand("DELETE FROM Events", connection);
            TruncateCommand.ExecuteNonQuery();
            connection.Close();
            AddEvent @event = new AddEvent();
            EventModel model;
            DateTime date = DateTime.Today;
            for (int Item = 0; Item < 100; Item++)
            {
                model = new EventModel(date, $"TestEvent № {Item}");
                @event.Add(model, connection);
            }
        }

        public OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                       "Data Source=calls.mdb;");

        [Test]
        public void DeleateEventTest1()
        {
            DeleateEvent deleateEvent = new DeleateEvent();
            GetAllEvents allEvents = new GetAllEvents();
            DateTime date = DateTime.Today;

            var events = allEvents.Get(connection);
            int ID = 0;

            foreach (EventModel @event in events)
                if (@event.Event.Equals("TestEvent № 55")) ID = @event.ID;

            EventModel model = new EventModel(ID, date, $"TestEvent № {55}");
            deleateEvent.Deleate(model, connection);

            allEvents = new GetAllEvents();
            events = allEvents.Get(connection);
            bool passFlag = true;
            foreach (EventModel @event in events)
                if (@event.Event.Equals("TestEvent № 55")) passFlag = false;

            if (passFlag)
                Assert.Pass("Элемент отсутсвует в БД");
            else
                Assert.Fail("Ошибка удаления");
        }
    }
}
