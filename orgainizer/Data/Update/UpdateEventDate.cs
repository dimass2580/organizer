using orgainizer.DataModels;
using System.Data.OleDb;


namespace orgainizer.Data.Update
{
    public class UpdateEventDate : IUpdateRequest
    {
        public void Update(IDataModel model, OleDbConnection connection)
        {
            EventModel events = (EventModel)model;
            string updQue = $"UPDATE Events SET DateOfEvent = @dateOfEvent" +
                $" WHERE ID = {model.ID}";
            OleDbCommand updCommand = new OleDbCommand(updQue, connection);
            updCommand.Parameters.Add(new OleDbParameter("@dateOfEvent", OleDbType.Date));
            updCommand.Parameters["@dateOfEvent"].Value = events.DateOfEvent.ToShortDateString();
            connection.Open();
            updCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
