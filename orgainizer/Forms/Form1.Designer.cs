
namespace orgainizer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Append = new System.Windows.Forms.Button();
            this.Deleate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EventView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.звонкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowIntercity = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.событияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TodayEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.AllEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.записнаяКнигаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HandBook_View = new System.Windows.Forms.ToolStripMenuItem();
            this.taskNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.LayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.ColumnCount = 1;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.LayoutPanel.Controls.Add(this.label1, 0, 0);
            this.LayoutPanel.Controls.Add(this.EventView, 0, 2);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 3;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.929577F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.03286F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.2723F));
            this.LayoutPanel.Size = new System.Drawing.Size(396, 426);
            this.LayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.RefreshButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Append, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Deleate, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(390, 40);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::orgainizer.Properties.Resources.DateChange;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshButton.Location = new System.Drawing.Point(263, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(124, 34);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Append
            // 
            this.Append.BackgroundImage = global::orgainizer.Properties.Resources.insert;
            this.Append.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Append.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Append.Location = new System.Drawing.Point(3, 3);
            this.Append.Name = "Append";
            this.Append.Size = new System.Drawing.Size(124, 34);
            this.Append.TabIndex = 0;
            this.Append.UseVisualStyleBackColor = true;
            this.Append.Click += new System.EventHandler(this.Append_Click);
            // 
            // Deleate
            // 
            this.Deleate.BackgroundImage = global::orgainizer.Properties.Resources.del;
            this.Deleate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deleate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Deleate.Location = new System.Drawing.Point(133, 3);
            this.Deleate.Name = "Deleate";
            this.Deleate.Size = new System.Drawing.Size(124, 34);
            this.Deleate.TabIndex = 1;
            this.Deleate.UseVisualStyleBackColor = true;
            this.Deleate.Click += new System.EventHandler(this.Deleate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "События";
            // 
            // EventView
            // 
            this.EventView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.EventText});
            this.EventView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventView.Location = new System.Drawing.Point(3, 69);
            this.EventView.Name = "EventView";
            this.EventView.Size = new System.Drawing.Size(390, 354);
            this.EventView.TabIndex = 3;
            this.EventView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventView_CellEndEdit);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.звонкиToolStripMenuItem,
            this.задачиToolStripMenuItem,
            this.событияToolStripMenuItem,
            this.записнаяКнигаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // звонкиToolStripMenuItem
            // 
            this.звонкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowIntercity});
            this.звонкиToolStripMenuItem.Name = "звонкиToolStripMenuItem";
            this.звонкиToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.звонкиToolStripMenuItem.Text = "Междугородние звонки";
            // 
            // ShowIntercity
            // 
            this.ShowIntercity.Name = "ShowIntercity";
            this.ShowIntercity.Size = new System.Drawing.Size(180, 22);
            this.ShowIntercity.Text = "Просмотр";
            this.ShowIntercity.Click += new System.EventHandler(this.ShowIntercity_Click);
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowTasks});
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.задачиToolStripMenuItem.Text = "Задачи";
            // 
            // ShowTasks
            // 
            this.ShowTasks.Name = "ShowTasks";
            this.ShowTasks.Size = new System.Drawing.Size(180, 22);
            this.ShowTasks.Text = "Просмотр";
            this.ShowTasks.Click += new System.EventHandler(this.ShowTasks_Click);
            // 
            // событияToolStripMenuItem
            // 
            this.событияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TodayEvents,
            this.AllEvents});
            this.событияToolStripMenuItem.Name = "событияToolStripMenuItem";
            this.событияToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.событияToolStripMenuItem.Text = "События";
            // 
            // TodayEvents
            // 
            this.TodayEvents.Name = "TodayEvents";
            this.TodayEvents.Size = new System.Drawing.Size(180, 22);
            this.TodayEvents.Text = "Сегодня";
            this.TodayEvents.Click += new System.EventHandler(this.сегодняToolStripMenuItem_Click);
            // 
            // AllEvents
            // 
            this.AllEvents.Name = "AllEvents";
            this.AllEvents.Size = new System.Drawing.Size(180, 22);
            this.AllEvents.Text = "Все";
            this.AllEvents.Click += new System.EventHandler(this.всеToolStripMenuItem_Click);
            // 
            // записнаяКнигаToolStripMenuItem
            // 
            this.записнаяКнигаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HandBook_View});
            this.записнаяКнигаToolStripMenuItem.Name = "записнаяКнигаToolStripMenuItem";
            this.записнаяКнигаToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.записнаяКнигаToolStripMenuItem.Text = "Записная Книга";
            // 
            // HandBook_View
            // 
            this.HandBook_View.Name = "HandBook_View";
            this.HandBook_View.Size = new System.Drawing.Size(180, 22);
            this.HandBook_View.Text = "Просмотр";
            this.HandBook_View.Click += new System.EventHandler(this.HandBook_View_Click);
            // 
            // taskNotify
            // 
            this.taskNotify.Text = "notifyIcon1";
            this.taskNotify.Visible = true;
            this.taskNotify.BalloonTipClosed += new System.EventHandler(this.taskNotify_BalloonTipClosed);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Органайзер";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.LayoutPanel.ResumeLayout(false);
            this.LayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem звонкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowIntercity;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowTasks;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button Deleate;
        private System.Windows.Forms.Button Append;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EventView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventText;
        private System.Windows.Forms.ToolStripMenuItem событияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TodayEvents;
        private System.Windows.Forms.ToolStripMenuItem AllEvents;
        private System.Windows.Forms.NotifyIcon taskNotify;
        private System.Windows.Forms.ToolStripMenuItem записнаяКнигаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HandBook_View;
    }
}

