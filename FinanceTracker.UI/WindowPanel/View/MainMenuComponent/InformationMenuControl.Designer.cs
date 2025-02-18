namespace FinanceTracker.UI.WindowPanel.View.MainMenuComponent
{
    partial class InformationMenuControl
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
            labelUserName = new Label();
            pictureBox1 = new PictureBox();
            labelBalance = new Label();
            pictureBox2 = new PictureBox();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(labelUserName, 2, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 3, 0);
            tableLayoutPanel2.Controls.Add(labelBalance, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(230, 28);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Dock = DockStyle.Fill;
            labelUserName.Location = new Point(94, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(109, 28);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "Имя пользователя";
            labelUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.user_24;
            pictureBox1.Location = new Point(206, 4);
            pictureBox1.Margin = new Padding(0, 4, 0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Dock = DockStyle.Fill;
            labelBalance.Location = new Point(3, 0);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(61, 28);
            labelBalance.TabIndex = 3;
            labelBalance.Text = "1000 000 ₽";
            labelBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.wallet_24;
            pictureBox2.Location = new Point(67, 4);
            pictureBox2.Margin = new Padding(0, 4, 0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // InformationMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tableLayoutPanel2);
            Name = "InformationMenuControl";
            Size = new Size(230, 28);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label labelUserName;
        private PictureBox pictureBox1;
        private Label labelBalance;
        private PictureBox pictureBox2;
    }
}
