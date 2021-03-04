using orgainizer.DataModels;
using System.Data.OleDb;


namespace orgainizer.Data.Update
{
    public interface IUpdateRequest
    {
        void Update(IDataModel model, OleDbConnection connection);
    }
}
