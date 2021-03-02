using NUnit.Framework;
using orgainizer.Data.Get;
using orgainizer.Data.Add;
using orgainizer.DataModels;
using System;
using System.Data.OleDb;

namespace OrganizerTestProject
{
    class GetAllContactsTests
    {
        [SetUp]
        public void Setup()
        {
            connection.Open();
            OleDbCommand TruncateCommand = new OleDbCommand("DELETE FROM Contacts", connection);
            TruncateCommand.ExecuteNonQuery();
            connection.Close();
            AddContact contact = new AddContact();
            ContactModel model;

            for (int Item = 0; Item < 100; Item++)
            {
                 model = new ContactModel($"899941100{Item}",
                                             $"TestSurname {Item}",
                                                $"test {Item}",
                                                  $"Test{Item}@mail.com");
                contact.Add(model, connection);
            }
        }

        public OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                       "Data Source=calls.mdb;");

        [Test]
        public void GetAllEventsTest1()
        {
            GetAllContacts allContacts = new GetAllContacts();
            var contacts = allContacts.Get(connection);

            if (contacts.Count == 100)
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
