﻿
namespace orgainizer.Forms
{
    partial class IntercityCallsForm
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
            this.components = new System.ComponentModel.Container();
            this.ControlsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DelButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FindResult = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxCost = new System.Windows.Forms.Label();
            this.SummOfCost = new System.Windows.Forms.Label();
            this.IntercityDataView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GetByDate = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateView = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlsLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntercityDataView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlsLayout
            // 
            this.ControlsLayout.ColumnCount = 1;
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ControlsLayout.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.ControlsLayout.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.ControlsLayout.Controls.Add(this.IntercityDataView, 0, 1);
            this.ControlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsLayout.Location = new System.Drawing.Point(0, 0);
            this.ControlsLayout.Name = "ControlsLayout";
            this.ControlsLayout.RowCount = 3;
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.10256F));
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.89744F));
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.ControlsLayout.Size = new System.Drawing.Size(809, 450);
            this.ControlsLayout.TabIndex = 1;
            this.ControlsLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.17061F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.41968F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.91034F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.DelButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ChangeButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(803, 49);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DelButton
            // 
            this.DelButton.BackgroundImage = global::orgainizer.Properties.Resources.del;
            this.DelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(345, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(186, 43);
            this.DelButton.TabIndex = 2;
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackgroundImage = global::orgainizer.Properties.Resources.DateChange;
            this.ChangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeButton.Location = new System.Drawing.Point(173, 3);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(166, 43);
            this.ChangeButton.TabIndex = 1;
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = global::orgainizer.Properties.Resources.insert;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(164, 43);
            this.AddButton.TabIndex = 0;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::orgainizer.Properties.Resources.search;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(537, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(263, 43);
            this.searchButton.TabIndex = 3;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.MaxCost, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.SummOfCost, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 394);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(803, 53);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FindResult);
            this.panel1.Controls.Add(this.Code);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(537, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 47);
            this.panel1.TabIndex = 0;
            // 
            // FindResult
            // 
            this.FindResult.AutoSize = true;
            this.FindResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindResult.Location = new System.Drawing.Point(0, 33);
            this.FindResult.Name = "FindResult";
            this.FindResult.Size = new System.Drawing.Size(13, 13);
            this.FindResult.TabIndex = 2;
            this.FindResult.Text = "0";
            // 
            // Code
            // 
            this.Code.Dock = System.Windows.Forms.DockStyle.Top;
            this.Code.Location = new System.Drawing.Point(0, 13);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(263, 20);
            this.Code.TabIndex = 1;
            this.Code.TextChanged += new System.EventHandler(this.Code_TextChanged);
            this.Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Code_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество разговоров по коду";
            // 
            // MaxCost
            // 
            this.MaxCost.AutoSize = true;
            this.MaxCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxCost.Location = new System.Drawing.Point(3, 0);
            this.MaxCost.Name = "MaxCost";
            this.MaxCost.Size = new System.Drawing.Size(261, 53);
            this.MaxCost.TabIndex = 1;
            this.MaxCost.Text = "Максимальная стоймость разговора:";
            // 
            // SummOfCost
            // 
            this.SummOfCost.AutoSize = true;
            this.SummOfCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummOfCost.Location = new System.Drawing.Point(270, 0);
            this.SummOfCost.Name = "SummOfCost";
            this.SummOfCost.Size = new System.Drawing.Size(261, 53);
            this.SummOfCost.TabIndex = 2;
            this.SummOfCost.Text = "Суммарная стоймость разговоров:";
            // 
            // IntercityDataView
            // 
            this.IntercityDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IntercityDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Surname,
            this.Phone,
            this.Date,
            this.CityCode,
            this.Duration,
            this.Cost});
            this.IntercityDataView.ContextMenuStrip = this.contextMenuStrip1;
            this.IntercityDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntercityDataView.Location = new System.Drawing.Point(3, 58);
            this.IntercityDataView.Name = "IntercityDataView";
            this.IntercityDataView.RowHeadersWidth = 51;
            this.IntercityDataView.Size = new System.Drawing.Size(803, 330);
            this.IntercityDataView.TabIndex = 2;
            this.IntercityDataView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.IntercityDataView_CellEndEdit);
            this.IntercityDataView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.IntercityDataView_CellLeave);
            this.IntercityDataView.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.IntercityDataView_CellParsing);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetByDate,
            this.UpdateView});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 48);
            // 
            // GetByDate
            // 
            this.GetByDate.Name = "GetByDate";
            this.GetByDate.Size = new System.Drawing.Size(212, 22);
            this.GetByDate.Text = "Сделать выборку по дате";
            // 
            // UpdateView
            // 
            this.UpdateView.Name = "UpdateView";
            this.UpdateView.Size = new System.Drawing.Size(212, 22);
            this.UpdateView.Text = "Обновить";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия Абонента";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Номер Телефона";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата разговора";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // CityCode
            // 
            this.CityCode.HeaderText = "Код Города";
            this.CityCode.MinimumWidth = 6;
            this.CityCode.Name = "CityCode";
            this.CityCode.Width = 125;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Длительность разговора";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.Width = 125;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоймость минуты разговора";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 125;
            // 
            // IntercityCallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.ControlsLayout);
            this.Name = "IntercityCallsForm";
            this.Text = "Междугородние звонки";
            this.Shown += new System.EventHandler(this.IntercityCallsForm_Shown);
            this.ControlsLayout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntercityDataView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ControlsLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label SummOfCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FindResult;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaxCost;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView IntercityDataView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GetByDate;
        private System.Windows.Forms.ToolStripMenuItem UpdateView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}