using orgainizer.DataModels;
using System.Data.OleDb;


namespace orgainizer.Data.Update
{
    class UpdateIntercityCall:IUpdateRequest
    {
        public void Update(IDataModel model, OleDbConnection connection)
        {
            IntercityCallModel callModel = (IntercityCallModel)model;
            string updQue = $"UPDATE IntercityCalls SET " +
                $"Surname = '{callModel.Surname}'," +
                $"Phone = '{callModel.Phone}'," +
                $"DateOfCall = @dateOfCall," +
                $"Duration = {callModel.Duration}," +
                $"Price = @price" +
                $" WHERE ID = {model.ID}";
            OleDbCommand updCommand = new OleDbCommand(updQue, connection);
            updCommand.Parameters.Add(new OleDbParameter("@dateOfCall", OleDbType.Date));
            updCommand.Parameters["@dateOfCall"].Value = callModel.DateOfCall.ToShortDateString();
            updCommand.Parameters.Add(new OleDbParameter("@price", OleDbType.Double));
            updCommand.Parameters["@price"].Value = callModel.Price;
            connection.Open();
            updCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
