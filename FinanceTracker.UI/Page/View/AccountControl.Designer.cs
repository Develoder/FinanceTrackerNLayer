namespace FinanceTracker.UI.Page.View
{
    partial class AccountControl
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
            dgvcAccount = new CustomTools.DataGridViewCustom();
            tlpEditDataGrid = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonDeleted = new Button();
            buttonEdit = new Button();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnTypeAccount = new DataGridViewTextBoxColumn();
            ColumnBalance = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcAccount).BeginInit();
            tlpEditDataGrid.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvcAccount, 0, 1);
            tableLayoutPanel1.Controls.Add(tlpEditDataGrid, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(917, 666);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvcAccount
            // 
            dgvcAccount.AllowUserToAddRows = false;
            dgvcAccount.AllowUserToDeleteRows = false;
            dgvcAccount.AllowUserToResizeRows = false;
            dgvcAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcAccount.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnTypeAccount, ColumnBalance });
            dgvcAccount.Dock = DockStyle.Fill;
            dgvcAccount.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvcAccount.Location = new Point(0, 38);
            dgvcAccount.Margin = new Padding(0);
            dgvcAccount.MultiSelect = false;
            dgvcAccount.Name = "dgvcAccount";
            dgvcAccount.ReadOnly = true;
            dgvcAccount.Size = new Size(917, 628);
            dgvcAccount.TabIndex = 1;
            // 
            // tlpEditDataGrid
            // 
            tlpEditDataGrid.AutoSize = true;
            tlpEditDataGrid.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpEditDataGrid.ColumnCount = 4;
            tlpEditDataGrid.ColumnStyles.Add(new ColumnStyle());
            tlpEditDataGrid.ColumnStyles.Add(new ColumnStyle());
            tlpEditDataGrid.ColumnStyles.Add(new ColumnStyle());
            tlpEditDataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpEditDataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEditDataGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpEditDataGrid.Controls.Add(buttonAdd, 0, 0);
            tlpEditDataGrid.Controls.Add(buttonDeleted, 2, 0);
            tlpEditDataGrid.Controls.Add(buttonEdit, 1, 0);
            tlpEditDataGrid.Dock = DockStyle.Fill;
            tlpEditDataGrid.Location = new Point(0, 0);
            tlpEditDataGrid.Margin = new Padding(0);
            tlpEditDataGrid.Name = "tlpEditDataGrid";
            tlpEditDataGrid.RowCount = 1;
            tlpEditDataGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEditDataGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpEditDataGrid.Size = new Size(917, 38);
            tlpEditDataGrid.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Image = Resources.add_24;
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(32, 32);
            buttonAdd.TabIndex = 0;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDeleted
            // 
            buttonDeleted.Image = Resources.basket_24;
            buttonDeleted.Location = new Point(79, 3);
            buttonDeleted.Name = "buttonDeleted";
            buttonDeleted.Size = new Size(32, 32);
            buttonDeleted.TabIndex = 2;
            buttonDeleted.UseVisualStyleBackColor = true;
            buttonDeleted.Click += buttonDeleted_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Image = Resources.edit_24;
            buttonEdit.Location = new Point(41, 3);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(32, 32);
            buttonEdit.TabIndex = 1;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Описание";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 150;
            // 
            // ColumnTypeAccount
            // 
            ColumnTypeAccount.HeaderText = "Тип счета";
            ColumnTypeAccount.Name = "ColumnTypeAccount";
            ColumnTypeAccount.ReadOnly = true;
            ColumnTypeAccount.Width = 150;
            // 
            // ColumnBalance
            // 
            ColumnBalance.HeaderText = "Баланс";
            ColumnBalance.Name = "ColumnBalance";
            ColumnBalance.ReadOnly = true;
            // 
            // AccountControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "AccountControl";
            Size = new Size(917, 666);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcAccount).EndInit();
            tlpEditDataGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FinanceTracker.UI.CustomTools.DataGridViewCustom dgvcAccount;
        private TableLayoutPanel tlpEditDataGrid;
        private Button buttonAdd;
        private Button buttonDeleted;
        private Button buttonEdit;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnTypeAccount;
        private DataGridViewTextBoxColumn ColumnBalance;
    }
}
