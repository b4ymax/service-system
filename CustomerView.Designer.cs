﻿namespace code
{
    partial class CustomerView
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageCurrent = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnCurrentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCurrentServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCurrentServiceFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCurrentServiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageHistory = new System.Windows.Forms.TabPage();
            this.dbReport = new System.Windows.Forms.DataGridView();
            this.columnHistoryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHistoryServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHistoryServiceFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHistoryServiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.pageCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Silver;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(1630, 74);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(312, 70);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Silver;
            this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(1270, 74);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(312, 70);
            this.btnProfile.TabIndex = 18;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageCurrent);
            this.tabControl1.Controls.Add(this.pageHistory);
            this.tabControl1.Location = new System.Drawing.Point(28, 180);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1948, 828);
            this.tabControl1.TabIndex = 17;
            // 
            // pageCurrent
            // 
            this.pageCurrent.Controls.Add(this.dataGridView1);
            this.pageCurrent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageCurrent.Location = new System.Drawing.Point(12, 69);
            this.pageCurrent.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageCurrent.Name = "pageCurrent";
            this.pageCurrent.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageCurrent.Size = new System.Drawing.Size(1924, 747);
            this.pageCurrent.TabIndex = 0;
            this.pageCurrent.Text = "Current";
            this.pageCurrent.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCurrentDate,
            this.columnCurrentServiceType,
            this.columnCurrentServiceFee,
            this.columnCurrentServiceStatus});
            this.dataGridView1.Location = new System.Drawing.Point(62, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1808, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // columnCurrentDate
            // 
            this.columnCurrentDate.HeaderText = "Date";
            this.columnCurrentDate.MinimumWidth = 6;
            this.columnCurrentDate.Name = "columnCurrentDate";
            this.columnCurrentDate.Width = 150;
            // 
            // columnCurrentServiceType
            // 
            this.columnCurrentServiceType.HeaderText = "Service Type";
            this.columnCurrentServiceType.MinimumWidth = 6;
            this.columnCurrentServiceType.Name = "columnCurrentServiceType";
            this.columnCurrentServiceType.Width = 175;
            // 
            // columnCurrentServiceFee
            // 
            this.columnCurrentServiceFee.HeaderText = "Service Fee";
            this.columnCurrentServiceFee.MinimumWidth = 6;
            this.columnCurrentServiceFee.Name = "columnCurrentServiceFee";
            this.columnCurrentServiceFee.Width = 160;
            // 
            // columnCurrentServiceStatus
            // 
            this.columnCurrentServiceStatus.HeaderText = "Service Status";
            this.columnCurrentServiceStatus.MinimumWidth = 6;
            this.columnCurrentServiceStatus.Name = "columnCurrentServiceStatus";
            this.columnCurrentServiceStatus.Width = 185;
            // 
            // pageHistory
            // 
            this.pageHistory.Controls.Add(this.dbReport);
            this.pageHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageHistory.Location = new System.Drawing.Point(12, 69);
            this.pageHistory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageHistory.Name = "pageHistory";
            this.pageHistory.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageHistory.Size = new System.Drawing.Size(1924, 747);
            this.pageHistory.TabIndex = 1;
            this.pageHistory.Text = "History";
            this.pageHistory.UseVisualStyleBackColor = true;
            // 
            // dbReport
            // 
            this.dbReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnHistoryDate,
            this.columnHistoryServiceType,
            this.columnHistoryServiceFee,
            this.columnHistoryServiceStatus});
            this.dbReport.Location = new System.Drawing.Point(62, 149);
            this.dbReport.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dbReport.Name = "dbReport";
            this.dbReport.RowHeadersWidth = 51;
            this.dbReport.RowTemplate.Height = 29;
            this.dbReport.Size = new System.Drawing.Size(1808, 451);
            this.dbReport.TabIndex = 10;
            // 
            // columnHistoryDate
            // 
            this.columnHistoryDate.HeaderText = "Date";
            this.columnHistoryDate.MinimumWidth = 6;
            this.columnHistoryDate.Name = "columnHistoryDate";
            this.columnHistoryDate.Width = 150;
            // 
            // columnHistoryServiceType
            // 
            this.columnHistoryServiceType.HeaderText = "Service Type";
            this.columnHistoryServiceType.MinimumWidth = 6;
            this.columnHistoryServiceType.Name = "columnHistoryServiceType";
            this.columnHistoryServiceType.Width = 175;
            // 
            // columnHistoryServiceFee
            // 
            this.columnHistoryServiceFee.HeaderText = "Service Fee";
            this.columnHistoryServiceFee.MinimumWidth = 6;
            this.columnHistoryServiceFee.Name = "columnHistoryServiceFee";
            this.columnHistoryServiceFee.Width = 160;
            // 
            // columnHistoryServiceStatus
            // 
            this.columnHistoryServiceStatus.HeaderText = "Service Status";
            this.columnHistoryServiceStatus.MinimumWidth = 6;
            this.columnHistoryServiceStatus.Name = "columnHistoryServiceStatus";
            this.columnHistoryServiceStatus.Width = 185;
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGreeting.Location = new System.Drawing.Point(38, 74);
            this.lblGreeting.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(150, 64);
            this.lblGreeting.TabIndex = 16;
            this.lblGreeting.Text = "Hello";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 1080);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblGreeting);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.tabControl1.ResumeLayout(false);
            this.pageCurrent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pageHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogout;
        private Button btnProfile;
        private TabControl tabControl1;
        private TabPage pageCurrent;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn columnCurrentDate;
        private DataGridViewTextBoxColumn columnCurrentServiceType;
        private DataGridViewTextBoxColumn columnCurrentServiceFee;
        private DataGridViewTextBoxColumn columnCurrentServiceStatus;
        private TabPage pageHistory;
        private DataGridView dbReport;
        private DataGridViewTextBoxColumn columnHistoryDate;
        private DataGridViewTextBoxColumn columnHistoryServiceType;
        private DataGridViewTextBoxColumn columnHistoryServiceFee;
        private DataGridViewTextBoxColumn columnHistoryServiceStatus;
        private Label lblGreeting;
    }
}