namespace FinanceTracker.UI.WindowPanel.View.MainMenuComponent
{
    partial class NavigationMenuControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonHome = new Button();
            cpReport = new CustomTools.CollapsePanel();
            buttonReport = new Button();
            buttonReportTransaction = new Button();
            buttonReportCategory = new Button();
            buttonTransaction = new Button();
            buttonProfile = new Button();
            buttonAccount = new Button();
            tableLayoutPanel1.SuspendLayout();
            cpReport.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(buttonHome, 0, 0);
            tableLayoutPanel1.Controls.Add(cpReport, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonTransaction, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonProfile, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonAccount, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(200, 231);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = SystemColors.ControlLight;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Image = Resources.home;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(0, 0);
            buttonHome.Margin = new Padding(0);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(200, 33);
            buttonHome.TabIndex = 15;
            buttonHome.Text = "   Глваная";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // cpReport
            // 
            cpReport.Controls.Add(buttonReport);
            cpReport.Controls.Add(buttonReportTransaction);
            cpReport.Controls.Add(buttonReportCategory);
            cpReport.FlowDirection = FlowDirection.TopDown;
            cpReport.Location = new Point(0, 99);
            cpReport.Margin = new Padding(0);
            cpReport.Name = "cpReport";
            cpReport.Size = new Size(200, 99);
            cpReport.TabIndex = 13;
            cpReport.TimeCollapse = 100;
            // 
            // buttonReport
            // 
            buttonReport.BackColor = SystemColors.ControlLight;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.Image = Resources.reports;
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(0, 0);
            buttonReport.Margin = new Padding(0);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(200, 33);
            buttonReport.TabIndex = 8;
            buttonReport.Text = "   Отчеты";
            buttonReport.TextAlign = ContentAlignment.MiddleLeft;
            buttonReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonReportTransaction
            // 
            buttonReportTransaction.FlatAppearance.BorderSize = 0;
            buttonReportTransaction.FlatStyle = FlatStyle.Flat;
            buttonReportTransaction.Image = Resources.degree;
            buttonReportTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReportTransaction.Location = new Point(0, 33);
            buttonReportTransaction.Margin = new Padding(0);
            buttonReportTransaction.Name = "buttonReportTransaction";
            buttonReportTransaction.Size = new Size(200, 33);
            buttonReportTransaction.TabIndex = 11;
            buttonReportTransaction.Text = "   Транзакции";
            buttonReportTransaction.TextAlign = ContentAlignment.MiddleLeft;
            buttonReportTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReportTransaction.UseVisualStyleBackColor = true;
            buttonReportTransaction.Click += buttonReportTransaction_Click;
            // 
            // buttonReportCategory
            // 
            buttonReportCategory.FlatAppearance.BorderSize = 0;
            buttonReportCategory.FlatStyle = FlatStyle.Flat;
            buttonReportCategory.Image = Resources.degree;
            buttonReportCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReportCategory.Location = new Point(0, 66);
            buttonReportCategory.Margin = new Padding(0);
            buttonReportCategory.Name = "buttonReportCategory";
            buttonReportCategory.Size = new Size(200, 33);
            buttonReportCategory.TabIndex = 10;
            buttonReportCategory.Text = "   Категории";
            buttonReportCategory.TextAlign = ContentAlignment.MiddleLeft;
            buttonReportCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReportCategory.UseVisualStyleBackColor = true;
            buttonReportCategory.Click += buttonReportCategory_Click;
            // 
            // buttonTransaction
            // 
            buttonTransaction.BackColor = SystemColors.ControlLight;
            buttonTransaction.FlatAppearance.BorderSize = 0;
            buttonTransaction.FlatStyle = FlatStyle.Flat;
            buttonTransaction.Image = Resources.transaction;
            buttonTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTransaction.Location = new Point(0, 66);
            buttonTransaction.Margin = new Padding(0);
            buttonTransaction.Name = "buttonTransaction";
            buttonTransaction.Size = new Size(200, 33);
            buttonTransaction.TabIndex = 3;
            buttonTransaction.Text = "   Транзакции";
            buttonTransaction.TextAlign = ContentAlignment.MiddleLeft;
            buttonTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTransaction.UseVisualStyleBackColor = false;
            buttonTransaction.Click += buttonTransaction_Click;
            // 
            // buttonProfile
            // 
            buttonProfile.BackColor = SystemColors.ControlLight;
            buttonProfile.FlatAppearance.BorderSize = 0;
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.Image = Resources.user_24;
            buttonProfile.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProfile.Location = new Point(0, 198);
            buttonProfile.Margin = new Padding(0);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(200, 33);
            buttonProfile.TabIndex = 1;
            buttonProfile.Text = "   Профиль";
            buttonProfile.TextAlign = ContentAlignment.MiddleLeft;
            buttonProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += buttonProfile_Click;
            // 
            // buttonAccount
            // 
            buttonAccount.BackColor = SystemColors.ControlLight;
            buttonAccount.FlatAppearance.BorderSize = 0;
            buttonAccount.FlatStyle = FlatStyle.Flat;
            buttonAccount.Image = Resources.account;
            buttonAccount.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAccount.Location = new Point(0, 33);
            buttonAccount.Margin = new Padding(0);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(200, 33);
            buttonAccount.TabIndex = 2;
            buttonAccount.Text = "   Счета";
            buttonAccount.TextAlign = ContentAlignment.MiddleLeft;
            buttonAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAccount.UseVisualStyleBackColor = false;
            buttonAccount.Click += buttonAccount_Click;
            // 
            // NavigationMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel1);
            Name = "NavigationMenuControl";
            Size = new Size(200, 231);
            tableLayoutPanel1.ResumeLayout(false);
            cpReport.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonHome;
        private CustomTools.CollapsePanel cpReport;
        private Button buttonReport;
        private Button buttonReportTransaction;
        private Button buttonReportCategory;
        private Button buttonTransaction;
        private Button buttonProfile;
        private Button buttonAccount;
    }
}
