

using orgainizer.DataModels;
using System;
using System.Data.OleDb;

namespace orgainizer.Data.Deleate
{
    public class DeleateIntercityCall:IDeleateRequest
    {
        /// <summary>
        /// Удаление записи из таблицы IntercityCall. Поиск записи по полю ID модели
        /// </summary>
        /// <param name="model"></param>
        /// <param name="connection"></param>
        public void Deleate(IDataModel model, OleDbConnection connection)
        { 
            string delQuery = $"DELETE FROM IntercityCalls WHERE ID =" +
                        $" {model.ID}";
            connection.Open();
            OleDbCommand Del = new OleDbCommand(delQuery, connection);
            Console.WriteLine(Del.ExecuteNonQuery());
            connection.Close();
        }
    }
}
