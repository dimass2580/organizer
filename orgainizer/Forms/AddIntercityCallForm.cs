using System;
using System.Windows.Forms;
using orgainizer.DataModels;
using orgainizer.Data;
using orgainizer.Data.Add;
using orgainizer.Data.Get;

namespace orgainizer.Forms
{
    public partial class AddIntercityCallForm : Form
    {
        public AddIntercityCallForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddSurname.Text.Length != 0 &&
                AddPhone.Text.Length != 0 &&
                  AddPrice.Text.Length != 0 &&
                    AddDuration.Text.Length != 0
                )
            {
                var price = AddPrice.Text.Replace(",", ".");
                DateTime date = AddDatePicker.Value.Date;

                IntercityCallModel model = new IntercityCallModel
                                                    (AddSurname.Text,
                                                    AddPhone.Text,
                                                    date,
                                                    int.Parse(AddDuration.Text),
                                                    double.Parse(price));

                Reqester req = new Reqester();
                req.setAddRequest(new AddIntercityCall());
                req.setGetRequest(new GetIntercityCalls());
                req.AddReqest(model);
                
                var IntercityDataView =
                    (Application.OpenForms["IntercityCallsForm"].Controls["ControlsLayout"].Controls["IntercityDataView"]
                        as DataGridView);
                IntercityDataView.Rows.Clear();

                
                var interCityLst = req.GetReqest();
                    foreach (EventModel row in interCityLst)
                     IntercityDataView.Rows.Add(row.ID, row.DateOfEvent, row.Event);
            }
            else
               MessageBox.Show("Заполните все поля и повторите попытку", "Ошибка");
        }
    }
}
