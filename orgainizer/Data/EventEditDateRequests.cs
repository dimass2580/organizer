using orgainizer.Data.Get;
using orgainizer.Data.Update;
using orgainizer.DataModels;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace orgainizer.Data
{
    class EventEditDateRequests : Reqester
    {
        public EventEditDateRequests()
        {
            getRequest = new GetAllEvents();
            updateRequest = new UpdateEventDate();
        }



        public List<EventModel> findByDate(DateTime Date)
        {
            List<EventModel> contactModels = new List<EventModel>();
            connection.Open();
            string findReq = $"SELECT ID, DateOfEvent, Event FROM Events WHERE [DateOfEvent] = @dateOfEvent";
            OleDbCommand findCommand = new OleDbCommand(findReq, connection);
            findCommand.Parameters.Add(new OleDbParameter("@dateOfEvent", OleDbType.Date));
            findCommand.Parameters["@dateOfEvent"].Value = Date;
            OleDbDataReader reader = findCommand.ExecuteReader();

            while (reader.Read())
            {
                EventModel model = new EventModel((int)reader[0],
                                                    (DateTime)reader[1],
                                                      (string)reader[2]);
                contactModels.Add(model);
            }
            connection.Close();
            return contactModels;
        }

        public List<EventModel> findByText(string text)
        {
            List<EventModel> contactModels = new List<EventModel>();
            connection.Open();
            string findReq = $"SELECT ID, DateOfEvent, Event FROM Events WHERE Event LIKE '%{text}%'";
            OleDbCommand findCommand = new OleDbCommand(findReq, connection);
            OleDbDataReader reader = findCommand.ExecuteReader();

            while (reader.Read())
            {
                EventModel model = new EventModel((int)reader[0],
                                                    (DateTime)reader[1],
                                                      (string)reader[2]);
                contactModels.Add(model);
            }
            connection.Close();
            return contactModels;
        }


    }
}
