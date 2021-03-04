using orgainizer.DataModels;
using System.Data.OleDb;


namespace orgainizer.Data.Deleate
{
    public interface IDeleateRequest
    {
        void Deleate(IDataModel model, OleDbConnection connection);
    }
}
