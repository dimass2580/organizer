
namespace orgainizer.Forms
{
    partial class AddEventForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.EventText = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AppendButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DatePicker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EventText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.597702F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.59416F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.896552F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 377);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "HH:mm dd MM yyyy";
            this.DatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(3, 3);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(334, 20);
            this.DatePicker.TabIndex = 0;
            // 
            // EventText
            // 
            this.EventText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventText.Location = new System.Drawing.Point(3, 20);
            this.EventText.Name = "EventText";
            this.EventText.Size = new System.Drawing.Size(334, 327);
            this.EventText.TabIndex = 1;
            this.EventText.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 353);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ClearButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AppendButton);
            this.splitContainer1.Size = new System.Drawing.Size(334, 21);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 2;
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.Location = new System.Drawing.Point(0, 0);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(162, 21);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AppendButton
            // 
            this.AppendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AppendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppendButton.Location = new System.Drawing.Point(0, 0);
            this.AppendButton.Name = "AppendButton";
            this.AppendButton.Size = new System.Drawing.Size(168, 21);
            this.AppendButton.TabIndex = 0;
            this.AppendButton.Text = "Добавить";
            this.AppendButton.UseVisualStyleBackColor = true;
            this.AppendButton.Click += new System.EventHandler(this.AppendButton_Click);
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 377);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEventForm";
            this.ShowIcon = false;
            this.Text = "Добавить";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.RichTextBox EventText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AppendButton;
    }
}