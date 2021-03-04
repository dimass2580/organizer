using NUnit.Framework;
using orgainizer.Data.Update;
using orgainizer.Data.Add;
using orgainizer.Data.Get;
using orgainizer.DataModels;
using System;
using System.Data.OleDb;

namespace OrganizerTestProject
{
    class UpdateEventDateTest
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
        public void UpdateEventDateTest1()
        {
            UpdateEventDate update = new UpdateEventDate();
            GetAllEvents allEvents = new GetAllEvents();
            DateTime date = DateTime.Today;

            var events = allEvents.Get(connection);
            int ID = 0;

            foreach (EventModel @event in events)
                if (@event.DateOfEvent.Equals(date)) ID = @event.ID;

            date = DateTime.Parse("16.02.1999");
            EventModel model = new EventModel(ID, date, $"TestEvent № 155");
            update.Update(model, connection);

            allEvents = new GetAllEvents();
            events = allEvents.Get(connection);
            bool passFlag = false;
            foreach (EventModel @event in events)
                if (@event.DateOfEvent.Equals(date)) passFlag = true;

            if (passFlag)
                Assert.Pass("Элемент изменен");
            else
                Assert.Fail("Ошибка изменения");
        }
    }
}
