using orgainizer.DataModels;
using System.Data.OleDb;


namespace orgainizer.Data.Add
{
    public interface IAddRequest
    {
        void Add(IDataModel model, OleDbConnection connection);
    }
}
