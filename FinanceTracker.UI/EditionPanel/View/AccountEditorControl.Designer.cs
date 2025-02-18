namespace FinanceTracker.UI.EditionPanel.View
{
    partial class AccountEditorControl
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
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonClose = new Button();
            buttonSave = new Button();
            label5 = new Label();
            cbTypeAccount = new ComboBox();
            tbName = new TextBox();
            label4 = new Label();
            labelWarning = new Label();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(buttonClose, 0, 7);
            tableLayoutPanel2.Controls.Add(buttonSave, 0, 6);
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(cbTypeAccount, 0, 1);
            tableLayoutPanel2.Controls.Add(tbName, 0, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(labelWarning, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(239, 185);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonClose
            // 
            buttonClose.AutoSize = true;
            buttonClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonClose.Location = new Point(3, 157);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(71, 25);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Отменить";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonSave
            // 
            buttonSave.AutoSize = true;
            buttonSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSave.Location = new Point(3, 126);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 25);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 9;
            label5.Text = "Тип счета";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbTypeAccount
            // 
            cbTypeAccount.FormattingEnabled = true;
            cbTypeAccount.Location = new Point(3, 18);
            cbTypeAccount.Name = "cbTypeAccount";
            cbTypeAccount.Size = new Size(159, 23);
            cbTypeAccount.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.Location = new Point(3, 62);
            tbName.MaxLength = 20;
            tbName.Name = "tbName";
            tbName.Size = new Size(233, 23);
            tbName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 44);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 8;
            label4.Text = "Название";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.Dock = DockStyle.Fill;
            labelWarning.ForeColor = Color.Red;
            labelWarning.Location = new Point(3, 88);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(233, 15);
            labelWarning.TabIndex = 10;
            labelWarning.Text = "Предупреждение";
            labelWarning.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AccountEditorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel2);
            Name = "AccountEditorControl";
            Size = new Size(239, 185);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonClose;
        private Button buttonSave;
        private Label label5;
        private ComboBox cbTypeAccount;
        private TextBox tbName;
        private Label label4;
        private Label labelWarning;
    }
}
