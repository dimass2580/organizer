using NUnit.Framework;
using orgainizer.Data.Get;
using orgainizer.Data.Add;
using orgainizer.DataModels;
using System;
using System.Data.OleDb;
namespace OrganizerTestProject
{
    class GetIntercityCallsTest
    {
        [SetUp]
        public void Setup()
        {
            connection.Open();
            OleDbCommand TruncateCommand = new OleDbCommand("DELETE FROM IntercityCalls", connection);
            TruncateCommand.ExecuteNonQuery();
            connection.Close();
            AddIntercityCall call = new AddIntercityCall();
            IntercityCallModel model;
            DateTime date = DateTime.Today;
            for (int Item = 0; Item < 100; Item++)
            {
                model = new IntercityCallModel($"TestSur{Item}", $"{Item}", date, 60, 0.4);
                call.Add(model, connection);
            }
        }

        public OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                       "Data Source=calls.mdb;");

        [Test]
        public void GetInterCityCallsTest1()
        {
            GetIntercityCalls intercityCalls = new GetIntercityCalls();
            var calls = intercityCalls.Get(connection);

            if (calls.Count == 100)
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
