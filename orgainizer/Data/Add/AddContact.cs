using orgainizer.DataModels;
using System.Data.OleDb;


namespace orgainizer.Data.Add
{
    public class AddContact : IAddRequest
    {
        public void Add(IDataModel model, OleDbConnection connection)
        {
            ContactModel contact = (ContactModel)model;
            string AppendQuery = $"INSERT INTO Contacts (Phone_Num, Surname, Initials, Email)" +
                $"VALUES('{contact.Phone}'" +
                 $",'{contact.Surname}'" +
                    $",'{contact.Initials}'" +
                        $",'{contact.Email}')";

            connection.Open();
            OleDbCommand query = new OleDbCommand(AppendQuery, connection);
            query.ExecuteNonQuery();
            connection.Close();
        }

    }
}
