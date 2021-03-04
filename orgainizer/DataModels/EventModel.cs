using System;

/// <summary>
/// Модель для представления таблицы Events
/// </summary>
namespace orgainizer.DataModels
{
    public class EventModel : IDataModel
    {
        public EventModel(int ID)
        {
            this.ID = ID;
        }

        public EventModel(int ID, string Event)
        {
            this.ID = ID;
            this.Event = Event;
        }

        public EventModel(DateTime DateOfEvent, string Event)
        {
            this.DateOfEvent = DateOfEvent;
            this.Event = Event;
        }

        public EventModel(int ID, DateTime DateOfEvent, string Event)
        {
            this.ID = ID;
            this.DateOfEvent = DateOfEvent;
            this.Event = Event;
        }

        public int ID { get; }
        public DateTime DateOfEvent { get; }
        public string Event { get; }
    }
}
