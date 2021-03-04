using NUnit.Framework;
using orgainizer.Data.Add;
using orgainizer.DataModels;
using System;
using System.Data.OleDb;

namespace OrganizerTestProject
{
    class AddCallTests
    {
        [SetUp]
        public void Setup()
        {
            connection.Open();
            OleDbCommand TruncateCommand = new OleDbCommand("DELETE FROM IntercityCalls", connection);
            TruncateCommand.ExecuteNonQuery();
            connection.Close();
        }

        public OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                       "Data Source=calls.mdb;");

        [Test]
        public void AddCallTest1()
        {
            DateTime date;
            date = DateTime.Today;

            IntercityCallModel model = new IntercityCallModel("Smith","(495)111221",date,60,0.40);
            AddIntercityCall call = new AddIntercityCall();
            call.Add(model, connection);

            string price = model.Price.ToString().Replace(",", ".");
                
            var cmdText = $"SELECT * FROM IntercityCalls WHERE [Phone] = '{model.Phone}' " +
                                $"AND [Surname] = '{model.Surname}' " +
                                $"AND [Duration] = {model.Duration}" +
                                $"AND [Price] = {price}";
            connection.Open();
            OleDbCommand TestCommand = new OleDbCommand(cmdText, connection);

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
