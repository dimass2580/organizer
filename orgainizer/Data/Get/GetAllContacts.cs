
using orgainizer.DataModels;
using System.Collections.Generic;
using System.Data.OleDb;

namespace orgainizer.Data.Get
{
    public class GetAllContacts : IGetRequest
    {
        public List<IDataModel> Get(OleDbConnection connection)
        {
            List<IDataModel> contacts = new List<IDataModel>();
            string Req = $"SELECT * FROM Contacts";
            connection.Open();
            OleDbCommand getCommand = new OleDbCommand(Req, connection);
            OleDbDataReader reader = getCommand.ExecuteReader();
            ContactModel model;
            while (reader.Read())
            {
                model = new ContactModel((int)reader[0],
                                            (string)reader[1], (string)reader[2],
                                                (string)reader[3], (string)reader[4]);
                contacts.Add(model);
            }
            connection.Close();
            return contacts;
        }

    }
}
