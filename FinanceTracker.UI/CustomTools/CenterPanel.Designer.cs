namespace FinanceTracker.UI.CustomTools
{
    partial class CenterPanel
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
            tlpCenterPanel = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tlpCenterPanel
            // 
            tlpCenterPanel.AutoSize = true;
            tlpCenterPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpCenterPanel.ColumnCount = 3;
            tlpCenterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCenterPanel.ColumnStyles.Add(new ColumnStyle());
            tlpCenterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tlpCenterPanel.Dock = DockStyle.Fill;
            tlpCenterPanel.Location = new Point(0, 0);
            tlpCenterPanel.Margin = new Padding(0);
            tlpCenterPanel.Name = "tlpCenterPanel";
            tlpCenterPanel.RowCount = 3;
            tlpCenterPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpCenterPanel.RowStyles.Add(new RowStyle());
            tlpCenterPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tlpCenterPanel.Size = new Size(0, 0);
            tlpCenterPanel.TabIndex = 0;
            // 
            // CenterPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tlpCenterPanel);
            Margin = new Padding(0);
            Name = "CenterPanel";
            Size = new Size(0, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpCenterPanel;
    }
}
