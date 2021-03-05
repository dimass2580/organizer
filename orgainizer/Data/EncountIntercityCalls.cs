using System;
using System.Data.OleDb;

namespace orgainizer.Data
{
    class EncountIntercityCalls:Reqester
    {
       public uint EncountByCode(string code)
        {
            var cmdText = $"SELECT * FROM IntercityCalls WHERE Phone LIKE '{code}%'";
            connection.Open();
            OleDbCommand getReq = new OleDbCommand(cmdText, connection);
            OleDbDataReader reader = getReq.ExecuteReader();
            uint encounter = 0;
            while(reader.Read())
            {
                encounter++;
            }
            connection.Close();
            Console.WriteLine($"Finded {encounter} rows by {code} city code");
            return encounter;
        }
    }
}
