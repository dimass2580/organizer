
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DelButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FindResult = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxCoast = new System.Windows.Forms.Label();
            this.SummOfCost = new System.Windows.Forms.Label();
            this.IntercityDataView = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GetByDate = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateView = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntercityDataView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IntercityDataView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.10256F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.89744F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(865, 554);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.DelButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ChangeButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(857, 60);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DelButton
            // 
            this.DelButton.BackgroundImage = global::orgainizer.Properties.Resources.del;
            this.DelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(574, 4);
            this.DelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(279, 52);
            this.DelButton.TabIndex = 2;
            this.DelButton.UseVisualStyleBackColor = true;
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackgroundImage = global::orgainizer.Properties.Resources.DateChange;
            this.ChangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeButton.Location = new System.Drawing.Point(289, 4);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(277, 52);
            this.ChangeButton.TabIndex = 1;
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = global::orgainizer.Properties.Resources.insert;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(4, 4);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(277, 52);
            this.AddButton.TabIndex = 0;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.MaxCoast, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.SummOfCost, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 486);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(857, 64);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FindResult);
            this.panel1.Controls.Add(this.Code);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(574, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 56);
            this.panel1.TabIndex = 0;
            // 
            // FindResult
            // 
            this.FindResult.AutoSize = true;
            this.FindResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindResult.Location = new System.Drawing.Point(0, 39);
            this.FindResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FindResult.Name = "FindResult";
            this.FindResult.Size = new System.Drawing.Size(16, 17);
            this.FindResult.TabIndex = 2;
            this.FindResult.Text = "0";
            // 
            // Code
            // 
            this.Code.Dock = System.Windows.Forms.DockStyle.Top;
            this.Code.Location = new System.Drawing.Point(0, 17);
            this.Code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(279, 22);
            this.Code.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество разговоров по коду";
            // 
            // MaxCoast
            // 
            this.MaxCoast.AutoSize = true;
            this.MaxCoast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxCoast.Location = new System.Drawing.Point(4, 0);
            this.MaxCoast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxCoast.Name = "MaxCoast";
            this.MaxCoast.Size = new System.Drawing.Size(277, 64);
            this.MaxCoast.TabIndex = 1;
            this.MaxCoast.Text = "Максимальная стоймость разговора:";
            // 
            // SummOfCost
            // 
            this.SummOfCost.AutoSize = true;
            this.SummOfCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SummOfCost.Location = new System.Drawing.Point(289, 0);
            this.SummOfCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SummOfCost.Name = "SummOfCost";
            this.SummOfCost.Size = new System.Drawing.Size(277, 64);
            this.SummOfCost.TabIndex = 2;
            this.SummOfCost.Text = "Суммарная стоймость разговоров:";
            // 
            // IntercityDataView
            // 
            this.IntercityDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IntercityDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.Phone,
            this.Date,
            this.CityCode,
            this.Duration,
            this.Cost});
            this.IntercityDataView.ContextMenuStrip = this.contextMenuStrip1;
            this.IntercityDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntercityDataView.Location = new System.Drawing.Point(4, 72);
            this.IntercityDataView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IntercityDataView.Name = "IntercityDataView";
            this.IntercityDataView.RowHeadersWidth = 51;
            this.IntercityDataView.Size = new System.Drawing.Size(857, 406);
            this.IntercityDataView.TabIndex = 2;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetByDate,
            this.UpdateView});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 52);
            // 
            // GetByDate
            // 
            this.GetByDate.Name = "GetByDate";
            this.GetByDate.Size = new System.Drawing.Size(253, 24);
            this.GetByDate.Text = "Сделать выборку по дате";
            // 
            // UpdateView
            // 
            this.UpdateView.Name = "UpdateView";
            this.UpdateView.Size = new System.Drawing.Size(253, 24);
            this.UpdateView.Text = "Обновить";
            // 
            // IntercityCallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IntercityCallsForm";
            this.Text = "IntercityCallsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label SummOfCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FindResult;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaxCoast;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView IntercityDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GetByDate;
        private System.Windows.Forms.ToolStripMenuItem UpdateView;
    }
}