using orgainizer.Data;
using orgainizer.Data.Deleate;
using orgainizer.Data.Get;
using orgainizer.Data.Update;
using orgainizer.DataModels;
using orgainizer.Forms;
using System;
using System.Windows.Forms;

namespace orgainizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Reqester reqester = new Reqester();

        //update View
        private void UpdateTable()
        {
            reqester.setGetRequest(new GetTodayEvents());
            EventView.Rows.Clear();
            var eventsList = reqester.GetReqest();
            foreach (EventModel row in eventsList)
            {
                EventView.Rows.Add(row.ID, row.DateOfEvent, row.Event);
            }

        }

        private void Append_Click(object sender, EventArgs e)
        {
            AddEventForm appendForm = new AddEventForm();
            appendForm.Show();
        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
            UpdateTable();
            if (reqester.getNotify())
            {
                taskNotify.BalloonTipText = "Есть задачи на сегодня. Просмотрите список в меню задач";
                taskNotify.BalloonTipTitle = "Уведомление о задачах";
                taskNotify.BalloonTipIcon = ToolTipIcon.Warning;
                taskNotify.Icon = Icon;
                taskNotify.Visible = true;
                taskNotify.ShowBalloonTip(1000);
            }
        }

        private void Deleate_Click(object sender, EventArgs e)
        {
            if (EventView.SelectedRows.Count == 1)
            {
                deleteDialog deleteDialog = new deleteDialog();
                if (deleteDialog.ShowDialog(this) == DialogResult.OK)
                {
                    EventModel model = new EventModel((int)EventView.SelectedRows[0].Cells[0].Value);
                    reqester.setDeleateRequest(new DeleateEvent());
                    reqester.DeleateReqest(model);
                    UpdateTable();
                }
            }
            else
            {
                MessageBox.Show("Выберите только 1 запись и повторите попытку", "Оказия!");
            }

        }

        private void EventView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            EventModel model = new EventModel((int)EventView.CurrentRow.Cells[0].Value,
                                               (string)EventView.CurrentCell.Value);
            reqester.setUpdateRequest(new UpdateEventText());
            reqester.UpdateReqest(model);
            UpdateTable();
        }

        private void сегодняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void всеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventView.Rows.Clear();
            reqester.setGetRequest(new GetAllEvents());
            var eventsList = reqester.GetReqest();
            foreach (EventModel row in eventsList)
                EventView.Rows.Add(row.ID, row.DateOfEvent, row.Event);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateEventDateForm editEventDate = new UpdateEventDateForm();
            editEventDate.Show();
        }

        private void ShowTasks_Click(object sender, EventArgs e)
        {
            TasksForm tasks = new TasksForm();
            tasks.Show();
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTask = new AddTaskForm();
            addTask.ShowDialog();
        }

        private void taskNotify_BalloonTipClosed(object sender, EventArgs e)
        {
            taskNotify.Visible = false;
        }

        private void HandBook_View_Click(object sender, EventArgs e)
        {
            HandBook handBook = new HandBook();
            handBook.Show();
        }

        private void добавитьКонтактToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
        }

        private void ShowIntercity_Click(object sender, EventArgs e)
        {
            IntercityCallsForm IC = new IntercityCallsForm();
            IC.Show();
        }
    }
}
