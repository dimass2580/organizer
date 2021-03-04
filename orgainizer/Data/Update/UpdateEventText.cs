using orgainizer.DataModels;
using System.Data.OleDb;


namespace orgainizer.Data.Update
{
    public class UpdateEventText : IUpdateRequest
    {
        public void Update(IDataModel model, OleDbConnection connection)
        {
            var updatable = (EventModel)model;
            string updQue = $"UPDATE Events SET Event = '{updatable.Event}'" +
                    $" WHERE ID = {updatable.ID}";
            connection.Open();
            OleDbCommand updCommand = new OleDbCommand(updQue, connection);
            updCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
