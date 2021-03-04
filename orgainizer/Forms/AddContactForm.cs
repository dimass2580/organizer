using orgainizer.Data;
using orgainizer.Data.Add;
using orgainizer.DataModels;
using System;
using System.Windows.Forms;

namespace orgainizer.Forms
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Phone.Text = "";
            Email.Text = "";
            Surname.Text = "";
            NameText.Text = "";
        }

        HandBook handBookForm = (HandBook)Application.OpenForms["HandBook"];

        private void Add_Click(object sender, EventArgs e)
        {
            ContactModel contact;
            if (Phone.Text != " " &&
                 Surname.Text != "" &&
                   NameText.Text != "")
            {
                contact = new ContactModel(Phone.Text, Surname.Text, NameText.Text);

                if (Email.Text != "")
                    contact = new ContactModel(Phone.Text, Surname.Text, NameText.Text, Email.Text);

                Reqester req = new Reqester(new AddContact());
                req.AddReqest(contact);

            }
            else MessageBox.Show("Не заполнены поля номер, фамилия или имя!", "Оказия!");

            if (handBookForm != null)
                handBookForm.UpdateView();
        }
    }
}
