namespace FinanceTracker.UI.EditionPanel.View
{
    partial class TransactionEditorControl
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
            labelWarning = new Label();
            dtpDate = new DateTimePicker();
            buttonClose = new Button();
            buttonSave = new Button();
            label4 = new Label();
            label3 = new Label();
            cbCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            buttonType = new Button();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            nbcAmount = new CustomTools.NumberBoxCustom();
            cbAccount = new ComboBox();
            tbDescription = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(labelWarning, 0, 12);
            tableLayoutPanel1.Controls.Add(dtpDate, 0, 9);
            tableLayoutPanel1.Controls.Add(buttonClose, 0, 14);
            tableLayoutPanel1.Controls.Add(buttonSave, 0, 13);
            tableLayoutPanel1.Controls.Add(label4, 0, 10);
            tableLayoutPanel1.Controls.Add(label3, 0, 8);
            tableLayoutPanel1.Controls.Add(cbCategory, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonType, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(cbAccount, 0, 6);
            tableLayoutPanel1.Controls.Add(tbDescription, 0, 11);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 15;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(289, 355);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.Dock = DockStyle.Fill;
            labelWarning.ForeColor = Color.Red;
            labelWarning.Location = new Point(3, 278);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(283, 15);
            labelWarning.TabIndex = 11;
            labelWarning.Text = "Предупреждение";
            labelWarning.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd.MM.yy";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(3, 187);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(94, 23);
            dtpDate.TabIndex = 3;
            // 
            // buttonClose
            // 
            buttonClose.AutoSize = true;
            buttonClose.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonClose.Location = new Point(3, 327);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(59, 25);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Отмена";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonSave
            // 
            buttonSave.AutoSize = true;
            buttonSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSave.Location = new Point(3, 296);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 25);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 213);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 8;
            label4.Text = "Описание";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 169);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 5;
            label3.Text = "Дата";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 92);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(283, 23);
            cbCategory.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Категория";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 30);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Сумма";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonType
            // 
            buttonType.Image = Resources.plus_16;
            buttonType.Location = new Point(3, 3);
            buttonType.Name = "buttonType";
            buttonType.Size = new Size(70, 24);
            buttonType.TabIndex = 0;
            buttonType.Text = "Доход";
            buttonType.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonType.UseVisualStyleBackColor = true;
            buttonType.Click += buttonType_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 118);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Счет";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(label6, 1, 0);
            tableLayoutPanel2.Controls.Add(nbcAmount, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 45);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(167, 29);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(145, 0);
            label6.Name = "label6";
            label6.Size = new Size(19, 29);
            label6.TabIndex = 2;
            label6.Text = "₽";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nbcAmount
            // 
            nbcAmount.AllowNegativeNumber = false;
            nbcAmount.Location = new Point(3, 3);
            nbcAmount.Name = "nbcAmount";
            nbcAmount.Size = new Size(136, 23);
            nbcAmount.TabIndex = 0;
            nbcAmount.TypeName = "System.Decimal";
            // 
            // cbAccount
            // 
            cbAccount.FormattingEnabled = true;
            cbAccount.Location = new Point(3, 143);
            cbAccount.Name = "cbAccount";
            cbAccount.Size = new Size(283, 23);
            cbAccount.TabIndex = 5;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(3, 231);
            tbDescription.MaxLength = 100;
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(283, 44);
            tbDescription.TabIndex = 4;
            // 
            // TransactionEditorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel1);
            Name = "TransactionEditorControl";
            Size = new Size(289, 355);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dtpDate;
        private Label label4;
        private Label label3;
        private ComboBox cbCategory;
        private Label label2;
        private Label label1;
        private Button buttonType;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label6;
        private CustomTools.NumberBoxCustom nbcAmount;
        private ComboBox cbAccount;
        private TextBox tbDescription;
        private Button buttonSave;
        private Button buttonClose;
        private Label labelWarning;
    }
}
