namespace FinanceTracker.UI.ReportInputPanel.View
{
    partial class PeriodTransactionInputControl
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
            label1 = new Label();
            label2 = new Label();
            buttonApplay = new Button();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonApplay, 2, 1);
            tableLayoutPanel1.Controls.Add(dtpStart, 0, 1);
            tableLayoutPanel1.Controls.Add(dtpEnd, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(288, 44);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Начало периода";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Коонец периода";
            // 
            // buttonApplay
            // 
            buttonApplay.Location = new Point(210, 18);
            buttonApplay.Name = "buttonApplay";
            buttonApplay.Size = new Size(75, 23);
            buttonApplay.TabIndex = 2;
            buttonApplay.Text = "Выполить";
            buttonApplay.UseVisualStyleBackColor = true;
            buttonApplay.Click += buttonApplay_Click;
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "dd.MM.yy";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(3, 18);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(98, 23);
            dtpStart.TabIndex = 3;
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "dd.MM.yy";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(107, 18);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(97, 23);
            dtpEnd.TabIndex = 4;
            // 
            // PeriodTransactionInputControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel1);
            Name = "PeriodTransactionInputControl";
            Size = new Size(288, 44);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button buttonApplay;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
    }
}
