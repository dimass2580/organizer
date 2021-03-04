using orgainizer.DataModels;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace orgainizer.Data.Get
{
    public class GetAllTasks : IGetRequest
    {
        public List<IDataModel> Get(OleDbConnection connection)
        {
            List<IDataModel> dataModels = new List<IDataModel>();
            connection.Open();
            string ReqText = $"SELECT * FROM Tasks";
            OleDbCommand getReq = new OleDbCommand(ReqText, connection);
            OleDbDataReader reader = getReq.ExecuteReader();
            TasksModel model;
            while (reader.Read())
            {
                model = new TasksModel((int)reader[0],
                                         (string)reader[1],
                                        (DateTime)reader[2],
                                        (bool)reader[3],
                                        (int)reader[4]
                                         );
                dataModels.Add(model);
            }
            connection.Close();
            return dataModels;
        }
    }
}
