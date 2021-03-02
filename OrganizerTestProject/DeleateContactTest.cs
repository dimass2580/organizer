using NUnit.Framework;
using orgainizer.Data.Deleate;
using orgainizer.Data.Add;
using orgainizer.Data.Get;
using orgainizer.DataModels;
using System;
using System.Data.OleDb;

namespace OrganizerTestProject
{
    class DeleateContactTest
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
        public void DeleateContactTest1()
        {
            DeleateContact deleateContact = new DeleateContact();
            GetAllContacts allContacts = new GetAllContacts();

            var contacts = allContacts.Get(connection);
            int ID = 0;

            foreach (ContactModel contact in contacts)
                if (contact.Surname.Equals("TestSurname 66")) ID = contact.ID;

            ContactModel model = new ContactModel(ID, "89994110066",
                                                        "TestSurname 66",
                                                           "test 66",
                                                             "Test66@mail.com");
            deleateContact.Deleate(model, connection);

            allContacts = new GetAllContacts();
            contacts = allContacts.Get(connection);
            bool passFlag = true;
            foreach (ContactModel contact in contacts)
                if (contact.Surname.Equals("TestSurname 66")) passFlag = false;

            if (passFlag)
                Assert.Pass("Элемент отсутсвует в БД");
            else
                Assert.Fail("Ошибка удаления");
        }
    }
}
