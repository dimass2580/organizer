using orgainizer.DataModels;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace orgainizer.Data.Get
{
    public class GetIntercityCalls : IGetRequest
    {
        public List<IDataModel> Get(OleDbConnection connection)
        {
            List<IDataModel> events = new List<IDataModel>();
            connection.Open();
            string ReqText = $"SELECT * FROM IntercityCalls";
            OleDbCommand getReq = new OleDbCommand(ReqText, connection);
            OleDbDataReader reader = getReq.ExecuteReader();

            while (reader.Read())
            {
                IntercityCallModel model = new IntercityCallModel((int)(reader[0]),
                                            (string)reader[1],(string)reader[2], (DateTime)reader[3],
                                            (int)reader[4],(double)reader[5]);
                events.Add(model);
            }
            connection.Close();
            return events;
        }
    }
}
