
namespace orgainizer.Forms
{
    partial class HandBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KeyToFind = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.byMail = new System.Windows.Forms.RadioButton();
            this.bySurname = new System.Windows.Forms.RadioButton();
            this.byPhone = new System.Windows.Forms.RadioButton();
            this.byKey = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ContactsView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Initials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.DeleteButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ContactsView);
            this.splitContainer1.Size = new System.Drawing.Size(896, 450);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.KeyToFind);
            this.panel1.Controls.Add(this.findButton);
            this.panel1.Controls.Add(this.byMail);
            this.panel1.Controls.Add(this.bySurname);
            this.panel1.Controls.Add(this.byPhone);
            this.panel1.Controls.Add(this.byKey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 110);
            this.panel1.TabIndex = 1;
            // 
            // KeyToFind
            // 
            this.KeyToFind.Cursor = System.Windows.Forms.Cursors.Default;
            this.KeyToFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.KeyToFind.Location = new System.Drawing.Point(0, 63);
            this.KeyToFind.Name = "KeyToFind";
            this.KeyToFind.Size = new System.Drawing.Size(205, 20);
            this.KeyToFind.TabIndex = 6;
            // 
            // findButton
            // 
            this.findButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.findButton.Location = new System.Drawing.Point(0, 83);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(205, 23);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // byMail
            // 
            this.byMail.AutoSize = true;
            this.byMail.Location = new System.Drawing.Point(101, 39);
            this.byMail.Name = "byMail";
            this.byMail.Size = new System.Drawing.Size(70, 17);
            this.byMail.TabIndex = 4;
            this.byMail.TabStop = true;
            this.byMail.Text = "По почте";
            this.byMail.UseVisualStyleBackColor = true;
            // 
            // bySurname
            // 
            this.bySurname.AutoSize = true;
            this.bySurname.Location = new System.Drawing.Point(10, 39);
            this.bySurname.Name = "bySurname";
            this.bySurname.Size = new System.Drawing.Size(88, 17);
            this.bySurname.TabIndex = 3;
            this.bySurname.TabStop = true;
            this.bySurname.Text = "По фамилии";
            this.bySurname.UseVisualStyleBackColor = true;
            // 
            // byPhone
            // 
            this.byPhone.AutoSize = true;
            this.byPhone.Location = new System.Drawing.Point(101, 16);
            this.byPhone.Name = "byPhone";
            this.byPhone.Size = new System.Drawing.Size(90, 17);
            this.byPhone.TabIndex = 2;
            this.byPhone.TabStop = true;
            this.byPhone.Text = "По телефону";
            this.byPhone.UseVisualStyleBackColor = true;
            // 
            // byKey
            // 
            this.byKey.AutoSize = true;
            this.byKey.Location = new System.Drawing.Point(10, 16);
            this.byKey.Name = "byKey";
            this.byKey.Size = new System.Drawing.Size(72, 17);
            this.byKey.TabIndex = 1;
            this.byKey.TabStop = true;
            this.byKey.Text = "По ключу";
            this.byKey.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteButton.Location = new System.Drawing.Point(0, 70);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(209, 69);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(209, 70);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ContactsView
            // 
            this.ContactsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Phone,
            this.Surname,
            this.Initials,
            this.Email});
            this.ContactsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactsView.Location = new System.Drawing.Point(0, 0);
            this.ContactsView.Name = "ContactsView";
            this.ContactsView.Size = new System.Drawing.Size(683, 450);
            this.ContactsView.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "Ключ";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Номер Телефона";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 150;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 150;
            // 
            // Initials
            // 
            this.Initials.HeaderText = "Инициалы";
            this.Initials.Name = "Initials";
            this.Initials.ReadOnly = true;
            this.Initials.Width = 70;
            // 
            // Email
            // 
            this.Email.HeaderText = "Почта";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // HandBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HandBook";
            this.Text = "Контакты";
            this.Shown += new System.EventHandler(this.HandBook_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView ContactsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Initials;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.RadioButton byMail;
        private System.Windows.Forms.RadioButton bySurname;
        private System.Windows.Forms.RadioButton byPhone;
        private System.Windows.Forms.RadioButton byKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyToFind;
    }
}