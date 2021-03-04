using System;
/// <summary>
/// Модель для представления таблицы Tasks
/// </summary>
namespace orgainizer.DataModels
{
    public class TasksModel : IDataModel
    {
        public string Task { get; }
        public DateTime EndDate { get; }
        public bool Ended { get; }
        public int Preority { get; }
        public int ID { get; }


        public TasksModel(string Task, DateTime EndDate, int Preority)
        {
            this.Task = Task;
            this.EndDate = EndDate;
            this.Preority = Preority;
            this.Ended = false;
        }

        public TasksModel(int ID, string Task, DateTime EndDate, bool Ended, int Preority)
        {
            this.ID = ID;
            this.Task = Task;
            this.EndDate = EndDate;
            this.Preority = Preority;
            this.Ended = Ended;
        }
    }
}
