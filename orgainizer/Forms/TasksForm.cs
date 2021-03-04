using orgainizer.Data;
using orgainizer.Data.Get;
using orgainizer.DataModels;
using System;
using System.Windows.Forms;

namespace orgainizer.Forms
{
    public partial class TasksForm : Form
    {
        public TasksForm()
        {
            InitializeComponent();
        }

        private void TasksForm_Shown(object sender, EventArgs e)
        {
            Reqester reqester = new Reqester(new GetAllTasks());
            var tasks = reqester.GetReqest();
            foreach (TasksModel task in tasks)
                TasksView.Rows.Add(task.ID, task.Task, task.EndDate, task.Preority, task.Ended);
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm addTask = new AddTaskForm();
            addTask.ShowDialog();
        }
    }
}
