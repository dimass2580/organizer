using orgainizer.Data.Add;
using orgainizer.Data.Deleate;
using orgainizer.Data.Get;
using orgainizer.DataModels;
using System.Collections.Generic;
using System.Data.OleDb;

namespace orgainizer.Data
{
    class ContactsRequests : Reqester
    {
        public ContactsRequests()
        {
            addRequest = new AddContact();
            deleateRequest = new DeleateContact();
            getRequest = new GetAllContacts();
        }

        public List<ContactModel> Find(string key, string field)
        {
            List<ContactModel> contacts = new List<ContactModel>();
            string getReq = $"SELECT * FROM Contacts WHERE {field} like '%{key}%'";
            connection.Open();
            OleDbCommand getCommand = new OleDbCommand(getReq, connection);
            OleDbDataReader reader = getCommand.ExecuteReader();
            while (reader.Read())
            {
                ContactModel row = new ContactModel((int)reader[0],
                                                       (string)reader[1], (string)reader[2],
                                                         (string)reader[3], (string)reader[4]);
                contacts.Add(row);
            }
            connection.Close();
            return contacts;
        }
    }
}
