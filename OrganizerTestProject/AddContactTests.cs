using NUnit.Framework;
using orgainizer.Data.Add;
using orgainizer.DataModels;
using System.Data.OleDb;

namespace OrganizerTestProject
{
    public class AddContactTests
    {
        [SetUp]
        public void Setup()
        {
            connection.Open();
            OleDbCommand TruncateCommand = new OleDbCommand("DELETE FROM CONTACTS", connection);
            TruncateCommand.ExecuteNonQuery();
            connection.Close();
        }

        public OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                       "Data Source=calls.mdb;");

        [Test]
        public void AddContactTest1()
        {
            ContactModel model = new orgainizer.DataModels.ContactModel("899941100022",
                                                        "TestSurname", "test", "Test@mail.com");
            AddContact contact = new AddContact();
            contact.Add(model, connection);

            var cmdText = $"SELECT * FROM CONTACTS WHERE [Phone_Num] = '{model.Phone}' " +
                                $"AND [Surname] = '{model.Surname}' " +
                                $"AND [Initials] = '{model.Initials}'" +
                                $"AND [Email] = '{model.Email}'";
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

        [Test]
        public void AddContactTest2()
        {
            ContactModel model = new ContactModel("+79994256467",
                                                        "Тестовая запись", "ТЗ", "тест@mail.com");
            AddContact contact = new AddContact();
            contact.Add(model, connection);

            var cmdText = $"SELECT * FROM CONTACTS WHERE [Phone_Num] = '{model.Phone}' " +
                                $"AND [Surname] = '{model.Surname}' " +
                                $"AND [Initials] = '{model.Initials}'" +
                                $"AND [Email] = '{model.Email}'";
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