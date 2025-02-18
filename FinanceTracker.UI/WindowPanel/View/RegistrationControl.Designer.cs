namespace FinanceTracker.UI.WindowPanel.View
{
    partial class RegistrationControl
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
            llLogin = new LinkLabel();
            tbPassword = new TextBox();
            label2 = new Label();
            buttonRegistered = new Button();
            label3 = new Label();
            tbLogin = new TextBox();
            tbRepeatPassword = new TextBox();
            label4 = new Label();
            labelWarningLogin = new Label();
            labelWarningPassword = new Label();
            labelWarningRepeatPassword = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 1, 3);
            tableLayoutPanel1.Controls.Add(llLogin, 1, 13);
            tableLayoutPanel1.Controls.Add(tbPassword, 1, 7);
            tableLayoutPanel1.Controls.Add(label2, 1, 6);
            tableLayoutPanel1.Controls.Add(buttonRegistered, 1, 12);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(tbLogin, 1, 4);
            tableLayoutPanel1.Controls.Add(tbRepeatPassword, 1, 10);
            tableLayoutPanel1.Controls.Add(label4, 1, 9);
            tableLayoutPanel1.Controls.Add(labelWarningLogin, 2, 4);
            tableLayoutPanel1.Controls.Add(labelWarningPassword, 2, 7);
            tableLayoutPanel1.Controls.Add(labelWarningRepeatPassword, 2, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 15;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1117, 733);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 267);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // llLogin
            // 
            llLogin.AutoSize = true;
            llLogin.Dock = DockStyle.Fill;
            llLogin.Location = new Point(464, 496);
            llLogin.Name = "llLogin";
            llLogin.Size = new Size(188, 15);
            llLogin.TabIndex = 3;
            llLogin.TabStop = true;
            llLogin.Text = "Уже зарегистрированы? Войдите";
            llLogin.TextAlign = ContentAlignment.MiddleCenter;
            llLogin.LinkClicked += llLogin_LinkClicked;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(464, 349);
            tbPassword.MaxLength = 20;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(188, 23);
            tbPassword.TabIndex = 1;
            tbPassword.TextChanged += tpPassword_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 331);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // buttonRegistered
            // 
            buttonRegistered.Location = new Point(464, 462);
            buttonRegistered.Name = "buttonRegistered";
            buttonRegistered.Size = new Size(188, 31);
            buttonRegistered.TabIndex = 3;
            buttonRegistered.Text = "Зарегистрироваться";
            buttonRegistered.UseVisualStyleBackColor = true;
            buttonRegistered.Click += buttonRegistered_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(464, 222);
            label3.Name = "label3";
            label3.Size = new Size(188, 25);
            label3.TabIndex = 5;
            label3.Text = "Регистрация";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(464, 285);
            tbLogin.MaxLength = 20;
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(188, 23);
            tbLogin.TabIndex = 0;
            tbLogin.Leave += tbLogin_Leave;
            // 
            // tbRepeatPassword
            // 
            tbRepeatPassword.Location = new Point(464, 413);
            tbRepeatPassword.MaxLength = 20;
            tbRepeatPassword.Name = "tbRepeatPassword";
            tbRepeatPassword.PasswordChar = '*';
            tbRepeatPassword.Size = new Size(188, 23);
            tbRepeatPassword.TabIndex = 2;
            tbRepeatPassword.TextChanged += tbRepeatPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 395);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 8;
            label4.Text = "Пароль еще раз";
            // 
            // labelWarningLogin
            // 
            labelWarningLogin.AutoSize = true;
            labelWarningLogin.Dock = DockStyle.Fill;
            labelWarningLogin.ForeColor = Color.Red;
            labelWarningLogin.Location = new Point(658, 282);
            labelWarningLogin.Name = "labelWarningLogin";
            labelWarningLogin.Size = new Size(456, 29);
            labelWarningLogin.TabIndex = 9;
            labelWarningLogin.Text = "labelWarningLogin";
            labelWarningLogin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelWarningPassword
            // 
            labelWarningPassword.AutoSize = true;
            labelWarningPassword.Dock = DockStyle.Fill;
            labelWarningPassword.ForeColor = Color.Red;
            labelWarningPassword.Location = new Point(658, 346);
            labelWarningPassword.Name = "labelWarningPassword";
            labelWarningPassword.Size = new Size(456, 29);
            labelWarningPassword.TabIndex = 10;
            labelWarningPassword.Text = "labelWarningPassword";
            labelWarningPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelWarningRepeatPassword
            // 
            labelWarningRepeatPassword.AutoSize = true;
            labelWarningRepeatPassword.Dock = DockStyle.Fill;
            labelWarningRepeatPassword.ForeColor = Color.Red;
            labelWarningRepeatPassword.Location = new Point(658, 410);
            labelWarningRepeatPassword.Name = "labelWarningRepeatPassword";
            labelWarningRepeatPassword.Size = new Size(456, 29);
            labelWarningRepeatPassword.TabIndex = 11;
            labelWarningRepeatPassword.Text = "labelWarningRepeatPassword";
            labelWarningRepeatPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegistrationPrimaryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "RegistrationPrimaryControl";
            Size = new Size(1117, 733);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private LinkLabel llLogin;
        private TextBox tbPassword;
        private Label label2;
        private Button buttonRegistered;
        private Label label3;
        private TextBox tbLogin;
        private TextBox tbRepeatPassword;
        private Label label4;
        private Label labelWarningLogin;
        private Label labelWarningPassword;
        private Label labelWarningRepeatPassword;
    }
}
