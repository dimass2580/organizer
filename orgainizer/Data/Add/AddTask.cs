using orgainizer.DataModels;
using System.Data.OleDb;

namespace orgainizer.Data.Add
{
   public  class AddTask : IAddRequest
    {
        public void Add(IDataModel model, OleDbConnection connection)
        {
            TasksModel task = (TasksModel)model;
            string AppendQuery = $"INSERT INTO Tasks (Task,End_Date,Preority,Ended) " +
               $"VALUES('{task.Task}'" +
               $",'{task.EndDate}'" +
                $",{task.Preority}" +
                $",{task.Ended})";
            connection.Open();
            OleDbCommand query = new OleDbCommand(AppendQuery, connection);
            query.ExecuteNonQuery();
            connection.Close();
        }

    }
}
