using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using orgainizer.Data;
using orgainizer.DataModels;

namespace orgainizer.Forms
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        Selection selectionReqs = new Selection();

        private void startSelectionButton_Click(object sender, EventArgs e)
        {
           
            var selections = selectionReqs.CreateNewSelection(
                                        startDatePicker.Value.Date, 
                                            endDatePicker.Value.Date);
            foreach(IntercitySelection item in selections)
            {
                SelectionDataView.Rows.Add(item.callPrice, item.Date, item.surname);
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            List<IDataModel> Sorted;

            switch (SortTable.SelectedIndex)
            {
                case 0:
                   Sorted =  selectionReqs.GroupBy(GroupRows.Cost);
                    break;
                case 1:
                    Sorted = selectionReqs.GroupBy(GroupRows.Date);
                    break;
                case 2:
                    Sorted = selectionReqs.GroupBy(GroupRows.Surname);
                    break;
                default:
                    Sorted = selectionReqs.GroupBy(GroupRows.Cost);
                    break;
            }

            SelectionDataView.Rows.Clear();
            foreach(IntercitySelection item in Sorted)
            {
                SelectionDataView.Rows.Add(item.callPrice,
                                            item.Date,
                                            item.surname);
            }

        }

        private void AddPercentsButton_Click(object sender, EventArgs e)
        {

           var All =  selectionReqs.GroupBy(GroupRows.Cost);
            SelectionDataView.Rows.Clear();
            List<IDataModel> updatedList = new List<IDataModel>();

            switch(PercentsEn.SelectedIndex)
            {
                case 0:
                    foreach (IntercitySelection item in All)
                    {
                        IntercitySelection model = new IntercitySelection(
                                  item.callPrice + (item.callPrice / 100) * 5,
                                    item.Date, 
                                       item.surname);
                        updatedList.Add(model);
                     }
                    break;
                case 1:
                    foreach (IntercitySelection item in All)
                    {
                        IntercitySelection model = new IntercitySelection(
                                  item.callPrice + (item.callPrice / 100) * 10,
                                    item.Date,
                                       item.surname);
                        updatedList.Add(model);
                    }
                    break;
                case 2:
                    foreach (IntercitySelection item in All)
                    {
                        IntercitySelection model = new IntercitySelection(
                                item.callPrice+(item.callPrice / 100) * 15,
                                    item.Date,
                                       item.surname);
                        updatedList.Add(model);
                    }
                    break;
                case 3:
                    foreach (IntercitySelection item in All)
                    {
                        IntercitySelection model = new IntercitySelection(
                                  item.callPrice + (item.callPrice / 100) * 20,
                                    item.Date,
                                       item.surname);
                        updatedList.Add(model);
                    }
                    break;
                default:
                    foreach (IntercitySelection item in All)
                    {
                        IntercitySelection model = new IntercitySelection(
                                  item.callPrice + (item.callPrice / 100) * 5,
                                    item.Date,
                                       item.surname);
                        updatedList.Add(model);
                    }
                    break;
            }

            foreach(IntercitySelection item in updatedList)
                                        selectionReqs.Update(item);

            updatedList = selectionReqs.GroupBy(GroupRows.Cost);
            foreach (IntercitySelection item in updatedList)
                SelectionDataView.Rows.Add(item.callPrice,
                                                item.Date,
                                                    item.surname);
        }
    }
}
