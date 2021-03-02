using NUnit.Framework;
using orgainizer;
using orgainizer.Data.Add;
using orgainizer.DataModels;
using System.Data.OleDb;
using System;

namespace OrganizerTestProject
{
    public class AddTaskTests
    {
        [SetUp]
        public void Setup()
        {
            connection.Open();
            OleDbCommand TruncateCommand = new OleDbCommand("DELETE FROM Tasks", connection);
            TruncateCommand.ExecuteNonQuery();
            connection.Close();
        }

        public OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                       "Data Source=calls.mdb;");

        [Test]
        public void AddTaskTest1()
        {
            DateTime date;
            date = DateTime.Today;
            TasksModel model = new TasksModel("TestTask", date, 0);
            AddTask newTask = new AddTask();
            newTask.Add(model, connection);

            var cmdText = $"SELECT * FROM Tasks WHERE [End_Date] = @EndDate " +
                                 $"AND [Task] = '{model.Task}' " +
                                 $"AND [Preority] = {model.Preority}";
            connection.Open();
            OleDbCommand TestCommand = new OleDbCommand(cmdText, connection);
            TestCommand.Parameters.Add(new OleDbParameter("@EndDate", OleDbType.Date));
            TestCommand.Parameters["@EndDate"].Value = date;

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
        public void AddTaskTest2()
        {
            DateTime date;
            date = DateTime.Parse("16.02.1999");
            TasksModel model = new TasksModel("TestTask2", date, 0);
            AddTask newTask = new AddTask();
            newTask.Add(model, connection);

            var cmdText = $"SELECT * FROM Tasks WHERE [End_Date] = @EndDate " +
                                 $"AND [Task] = '{model.Task}' " +
                                 $"AND [Preority] = {model.Preority}";
            connection.Open();
            OleDbCommand TestCommand = new OleDbCommand(cmdText, connection);
            TestCommand.Parameters.Add(new OleDbParameter("@EndDate", OleDbType.Date));
            TestCommand.Parameters["@EndDate"].Value = model.EndDate;

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
        public void AddTaskTest3()
        {
            DateTime date;
            date = DateTime.Parse("16.02.1999 00:00:00");
            TasksModel model = new TasksModel("TestTask3", date, 0);
            AddTask newTask = new AddTask();
            newTask.Add(model, connection);

            var cmdText = $"SELECT * FROM Tasks WHERE [End_Date] = @EndDate " +
                                 $"AND [Task] = '{model.Task}' " +
                                 $"AND [Preority] = {model.Preority}";
            connection.Open();
            OleDbCommand TestCommand = new OleDbCommand(cmdText, connection);
            TestCommand.Parameters.Add(new OleDbParameter("@EndDate", OleDbType.Date));
            TestCommand.Parameters["@EndDate"].Value = model.EndDate;

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
        public void AddTaskTest4()
        {
            DateTime date;
            date = DateTime.Parse("16.02.1999 00:00:00");
            TasksModel model = new TasksModel("TestTask4", date, 100);
            AddTask newTask = new AddTask();
            newTask.Add(model, connection);

            var cmdText = $"SELECT * FROM Tasks WHERE [End_Date] = @EndDate " +
                                 $"AND [Task] = '{model.Task}' " +
                                 $"AND [Preority] = {model.Preority}";
            connection.Open();
            OleDbCommand TestCommand = new OleDbCommand(cmdText, connection);
            TestCommand.Parameters.Add(new OleDbParameter("@EndDate", OleDbType.Date));
            TestCommand.Parameters["@EndDate"].Value = model.EndDate;

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
        public void AddTaskTest5()
        {
            DateTime date;
            date = DateTime.Parse("16.02.1999 00:00:00");
            TasksModel model = new TasksModel("Тестовая Задача", date, 100);
            AddTask newTask = new AddTask();
            newTask.Add(model, connection);

            var cmdText = $"SELECT * FROM Tasks WHERE [End_Date] = @EndDate " +
                                 $"AND [Task] = '{model.Task}' " +
                                 $"AND [Preority] = {model.Preority}";
            connection.Open();
            OleDbCommand TestCommand = new OleDbCommand(cmdText, connection);
            TestCommand.Parameters.Add(new OleDbParameter("@EndDate", OleDbType.Date));
            TestCommand.Parameters["@EndDate"].Value = model.EndDate;

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