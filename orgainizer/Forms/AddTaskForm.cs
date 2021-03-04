using orgainizer.Data;
using orgainizer.Data.Add;
using orgainizer.DataModels;
using System;
using System.Windows.Forms;

namespace orgainizer.Forms
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            TaskText.Text = "";
            PreorityPicker.Value = 0;
            DatePicker.Value = DateTime.Today;
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            if (TaskText.Text != "")
            {
                TasksModel task = new TasksModel(TaskText.Text, DatePicker.Value, (byte)PreorityPicker.Value);
                Reqester req = new Reqester(new AddTask());
                req.AddReqest(task);
                MessageBox.Show("Задача успешно добавленна", "Внимание!");
            }
            else MessageBox.Show("Введите текст задачи и повторите попытку", "Ошибка!");
        }

        private void AddTask_Shown(object sender, EventArgs e)
        {
            DatePicker.Value = DateTime.Today;
        }
    }
}
