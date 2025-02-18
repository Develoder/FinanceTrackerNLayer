
namespace FinanceTracker.UI.WindowPanel.View
{
    partial class LoginControl
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
            buttonLogin = new Button();
            tbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            llRegistration = new LinkLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbUser = new ComboBox();
            label3 = new Label();
            labelWarningLogin = new Label();
            labelWarningPassword = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(464, 430);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(188, 31);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += button1_Click;
            // 
            // tpPassword
            // 
            tbPassword.Location = new Point(464, 381);
            tbPassword.MaxLength = 20;
            tbPassword.Name = "tpPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(188, 23);
            tbPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 299);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 363);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // llRegistration
            // 
            llRegistration.AutoSize = true;
            llRegistration.Dock = DockStyle.Fill;
            llRegistration.Location = new Point(464, 464);
            llRegistration.Name = "llRegistration";
            llRegistration.Size = new Size(188, 15);
            llRegistration.TabIndex = 3;
            llRegistration.TabStop = true;
            llRegistration.Text = "Регистрация";
            llRegistration.TextAlign = ContentAlignment.MiddleCenter;
            llRegistration.LinkClicked += llRegistration_LinkClicked;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 1, 3);
            tableLayoutPanel1.Controls.Add(llRegistration, 1, 10);
            tableLayoutPanel1.Controls.Add(tbPassword, 1, 7);
            tableLayoutPanel1.Controls.Add(label2, 1, 6);
            tableLayoutPanel1.Controls.Add(buttonLogin, 1, 9);
            tableLayoutPanel1.Controls.Add(cbUser, 1, 4);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(labelWarningLogin, 2, 4);
            tableLayoutPanel1.Controls.Add(labelWarningPassword, 2, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1117, 733);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // icbUser
            // 
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(464, 317);
            cbUser.Name = "icbUser";
            cbUser.Size = new Size(188, 23);
            cbUser.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(464, 254);
            label3.Name = "label3";
            label3.Size = new Size(188, 25);
            label3.TabIndex = 5;
            label3.Text = "Вход";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelWarningLogin
            // 
            labelWarningLogin.AutoSize = true;
            labelWarningLogin.Dock = DockStyle.Fill;
            labelWarningLogin.ForeColor = Color.Red;
            labelWarningLogin.Location = new Point(658, 314);
            labelWarningLogin.Name = "labelWarningLogin";
            labelWarningLogin.Size = new Size(456, 29);
            labelWarningLogin.TabIndex = 10;
            labelWarningLogin.Text = "labelWarningLogin";
            labelWarningLogin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelWarningPassword
            // 
            labelWarningPassword.AutoSize = true;
            labelWarningPassword.Dock = DockStyle.Fill;
            labelWarningPassword.ForeColor = Color.Red;
            labelWarningPassword.Location = new Point(658, 378);
            labelWarningPassword.Name = "labelWarningPassword";
            labelWarningPassword.Size = new Size(456, 29);
            labelWarningPassword.TabIndex = 11;
            labelWarningPassword.Text = "labelWarningPassword";
            labelWarningPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginPrimaryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "LoginPrimaryControl";
            Size = new Size(1117, 733);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogin;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private LinkLabel llRegistration;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cbUser;
        private Label label3;
        private Label labelWarningLogin;
        private Label labelWarningPassword;
    }
}
