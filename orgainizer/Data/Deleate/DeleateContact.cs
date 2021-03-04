using orgainizer.DataModels;
using System.Data.OleDb;

namespace orgainizer.Data.Deleate
{
    public class DeleateContact : IDeleateRequest
    {
        /// <summary>
        /// Удаление записи из таблицы Contacts. Поиск записи по полю ID модели
        /// </summary>
        /// <param name="model"></param>
        /// <param name="connection"></param>
        public void Deleate(IDataModel model, OleDbConnection connection)
        {
            string delQuery = $"DELETE FROM Contacts WHERE ID =" +
                        $" {model.ID}";
            connection.Open();
            OleDbCommand Del = new OleDbCommand(delQuery, connection);
            Del.ExecuteNonQuery();
            connection.Close();
        }
    }
}
