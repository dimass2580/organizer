using System;
using System.Windows.Forms;
using orgainizer.DataModels;
using orgainizer.Data;
using orgainizer.Data.Add;
using orgainizer.Data.Get;
using System.Text.RegularExpressions;
using System.Linq;

namespace orgainizer.Forms
{
    public partial class AddCall : Form
    {
        public AddCall()
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
                if (!Regex.IsMatch(AddPrice.Text, "^[0-9,.]+$"))
                {
                    MessageBox.Show("В поле цена должно быть указано число с запятой или точкой в формате 0,00 либо 0.00",
                                                                                                                "Ошибка ввода");
                }
                else
                {
                    var priceT = AddPrice.Text.Contains(".") ? AddPrice.Text.Replace('.', ',') : AddPrice.Text;
                    double price = Convert.ToDouble(priceT);
                    var duration = int.Parse(AddDuration.Text);


                    //проверить!!
                    IntercityCallModel model = new IntercityCallModel
                                                        (AddSurname.Text,
                                                        AddPhone.Text,
                                                         AddDatePicker.Value.Date,
                                                         duration,
                                                         price
                                                         );

                    Reqester req = new Reqester();
                    req.setAddRequest(new AddIntercityCall());
                    req.setGetRequest(new GetIntercityCalls());
                    req.AddReqest(model);

                    IntercityCallsForm form = Application.OpenForms.OfType<IntercityCallsForm>().Single();
                    form.UpdateAllView();
                }
            }
            else
                MessageBox.Show("Заполните все поля и повторите попытку", "Ошибка");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
