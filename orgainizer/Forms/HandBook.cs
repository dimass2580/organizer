using orgainizer.Data;
using orgainizer.DataModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace orgainizer.Forms
{
    public partial class HandBook : Form
    {
        public HandBook()
        {
            InitializeComponent();
        }

        ContactsRequests contactsReq = new ContactsRequests();

        private void HandBook_Shown(object sender, EventArgs e)
        {
            ContactsView.Rows.Clear();
            UpdateView();
        }

        public void UpdateView()
        {
            ContactsView.Rows.Clear();
            var allContacts = contactsReq.GetReqest();

            foreach (ContactModel model in allContacts)
            {
                ContactsView.Rows.Add(model.ID.ToString(), model.Phone, model.Surname, model.Initials, model.Email);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddContactForm addContact = new AddContactForm();
            addContact.Show();
        }

        //update view by keyword and field in contacts table
        private void findButton_Click(object sender, EventArgs e)
        {
            ContactsView.Rows.Clear();
            List<ContactModel> findedContacts;

            if (byKey.Checked)
            {
                findedContacts = contactsReq.Find(KeyToFind.Text, "ID");
            }
            else if (byMail.Checked)
            {
                findedContacts = contactsReq.Find(KeyToFind.Text, "EMail");
            }
            else if (bySurname.Checked)
            {
                findedContacts = contactsReq.Find(KeyToFind.Text, "Surname");
            }
            else
            {
                findedContacts = contactsReq.Find(KeyToFind.Text, "Phone_Num");
            }

            ContactsView.Rows.Clear();
            foreach (ContactModel model in findedContacts)
            {
                ContactsView.Rows.Add(model.ID.ToString(), model.Phone, model.Surname, model.Initials, model.Email);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ContactsView.SelectedRows.Count == 1)
            {
                deleteDialog deleteDialog = new deleteDialog();
                if (deleteDialog.ShowDialog(this) == DialogResult.OK)
                {
                    var cellCollection = ContactsView.CurrentRow.Cells;
                    ContactModel model = new ContactModel(int.Parse(cellCollection[0].Value.ToString()),
                                                           (string)cellCollection[1].Value,
                                                            (string)cellCollection[2].Value,
                                                             (string)cellCollection[3].Value,
                                                              (string)cellCollection[4].Value);
                    contactsReq.DeleateReqest(model);
                    UpdateView();
                }
            }
            else
            {
                MessageBox.Show("Выберите только 1 запись и повторите попытку", "Оказия!");
            }
        }
    }
}
