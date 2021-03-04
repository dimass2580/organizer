
namespace orgainizer.Forms
{
    partial class UpdateEventDateForm
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
            this.findTime = new System.Windows.Forms.DateTimePicker();
            this.find2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.edit2 = new System.Windows.Forms.Button();
            this.setTime2 = new System.Windows.Forms.DateTimePicker();
            this.setTime1 = new System.Windows.Forms.DateTimePicker();
            this.edit1 = new System.Windows.Forms.Button();
            this.Find1 = new System.Windows.Forms.Button();
            this.textToFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EventView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventView1)).BeginInit();
            this.SuspendLayout();
            // 
            // findTime
            // 
            this.findTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.findTime.Location = new System.Drawing.Point(3, 6);
            this.findTime.Name = "findTime";
            this.findTime.Size = new System.Drawing.Size(777, 20);
            this.findTime.TabIndex = 1;
            // 
            // find2
            // 
            this.find2.Location = new System.Drawing.Point(2, 398);
            this.find2.Name = "find2";
            this.find2.Size = new System.Drawing.Size(249, 23);
            this.find2.TabIndex = 2;
            this.find2.Text = "Найти";
            this.find2.UseVisualStyleBackColor = true;
            this.find2.Click += new System.EventHandler(this.find2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 450);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EventView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.setTime1);
            this.tabPage1.Controls.Add(this.edit1);
            this.tabPage1.Controls.Add(this.Find1);
            this.tabPage1.Controls.Add(this.findTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поиск по дате";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EventView);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textToFind);
            this.tabPage2.Controls.Add(this.setTime2);
            this.tabPage2.Controls.Add(this.edit2);
            this.tabPage2.Controls.Add(this.find2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск по слову";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // edit2
            // 
            this.edit2.Location = new System.Drawing.Point(531, 398);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(249, 23);
            this.edit2.TabIndex = 3;
            this.edit2.Text = "Заменить";
            this.edit2.UseVisualStyleBackColor = true;
            this.edit2.Click += new System.EventHandler(this.edit2_Click);
            // 
            // setTime2
            // 
            this.setTime2.Location = new System.Drawing.Point(2, 372);
            this.setTime2.Name = "setTime2";
            this.setTime2.Size = new System.Drawing.Size(780, 20);
            this.setTime2.TabIndex = 4;
            // 
            // setTime1
            // 
            this.setTime1.Location = new System.Drawing.Point(3, 367);
            this.setTime1.Name = "setTime1";
            this.setTime1.Size = new System.Drawing.Size(777, 20);
            this.setTime1.TabIndex = 8;
            // 
            // edit1
            // 
            this.edit1.Location = new System.Drawing.Point(531, 393);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(249, 23);
            this.edit1.TabIndex = 7;
            this.edit1.Text = "Заменить";
            this.edit1.UseVisualStyleBackColor = true;
            this.edit1.Click += new System.EventHandler(this.edit1_Click);
            // 
            // Find1
            // 
            this.Find1.Location = new System.Drawing.Point(0, 393);
            this.Find1.Name = "Find1";
            this.Find1.Size = new System.Drawing.Size(249, 23);
            this.Find1.TabIndex = 6;
            this.Find1.Text = "Найти";
            this.Find1.UseVisualStyleBackColor = true;
            this.Find1.Click += new System.EventHandler(this.Find1_Click);
            // 
            // textToFind
            // 
            this.textToFind.Location = new System.Drawing.Point(3, 3);
            this.textToFind.Multiline = true;
            this.textToFind.Name = "textToFind";
            this.textToFind.Size = new System.Drawing.Size(777, 59);
            this.textToFind.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Заменить на";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Заменить на";
            // 
            // EventView
            // 
            this.EventView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.EventText});
            this.EventView.Location = new System.Drawing.Point(6, 65);
            this.EventView.Name = "EventView";
            this.EventView.Size = new System.Drawing.Size(774, 288);
            this.EventView.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.HeaderText = "Код";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 15;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 70;
            // 
            // EventText
            // 
            this.EventText.HeaderText = "Событие";
            this.EventText.Name = "EventText";
            this.EventText.Width = 1000;
            // 
            // EventView1
            // 
            this.EventView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.EventView1.Location = new System.Drawing.Point(3, 32);
            this.EventView1.Name = "EventView1";
            this.EventView1.Size = new System.Drawing.Size(777, 313);
            this.EventView1.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Событие";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 1000;
            // 
            // EditEventDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "EditEventDateForm";
            this.Text = "Смена Даты События";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker findTime;
        private System.Windows.Forms.Button find2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker setTime1;
        private System.Windows.Forms.Button edit1;
        private System.Windows.Forms.Button Find1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textToFind;
        private System.Windows.Forms.DateTimePicker setTime2;
        private System.Windows.Forms.Button edit2;
        private System.Windows.Forms.DataGridView EventView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView EventView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventText;
    }
}