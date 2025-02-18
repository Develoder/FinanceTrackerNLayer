namespace FinanceTracker.UI.WindowPanel.View
{
    partial class MainMenuControl
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
            cpMenu = new CustomTools.CollapsePanel();
            nmcNavigationMenu = new MainMenuComponent.NavigationMenuControl();
            buttonMenu = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panelContent = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            imcInformation = new MainMenuComponent.InformationMenuControl();
            tableLayoutPanel4 = new TableLayoutPanel();
            hmcHeader = new MainMenuComponent.HeaderMenuControl();
            cpMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // cpMenu
            // 
            cpMenu.Controls.Add(nmcNavigationMenu);
            cpMenu.Direction = CustomTools.CollapsePanel.TypeDirection.Horizontal;
            cpMenu.Dock = DockStyle.Left;
            cpMenu.FlowDirection = FlowDirection.TopDown;
            cpMenu.HorizontalMinSize = 34;
            cpMenu.InitialView = CustomTools.CollapsePanel.StateCollapse.Expanded;
            cpMenu.Location = new Point(0, 0);
            cpMenu.Margin = new Padding(0);
            cpMenu.Name = "cpMenu";
            cpMenu.Size = new Size(200, 699);
            cpMenu.TabIndex = 13;
            cpMenu.TimeCollapse = 100;
            // 
            // nmcNavigationMenu
            // 
            nmcNavigationMenu.AutoSize = true;
            nmcNavigationMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nmcNavigationMenu.Location = new Point(0, 0);
            nmcNavigationMenu.Margin = new Padding(0);
            nmcNavigationMenu.Name = "nmcNavigationMenu";
            nmcNavigationMenu.Size = new Size(200, 231);
            nmcNavigationMenu.TabIndex = 0;
            nmcNavigationMenu.OpenHomePage += nmcNavigationMenu_OpenHomePage;
            nmcNavigationMenu.OpenProfilePage += nmcNavigationMenu_OpenProfilePage;
            nmcNavigationMenu.OpenAccountPage += nmcNavigationMenu_OpenAccountPage;
            nmcNavigationMenu.OpenTransactionPage += nmcNavigationMenu_OpenTransactionPage;
            nmcNavigationMenu.OpenReportTransactionPage += nmcNavigationMenu_OpenReportTransactionPage;
            nmcNavigationMenu.OpenReportCategoryPage += nmcNavigationMenu_OpenReportCategoryPage;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = SystemColors.Control;
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Image = Resources.Menu;
            buttonMenu.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMenu.Location = new Point(0, 0);
            buttonMenu.Margin = new Padding(0);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(34, 33);
            buttonMenu.TabIndex = 0;
            buttonMenu.TextAlign = ContentAlignment.MiddleLeft;
            buttonMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1117, 733);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(cpMenu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 34);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 699);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panelContent, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(200, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(917, 699);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 33);
            panelContent.Margin = new Padding(0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(917, 666);
            panelContent.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(buttonMenu, 0, 0);
            tableLayoutPanel2.Controls.Add(imcInformation, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1117, 34);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // imcInformation
            // 
            imcInformation.AutoSize = true;
            imcInformation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            imcInformation.Location = new Point(884, 3);
            imcInformation.Name = "imcInformation";
            imcInformation.Size = new Size(230, 28);
            imcInformation.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(hmcHeader, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(917, 33);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // hmcHeader
            // 
            hmcHeader.AutoSize = true;
            hmcHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hmcHeader.Dock = DockStyle.Fill;
            hmcHeader.Location = new Point(458, 3);
            hmcHeader.Name = "hmcHeader";
            hmcHeader.Size = new Size(1, 27);
            hmcHeader.TabIndex = 16;
            // 
            // MainMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "MainMenuControl";
            Size = new Size(1117, 733);
            Load += MainPrimaryControl_Load;
            cpMenu.ResumeLayout(false);
            cpMenu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomTools.CollapsePanel cpMenu;
        private Button buttonMenu;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private MainMenuComponent.NavigationMenuControl nmcNavigationMenu;
        private MainMenuComponent.InformationMenuControl imcInformation;
        private Panel panelContent;
        private TableLayoutPanel tableLayoutPanel4;
        private MainMenuComponent.HeaderMenuControl hmcHeader;
    }
}
