using orgainizer.DataModels;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace orgainizer.Data.Get
{
    public class GetAllEvents : IGetRequest
    {
        public List<IDataModel> Get(OleDbConnection connection)
        {
            List<IDataModel> events = new List<IDataModel>();
            connection.Open();
            string ReqText = $"SELECT ID, DateOfEvent, Event FROM Events";
            OleDbCommand getReq = new OleDbCommand(ReqText, connection);
            OleDbDataReader reader = getReq.ExecuteReader();

            while (reader.Read())
            {
                EventModel model = new EventModel((int)(reader[0]),
                                            (DateTime)reader[1], (string)reader[2]);
                events.Add(model);
            }
            connection.Close();
            return events;
        }
    }
}
