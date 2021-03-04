using orgainizer.DataModels;
using System.Collections.Generic;
using System.Data.OleDb;


namespace orgainizer.Data.Get
{
    public interface IGetRequest
    {
        List<IDataModel> Get(OleDbConnection connection);
    }
}
