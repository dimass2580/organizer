using orgainizer.DataModels;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using orgainizer.Data.Add;
using orgainizer.Data.Deleate;
using orgainizer.Data.Get;
using System.Data;

namespace orgainizer.Data
{
    enum GroupRows
    {
        Surname,
        Date,
        Cost 
    }

    class Selection:Reqester
    {
        public Selection()
        {
            addRequest = new AddIntercityCall();
            deleateRequest = new DeleateIntercityCall();
            getRequest = new GetIntercityCalls();
        }

        string tableName { get; set; }
        
        public string getTableName()
        {
            return tableName;
        }

        public Selection(string tableName)
        {
            this.tableName = tableName;
        }

        private List<IDataModel> Get()
        {
            List<IDataModel> selections = new List<IDataModel>();
            connection.Open();
            string ReqText = $"SELECT * FROM {tableName}";
            OleDbCommand getReq = new OleDbCommand(ReqText, connection);
            OleDbDataReader reader = getReq.ExecuteReader();

            while (reader.Read())
            {
                IntercitySelection model = new IntercitySelection((double)(reader[1]),
                                                            (DateTime)reader[2], (string)reader[3]);
                selections.Add(model);
            }
            connection.Close();
            return selections;
        }

        private int GetTablesCount()
        {
            connection.Open();
            int count = 0;
           DataTable tables = connection.GetSchema("Tables", new string[] { null, null, null, "TABLE" });
            foreach(DataRow item in tables.Rows)
            {
                Console.WriteLine(item["TABLE_NAME"]);
                count += 1;
            }

            connection.Close();
            return count;
        }

        public void Add(IDataModel model)
        {
            IntercitySelection call = (IntercitySelection)model;
            string price = call.callPrice.ToString().Replace(",", ".");

            string AppendQuery = $"INSERT INTO {tableName}(Cost, DateOfCall,SURNAME) " +
                $"VALUES({price}" +
                 $",'{call.Date}'" +
                        $",'{call.surname}')";

            connection.Open();
            OleDbCommand query = new OleDbCommand(AppendQuery, connection);
            query.ExecuteNonQuery();
            connection.Close();
        }

        private List<IDataModel> GetRange(DateTime startDate, DateTime endDate)
        {
            var getRangeReq = "SELECT * FROM IntercityCalls WHERE DateOfCall " +
                "BETWEEN @startDate AND @endDate";
            connection.Open();

            OleDbCommand getReq = new OleDbCommand(getRangeReq, connection);
            getReq.Parameters.Add(new OleDbParameter("@startDate",OleDbType.Date));
            getReq.Parameters.Add(new OleDbParameter("@endDate", OleDbType.Date));
            getReq.Parameters["@startDate"].Value = startDate.Date;
            getReq.Parameters["@endDate"].Value = endDate.Date;

            OleDbDataReader reader = getReq.ExecuteReader();
                    List<IDataModel> Ranged = new List<IDataModel>();

            while (reader.Read())
            {
                IntercityCallModel model = new IntercityCallModel((int)(reader[0]),
                                            (string)reader[1], (string)reader[2], (DateTime)reader[3],
                                            (int)reader[4], (double)reader[5]);
                Ranged.Add(model);
            }
            connection.Close();

            return Ranged;
        }

        public List<IDataModel> CreateNewSelection(DateTime start, DateTime end)
        {

             var Tcount = GetTablesCount();
            tableName = $"Selection{Tcount}";
            var createReq =  $"CREATE TABLE {tableName} " +
                $"(Code COUNTER CONSTRAINT PrimaryKey PRIMARY KEY," +
                $"Cost DOUBLE," +
                $"DateOfCall DATETIME," +
                $"SURNAME VARCHAR)";
            connection.Open();
            OleDbCommand Reqest = new OleDbCommand(createReq, connection);
            Reqest.ExecuteNonQuery();
            connection.Close();

           var Ranged = GetRange(start,end);
            foreach (IntercityCallModel item in Ranged)
            {
                IntercitySelection selItem = new IntercitySelection(
                    item.Duration * item.Price,
                        item.DateOfCall, 
                            item.Surname);
                Add(selItem);
            }

            return Get(); 
        }

        public List<IDataModel> GroupBy(GroupRows groupName)
        {
            string switchVar = "";
            switch(groupName)
            {
                case GroupRows.Surname:
                    switchVar = "SURNAME";
                        break;
                case GroupRows.Date:
                    switchVar = "DateOfCall";
                    break;
                case GroupRows.Cost:
                    switchVar = "Cost";
                    break;
            }
            
            List<IDataModel> selections = new List<IDataModel>();
            connection.Open();
            string ReqText = $"SELECT * FROM {tableName} ORDER BY {switchVar}";
            OleDbCommand getReq = new OleDbCommand(ReqText, connection);
            OleDbDataReader reader = getReq.ExecuteReader();

            while (reader.Read())
            {
                IntercitySelection model = new IntercitySelection((double)(reader[1]),
                                                            (DateTime)reader[2], (string)reader[3]);
                selections.Add(model);
            }
            connection.Close();
            return selections;
        }

        public void Update(IDataModel model)
        {
            IntercitySelection SelModel = (IntercitySelection) model;
            string cost = SelModel.callPrice.ToString().Replace(".", ",");
            string updQue = $"UPDATE {tableName} SET Cost = @price" +
                $" WHERE SURNAME LIKE '{SelModel.surname}'";
            OleDbCommand updCommand = new OleDbCommand(updQue, connection);
            updCommand.Parameters.Add(new OleDbParameter("@price", OleDbType.Double));
            updCommand.Parameters["@price"].Value = cost;
            connection.Open();
            updCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
