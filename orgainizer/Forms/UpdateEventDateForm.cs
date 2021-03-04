using orgainizer.Data;
using orgainizer.DataModels;
using System;
using System.Windows.Forms;

namespace orgainizer.Forms
{
    public partial class UpdateEventDateForm : Form
    {
        public UpdateEventDateForm()
        {
            InitializeComponent();
        }

        EventEditDateRequests eventEdit = new EventEditDateRequests();

        private void find2_Click(object sender, EventArgs e)
        {
            EventView1.Rows.Clear();
            var finded = eventEdit.findByText(textToFind.Text);
            foreach (EventModel model in finded)
                EventView1.Rows.Add(model.ID, model.DateOfEvent, model.Event);
        }

        private void Find1_Click(object sender, EventArgs e)
        {
            EventView1.Rows.Clear();

            var finded = eventEdit.findByDate(findTime.Value.Date);
            foreach (EventModel model in finded)
                EventView1.Rows.Add(model.ID, model.DateOfEvent, model.Event);
        }

        ////edit Rows
        private void edit1_Click(object sender, EventArgs e)
        {
            if (EventView1.SelectedRows.Count == 1)
            {
                var cells = EventView1.SelectedRows[0].Cells;
                EventModel model = new EventModel((int)cells[0].Value,
                                                    (DateTime)setTime1.Value.Date,
                                                    (string)cells[2].Value);
                eventEdit.UpdateReqest(model);
                var finded = eventEdit.findByDate(setTime1.Value.Date);
                EventView1.Rows.Clear();
                foreach (EventModel item in finded)
                    EventView1.Rows.Add(item.ID, item.DateOfEvent, item.Event);
            }
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            if (EventView1.SelectedRows.Count == 1)
            {
                var cells = EventView1.SelectedRows[0].Cells;
                EventModel model = new EventModel((int)cells[0].Value,
                                                    (DateTime)setTime1.Value.Date,
                                                    (string)cells[2].Value);
                eventEdit.UpdateReqest(model);
                var finded = eventEdit.findByDate(setTime1.Value.Date);
                EventView1.Rows.Clear();
                foreach (EventModel item in finded)
                    EventView1.Rows.Add(item.ID, item.DateOfEvent, item.Event);
            }
        }
    }
}
