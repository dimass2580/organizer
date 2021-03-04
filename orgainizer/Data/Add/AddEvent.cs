using orgainizer.DataModels;
using System.Data.OleDb;


namespace orgainizer.Data.Add
{
    public class AddEvent : IAddRequest
    {
        public void Add(IDataModel model, OleDbConnection connection)
        {
            var newEvent = (EventModel)model;
            string AppendQuery = $"INSERT INTO Events (DateOfEvent,Event)" +
                    $"VALUES('{newEvent.DateOfEvent}'" +
                    $",'{newEvent.Event}')";
            connection.Open();
            OleDbCommand query = new OleDbCommand(AppendQuery, connection);
            query.ExecuteNonQuery();
            connection.Close();
        }
    }
}
