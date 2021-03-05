using NUnit.Framework;
using orgainizer.Data.Deleate;
using orgainizer.Data.Add;
using orgainizer.Data.Get;
using orgainizer.DataModels;
using System;
using System.Data.OleDb;

namespace OrganizerTestProject
{
    class DelIntercityCallTests
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
                model = new IntercityCallModel($"TestSur{Item}",$"{Item}",date,60,0.4);
                call.Add(model, connection);
            }
        }

        public OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                       "Data Source=calls.mdb;");

        [Test]
        public void DeleateInterCityTest1()
        {
            DeleateIntercityCall deleateEvent = new DeleateIntercityCall();
            GetIntercityCalls allCalls = new GetIntercityCalls();
            DateTime date = DateTime.Today;

            var calls = allCalls.Get(connection);
            int ID = 0;
            bool passFlag = false;

            foreach (IntercityCallModel call in calls)
            {
                if (call.Surname.Equals("TestSur99")&&calls.Count==100)
                {
                    ID = call.ID;
                    passFlag = true;
                }
            }
                

            IntercityCallModel model = new IntercityCallModel(ID);
            deleateEvent.Deleate(model, connection);

            allCalls = new GetIntercityCalls();
            calls = allCalls.Get(connection);
            
            foreach (IntercityCallModel call in calls)
            {
                if (call.Surname.Equals("TestSur99")&&calls.Count!=99)
                {
                    passFlag = false;
                }
            }

            if (passFlag)
            {
                Assert.Pass("Элемент отсутсвует в БД");
            }

            else
            {
                Assert.Fail("Ошибка удаления");
            }
                
        }
    }
}
