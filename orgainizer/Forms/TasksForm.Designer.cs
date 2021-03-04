
namespace orgainizer.Forms
{
    partial class TasksForm
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
            this.TLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TasksView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ended = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.TLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksView)).BeginInit();
            this.SuspendLayout();
            // 
            // TLayout
            // 
            this.TLayout.ColumnCount = 1;
            this.TLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLayout.Controls.Add(this.TasksView, 0, 1);
            this.TLayout.Controls.Add(this.AddTaskButton, 0, 0);
            this.TLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLayout.Location = new System.Drawing.Point(0, 0);
            this.TLayout.Name = "TLayout";
            this.TLayout.RowCount = 2;
            this.TLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.111111F));
            this.TLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.88889F));
            this.TLayout.Size = new System.Drawing.Size(800, 450);
            this.TLayout.TabIndex = 0;
            // 
            // TasksView
            // 
            this.TasksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TaskText,
            this.EndDate,
            this.Preority,
            this.Ended});
            this.TasksView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksView.Location = new System.Drawing.Point(3, 34);
            this.TasksView.Name = "TasksView";
            this.TasksView.Size = new System.Drawing.Size(794, 413);
            this.TasksView.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "Код";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TaskText
            // 
            this.TaskText.HeaderText = "Задача";
            this.TaskText.Name = "TaskText";
            this.TaskText.ReadOnly = true;
            this.TaskText.Width = 400;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Дата окончания";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // Preority
            // 
            this.Preority.HeaderText = "Преоритет";
            this.Preority.Name = "Preority";
            this.Preority.ReadOnly = true;
            this.Preority.Width = 80;
            // 
            // Ended
            // 
            this.Ended.HeaderText = "Завершена";
            this.Ended.Name = "Ended";
            this.Ended.Width = 70;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(3, 3);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(244, 23);
            this.AddTaskButton.TabIndex = 1;
            this.AddTaskButton.Text = "Добавить новую задачу";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TLayout);
            this.Name = "TasksForm";
            this.Text = "Задачи";
            this.Shown += new System.EventHandler(this.TasksForm_Shown);
            this.TLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TasksView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLayout;
        private System.Windows.Forms.DataGridView TasksView;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskText;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preority;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ended;
    }
}