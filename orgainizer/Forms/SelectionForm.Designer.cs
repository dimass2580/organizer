
namespace orgainizer.Forms
{
    partial class SelectionForm
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
            this.LayoutP = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.AddPercentsButton = new System.Windows.Forms.Button();
            this.PercentsEn = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.sortButton = new System.Windows.Forms.Button();
            this.SortTable = new System.Windows.Forms.ComboBox();
            this.SelectionDataView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startSelectionButton = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LayoutP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutP
            // 
            this.LayoutP.ColumnCount = 1;
            this.LayoutP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutP.Controls.Add(this.splitContainer3, 0, 2);
            this.LayoutP.Controls.Add(this.splitContainer2, 0, 1);
            this.LayoutP.Controls.Add(this.SelectionDataView, 0, 3);
            this.LayoutP.Controls.Add(this.splitContainer1, 0, 0);
            this.LayoutP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutP.Location = new System.Drawing.Point(0, 0);
            this.LayoutP.Name = "LayoutP";
            this.LayoutP.RowCount = 4;
            this.LayoutP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.349082F));
            this.LayoutP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.448819F));
            this.LayoutP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.398951F));
            this.LayoutP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.32809F));
            this.LayoutP.Size = new System.Drawing.Size(599, 381);
            this.LayoutP.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 65);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.AddPercentsButton);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.PercentsEn);
            this.splitContainer3.Size = new System.Drawing.Size(593, 25);
            this.splitContainer3.SplitterDistance = 197;
            this.splitContainer3.TabIndex = 3;
            // 
            // AddPercentsButton
            // 
            this.AddPercentsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPercentsButton.Location = new System.Drawing.Point(0, 0);
            this.AddPercentsButton.Name = "AddPercentsButton";
            this.AddPercentsButton.Size = new System.Drawing.Size(197, 25);
            this.AddPercentsButton.TabIndex = 0;
            this.AddPercentsButton.Text = "Увеличить строймость разговоров на %";
            this.AddPercentsButton.UseVisualStyleBackColor = true;
            this.AddPercentsButton.Click += new System.EventHandler(this.AddPercentsButton_Click);
            // 
            // PercentsEn
            // 
            this.PercentsEn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentsEn.FormattingEnabled = true;
            this.PercentsEn.Items.AddRange(new object[] {
            "5%",
            "10%",
            "15%",
            "20%"});
            this.PercentsEn.Location = new System.Drawing.Point(0, 0);
            this.PercentsEn.Name = "PercentsEn";
            this.PercentsEn.Size = new System.Drawing.Size(392, 21);
            this.PercentsEn.TabIndex = 1;
            this.PercentsEn.Text = "5%";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 30);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.sortButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.SortTable);
            this.splitContainer2.Size = new System.Drawing.Size(593, 29);
            this.splitContainer2.SplitterDistance = 195;
            this.splitContainer2.TabIndex = 2;
            // 
            // sortButton
            // 
            this.sortButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortButton.Location = new System.Drawing.Point(0, 0);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(195, 29);
            this.sortButton.TabIndex = 0;
            this.sortButton.Text = "Сортировать по столбцу";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // SortTable
            // 
            this.SortTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortTable.FormattingEnabled = true;
            this.SortTable.Items.AddRange(new object[] {
            "Стоймость разговора",
            "Дата разговора",
            "Фамилия Абонента"});
            this.SortTable.Location = new System.Drawing.Point(0, 0);
            this.SortTable.Name = "SortTable";
            this.SortTable.Size = new System.Drawing.Size(394, 21);
            this.SortTable.TabIndex = 0;
            this.SortTable.Text = "Стоймость разговора";
            // 
            // SelectionDataView
            // 
            this.SelectionDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectionDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.SelectionDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectionDataView.Location = new System.Drawing.Point(3, 96);
            this.SelectionDataView.Name = "SelectionDataView";
            this.SelectionDataView.Size = new System.Drawing.Size(593, 282);
            this.SelectionDataView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Стоймость разговора";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата разговора";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Фамилия Абонента";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.startDatePicker);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.startSelectionButton);
            this.splitContainer1.Panel2.Controls.Add(this.endDatePicker);
            this.splitContainer1.Size = new System.Drawing.Size(593, 21);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.TabIndex = 1;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDatePicker.Location = new System.Drawing.Point(0, 0);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(197, 20);
            this.startDatePicker.TabIndex = 2;
            this.startDatePicker.Value = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            // 
            // startSelectionButton
            // 
            this.startSelectionButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.startSelectionButton.Location = new System.Drawing.Point(234, 0);
            this.startSelectionButton.Name = "startSelectionButton";
            this.startSelectionButton.Size = new System.Drawing.Size(158, 21);
            this.startSelectionButton.TabIndex = 2;
            this.startSelectionButton.Text = "Сделать выборку";
            this.startSelectionButton.UseVisualStyleBackColor = true;
            this.startSelectionButton.Click += new System.EventHandler(this.startSelectionButton_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.endDatePicker.Location = new System.Drawing.Point(0, 0);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(228, 20);
            this.endDatePicker.TabIndex = 1;
            this.endDatePicker.Value = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 381);
            this.Controls.Add(this.LayoutP);
            this.Name = "SelectionForm";
            this.Text = "Сделать выборку";
            this.LayoutP.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectionDataView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutP;
        private System.Windows.Forms.DataGridView SelectionDataView;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button AddPercentsButton;
        private System.Windows.Forms.ComboBox PercentsEn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ComboBox SortTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button startSelectionButton;
    }
}