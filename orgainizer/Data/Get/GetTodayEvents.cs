using orgainizer.DataModels;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace orgainizer.Data.Get
{
    public class GetTodayEvents : IGetRequest
    {
        public List<IDataModel> Get(OleDbConnection connection)
        {
            List<IDataModel> events = new List<IDataModel>();
            connection.Open();
            string today = DateTime.Now.ToShortDateString();
            string ReqText = $"SELECT ID, DateOfEvent, Event FROM Events WHERE DateOfEvent LIKE '%{today}%'";
            OleDbCommand getReq = new OleDbCommand(ReqText, connection);
            OleDbDataReader reader = getReq.ExecuteReader();

            while (reader.Read())
            {
                EventModel model = new EventModel((int)reader[0],
                                            (DateTime)reader[1], (string)reader[2]);
                events.Add(model);
            }
            connection.Close();
            return events;
        }
    }
}
