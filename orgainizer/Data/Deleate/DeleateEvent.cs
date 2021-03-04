using orgainizer.DataModels;
using System;
using System.Data.OleDb;

namespace orgainizer.Data.Deleate
{
    public class DeleateEvent : IDeleateRequest
    {
        /// <summary>
        /// Удаление записи из таблицы Events. Поиск записи по полю ID модели
        /// </summary>
        /// <param name="model"></param>
        /// <param name="connection"></param>
        public void Deleate(IDataModel model, OleDbConnection connection)
        {
            var removable = (EventModel)model;
            string delQuery = $"DELETE FROM Events WHERE ID =" +
                        $" {removable.ID}";
            connection.Open();
            OleDbCommand Del = new OleDbCommand(delQuery, connection);
            Console.WriteLine(Del.ExecuteNonQuery());
            connection.Close();
        }
    }
}
