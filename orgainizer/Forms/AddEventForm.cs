using orgainizer.Data;
using orgainizer.Data.Add;
using orgainizer.Data.Get;
using orgainizer.DataModels;
using System;
using System.Windows.Forms;

namespace orgainizer.Forms
{
    public partial class AddEventForm : Form
    {
        public AddEventForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EventText.Text = "";
            DatePicker.Value = DateTime.Now;
        }

        private void AppendButton_Click(object sender, EventArgs e)
        {
            if (EventText.Text != "")
            {
                EventModel newEvent = new EventModel(
                    DatePicker.Value.Date, EventText.Text);
                Reqester reqester = new Reqester();
                reqester.setAddRequest(new AddEvent());
                reqester.AddReqest(newEvent);
                var EventView =
                    (Application.OpenForms["MainForm"].Controls["LayoutPanel"].Controls["EventView"]
                        as DataGridView);
                EventView.Rows.Clear();
                reqester.setGetRequest(new GetTodayEvents());
                var eventsList = reqester.GetReqest();
                foreach (EventModel row in eventsList)
                    EventView.Rows.Add(row.ID, row.DateOfEvent, row.Event);
            }
        }
    }
}
