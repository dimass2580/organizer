using NUnit.Framework;
using orgainizer.Data.Get;
using orgainizer.Data.Add;
using orgainizer.DataModels;
using System;
using System.Data.OleDb;

namespace OrganizerTestProject
{
    class GetAllTasksTests
    {
        [SetUp]
        public void Setup()
        {
            connection.Open();
            OleDbCommand TruncateCommand = new OleDbCommand("DELETE FROM Tasks", connection);
            TruncateCommand.ExecuteNonQuery();
            connection.Close();
            DateTime date;
            date = DateTime.Today;
            TasksModel model;
            AddTask newTask = new AddTask();
            for (int Item = 0; Item < 100; Item++)
            {
                model = new TasksModel($"TestTask №{Item}", date, Item);
                newTask.Add(model, connection);
            }
        }

        public OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                       "Data Source=calls.mdb;");

        [Test]
        public void GetAllTasks1()
        {
            GetAllTasks allTasks = new GetAllTasks();
            var tasks = allTasks.Get(connection);

            if (tasks.Count == 100)
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
