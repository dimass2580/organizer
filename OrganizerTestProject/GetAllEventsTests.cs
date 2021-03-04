using NUnit.Framework;
using orgainizer.Data.Get;
using orgainizer.Data.Add;
using orgainizer.DataModels;
using System;
using System.Data.OleDb;

namespace OrganizerTestProject
{
    class GetAllEventsTests
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
        public void GetAllEventsTest1()
        {
            GetAllEvents allEvents = new GetAllEvents();
                    var events = allEvents.Get(connection);
            
            if (events.Count == 100)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail("В таблице не все записи");
            }
        }


    }
}
