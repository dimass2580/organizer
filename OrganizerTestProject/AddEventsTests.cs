using NUnit.Framework;
using orgainizer.Data.Add;
using orgainizer.DataModels;
using System;
using System.Data.OleDb;

namespace OrganizerTestProject
{
    public class AddEventTests
    {
        [SetUp]
        public void Setup()
        {
            connection.Open();
            OleDbCommand TruncateCommand = new OleDbCommand("DELETE FROM Events", connection);
            TruncateCommand.ExecuteNonQuery();
            connection.Close();
        }

        public OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                       "Data Source=calls.mdb;");

        [Test]
        public void AddEventTest1()
        {
            DateTime Date;
            Date = DateTime.Today;
            EventModel model = new EventModel(Date, "TestEvent1");
            AddEvent newEvent = new AddEvent();
            newEvent.Add(model, connection);

            var cmdText = $"SELECT * FROM EVENTS WHERE [DateOfEvent] = @dateOfEvent " +
                                 $"AND [Event] = '{model.Event}'";
            connection.Open();
            OleDbCommand TestCommand = new OleDbCommand(cmdText, connection);
            TestCommand.Parameters.Add(new OleDbParameter("@dateOfEvent", OleDbType.Date));
            TestCommand.Parameters["@dateOfEvent"].Value = model.DateOfEvent;

            if (TestCommand.ExecuteReader().HasRows)
            {
                connection.Close();
                Assert.Pass();
            }
            else
            {
                connection.Close();
                Assert.Fail("В таблице нет записи");
            }
        }

        [Test]
        public void AddEventTest2()
        {
            DateTime Date;
            Date = DateTime.Parse("16.02.1999");
            EventModel model = new EventModel(Date, "TestEvent2");
            AddEvent newEvent = new AddEvent();
            newEvent.Add(model, connection);

            var cmdText = $"SELECT * FROM EVENTS WHERE [DateOfEvent] = @dateOfEvent " +
                                $"AND [Event] = '{model.Event}'";
            connection.Open();
            OleDbCommand TestCommand = new OleDbCommand(cmdText, connection);
            TestCommand.Parameters.Add(new OleDbParameter("@dateOfEvent", OleDbType.Date));
            TestCommand.Parameters["@dateOfEvent"].Value = model.DateOfEvent;

            if (TestCommand.ExecuteReader().HasRows)
            {
                connection.Close();
                Assert.Pass();
            }
            else
            {
                connection.Close();
                Assert.Fail("В таблице нет записи");
            }
        }

        [Test]
        public void AddEventTest3()
        {
            DateTime Date;
            Date = DateTime.Parse("16.02.1999 00:00:00");
            EventModel model = new EventModel(Date, "TestEvent3");
            AddEvent newEvent = new AddEvent();
            newEvent.Add(model, connection);

            var cmdText = $"SELECT * FROM EVENTS WHERE [DateOfEvent] = @dateOfEvent " +
                                $"AND [Event] = '{model.Event}'";
            connection.Open();
            OleDbCommand TestCommand = new OleDbCommand(cmdText, connection);
            TestCommand.Parameters.Add(new OleDbParameter("@dateOfEvent", OleDbType.Date));
            TestCommand.Parameters["@dateOfEvent"].Value = model.DateOfEvent;

            if (TestCommand.ExecuteReader().HasRows)
            {
                connection.Close();
                Assert.Pass();
            }
            else
            {
                connection.Close();
                Assert.Fail("В таблице нет записи");
            }
        }
    }
}