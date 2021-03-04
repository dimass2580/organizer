using orgainizer.DataModels;
using System.Data.OleDb;
using System.Globalization;

namespace orgainizer.Data.Add
{
    public class AddIntercityCall:IAddRequest
    {
        public void Add(IDataModel model, OleDbConnection connection)
        {


            IntercityCallModel call = (IntercityCallModel)model;
            string price = call.Price.ToString().Replace(",", ".");

            string AppendQuery = $"INSERT INTO IntercityCalls (Surname, Phone, DateOfCall, Duration, Price) " +
                $"VALUES('{call.Surname}'" +
                 $",'{call.Phone}'" +
                    $",'{call.DateOfCall}'"+
                        $",{call.Duration}" +
                           $",{price})";

            connection.Open();
            OleDbCommand query = new OleDbCommand(AppendQuery, connection);
            query.ExecuteNonQuery();
            connection.Close();
        }
    }
}
