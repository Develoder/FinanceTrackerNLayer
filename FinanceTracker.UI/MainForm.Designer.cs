namespace FinanceTracker.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPrimaryControl = new Panel();
            SuspendLayout();
            // 
            // panelPrimaryControl
            // 
            panelPrimaryControl.Dock = DockStyle.Fill;
            panelPrimaryControl.Location = new Point(0, 0);
            panelPrimaryControl.Margin = new Padding(0);
            panelPrimaryControl.Name = "panelPrimaryControl";
            panelPrimaryControl.Size = new Size(1117, 733);
            panelPrimaryControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 733);
            Controls.Add(panelPrimaryControl);
            Name = "MainForm";
            Text = "Finance Tracker - ваш личный учет финансов";
            ResumeLayout(false);
        }

        #endregion
        private FinanceTracker.UI.CustomTools.CollapsePanel collapsePanel1;
        private FinanceTracker.UI.CustomTools.CollapsePanel collapsePanel2;
        private Panel panelPrimaryControl;
    }
}