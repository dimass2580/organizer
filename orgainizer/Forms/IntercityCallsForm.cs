using System;
using System.Threading;
using System.Windows.Forms;
using orgainizer.Data;
using orgainizer.Data.Add;
using orgainizer.Data.Deleate;
using orgainizer.Data.Get;
using orgainizer.Data.Update;
using orgainizer.DataModels;

namespace orgainizer.Forms
{
    public partial class IntercityCallsForm : Form
    {
        public IntercityCallsForm()
        {
            InitializeComponent();
        }

        private Reqester reqester = new Reqester(
                                        new AddIntercityCall(),
                                        new DeleateIntercityCall(),
                                        new GetIntercityCalls(),
                                        new UpdateIntercityCall()
                                        );

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            AddCall addForm = new AddCall();
            addForm.ShowDialog();
        }
        public void UpdateAllView()
        {
            var calls = reqester.GetReqest();
            IntercityDataView.Rows.Clear();
            double summ = 0;
            double max = 0;
            foreach (IntercityCallModel call in calls)
            {
                if (call.Price * call.Duration > max)
                    max = call.Price * call.Duration;

                summ += call.Price * call.Duration;

                if (call.Phone.Length < 5)
                    MessageBox.Show("Номер слишком короткий", "Ошибка");
                else
                {
                    string code = "";
                    for (byte charNum = 0; charNum < 5; charNum++)
                        code += call.Phone[charNum];
                    IntercityDataView.Rows.Add(call.Surname,
                                               call.Phone,
                                               call.DateOfCall.ToString(),
                                               code,
                                               call.Duration.ToString(),
                                               call.Price.ToString());
                }  
            }

            MaxCost.Text = $"Максимальная стоймость разговора: {max}";
            SummOfCost.Text = $"Суммарная стоймость разговоров: {summ}";
        }

        private void IntercityCallsForm_Shown(object sender, System.EventArgs e)
        {
            UpdateAllView();
        }

        private void DelButton_Click(object sender, System.EventArgs e)
        {
            IntercityCallModel model;
            var elements = reqester.GetReqest();
            foreach(IntercityCallModel element in elements)
            {
                if (
                    IntercityDataView.SelectedRows[0].Cells[0].Value.ToString() == element.Surname &&
                    IntercityDataView.SelectedRows[0].Cells[1].Value.ToString() == element.Phone &&
                    int.Parse(IntercityDataView.SelectedRows[0].Cells[4].Value.ToString()) == element.Duration
                    )
                {
                    model = new IntercityCallModel(element.ID);
                    reqester.DeleateReqest(model);
                    Console.WriteLine($"Deleated element in {element.ID} ID");
                }
                else
                {
                    Console.WriteLine($"{element.ID}" +
                                        $"{element.Phone}" +
                                            $"{element.Duration}" +
                                                $"{element.Surname}");
                    Console.WriteLine($"{IntercityDataView.SelectedRows[0].Cells[0].Value}" +
                                        $"{IntercityDataView.SelectedRows[0].Cells[1].Value}" +
                                            $"{IntercityDataView.SelectedRows[0].Cells[4].Value}");
                }
            }
            UpdateAllView();
            
        }

        private void Code_TextChanged(object sender, EventArgs e)
        {

        }

        private void Code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EncountIntercityCalls encount = new EncountIntercityCalls();
                uint  number = encount.EncountByCode(Code.Text);
                FindResult.Text = number.ToString();
            }
        }

        private void IntercityDataView_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            
        }

        private void IntercityDataView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IntercityDataView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            IntercityCallModel model = new IntercityCallModel(
                                            IntercityDataView.Rows[row].Cells[0].Value.ToString(),
                                            IntercityDataView.Rows[row].Cells[1].Value.ToString(),
                                            DateTime.Parse(IntercityDataView.Rows[row].Cells[2].Value.ToString()),
                                            int.Parse(IntercityDataView.Rows[row].Cells[4].Value.ToString()),
                                            double.Parse(IntercityDataView.Rows[row].Cells[5].Value.ToString())
                                            );
            var elements = reqester.GetReqest();
            int ID = 0;
            foreach (IntercityCallModel element in elements)
            {
                if (element.Phone.Equals(model.Phone) ||
                    element.Surname.Equals(model.Surname) ||
                    element.Price.Equals(model.Price) ||
                    element.Duration.Equals(model.Duration)
                    )
                {
                    ID = element.ID;
                }
            }

            model = new IntercityCallModel(ID,
                                            IntercityDataView.Rows[row].Cells[0].Value.ToString(),
                                            IntercityDataView.Rows[row].Cells[1].Value.ToString(),
                                            DateTime.Parse(IntercityDataView.Rows[row].Cells[2].Value.ToString()),
                                            int.Parse(IntercityDataView.Rows[row].Cells[4].Value.ToString()),
                                            double.Parse(IntercityDataView.Rows[row].Cells[5].Value.ToString())
                                            );

            reqester.UpdateReqest(model);
            Thread.Sleep(1000);
            UpdateAllView();
        }
    }
}
