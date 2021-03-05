using orgainizer.Data.Add;
using orgainizer.Data.Deleate;
using orgainizer.Data.Get;
using orgainizer.Data.Update;
using orgainizer.DataModels;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace orgainizer.Data
{
    /// <summary>
    /// Предоставляет работу с базой данных
    /// /// </summary>
    public class Reqester
    {


        protected OleDbConnection connection = new OleDbConnection(connectionString);

        protected const string connectionString =
                       "Provider=Microsoft.Jet.OLEDB.4.0;" +
                        "Data Source=calls.mdb;";

        protected IAddRequest addRequest;
        protected IDeleateRequest deleateRequest;
        protected IGetRequest getRequest;
        protected IUpdateRequest updateRequest;

        public Reqester()
        {

        }

        public Reqester(IAddRequest addRequest) =>
                        this.addRequest = addRequest;

        public Reqester(IDeleateRequest deleateRequest) =>
                        this.deleateRequest = deleateRequest;

        public Reqester(IGetRequest getRequest) =>
                        this.getRequest = getRequest;

        public Reqester(IUpdateRequest updateRequest) =>
                        this.updateRequest = updateRequest;

        public Reqester(IAddRequest addRequest,
                        IDeleateRequest deleateRequest,
                        IGetRequest getRequest,
                        IUpdateRequest updateRequest)
        {
            this.addRequest = addRequest;
            this.deleateRequest = deleateRequest;
            this.getRequest = getRequest;
            this.updateRequest = updateRequest;
        }

        public Reqester(IDeleateRequest deleateRequest,
                       IGetRequest getRequest)
        {
            this.deleateRequest = deleateRequest;
            this.getRequest = getRequest;
        }

        /// <summary>
        /// производит запрос к базе данных для получения данных из таблицы
        /// </summary>
        /// <returns></returns>
        public List<IDataModel> GetReqest() =>
                            getRequest.Get(connection);

        /// <summary>
        /// Производит запрос к базе данных для добавления элемента в таблицу
        /// </summary>
        /// <param name="model"></param>
        public void AddReqest(IDataModel model) =>
                    addRequest.Add(model, connection);

        /// <summary>
        /// Производит запрос на удаление элемента из базы данных
        /// </summary>
        /// <param name="model"></param>
        public void DeleateReqest(IDataModel model) =>
                    deleateRequest.Deleate(model, connection);

        /// <summary>
        /// производит запрос  на обновление данных элемента базы данных
        /// </summary>
        /// <param name="model"></param>
        public void UpdateReqest(IDataModel model) =>
                    updateRequest.Update(model, connection);

        /// <summary>
        /// Осуществление выбора запроса на обновление элемента базы данных
        /// </summary>
        /// <param name="request"></param>
        public void setUpdateRequest(IUpdateRequest request) =>
                                            updateRequest = request;

        /// <summary>
        /// Осуществление выбора запроса на удаление элемента базы данных
        /// </summary>
        /// <param name="request"></param>
        public void setDeleateRequest(IDeleateRequest request) =>
                                            deleateRequest = request;

        /// <summary>
        /// Осуществление выбора запроса на добавление элемента базы данных
        /// </summary>
        /// <param name="request"></param>
        public void setAddRequest(IAddRequest request) =>
                                        addRequest = request;

        /// <summary>
        /// Осуществление выбора запроса на получение элементов базы данных
        /// </summary>
        /// <param name="request"></param>
        public void setGetRequest(IGetRequest request) =>
                                        getRequest = request;

        /// <summary>
        /// Возвращает true если в базе данных найдены задачи на дату, заданную в системе
        /// </summary>
        /// <returns></returns>
        public bool getNotify()
        {
            DateTime date;
            date = DateTime.Today;

            connection.Open();
            string ReqText = $"SELECT * FROM Tasks WHERE End_Date = @Today";
            OleDbCommand getReq = new OleDbCommand(ReqText, connection);
            getReq.Parameters.Add(new OleDbParameter("@Today", OleDbType.Date));
            getReq.Parameters["@Today"].Value = date;
            OleDbDataReader reader = getReq.ExecuteReader();

            if (reader.HasRows)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
    }

}
