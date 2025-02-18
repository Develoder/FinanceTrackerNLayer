using FinanceTracker.UI.CustomTools;

namespace FinanceTracker.UI.Page.View
{
    partial class TransactionControl
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
            dgvcTransaction = new DataGridViewCustom();
            tlpEditDataGrid = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonDeleted = new Button();
            buttonEdit = new Button();
            ColumnType = new DataGridViewImageColumn();
            ColumnAmount = new DataGridViewTextBoxColumn();
            ColumnCategory = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnAccount = new DataGridViewTextBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcTransaction).BeginInit();
            tlpEditDataGrid.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvcTransaction, 0, 3);
            tableLayoutPanel1.Controls.Add(tlpEditDataGrid, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(917, 666);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvcTransaction
            // 
            dgvcTransaction.AllowUserToAddRows = false;
            dgvcTransaction.AllowUserToDeleteRows = false;
            dgvcTransaction.AllowUserToResizeRows = false;
            dgvcTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcTransaction.Columns.AddRange(new DataGridViewColumn[] { ColumnType, ColumnAmount, ColumnCategory, ColumnDate, ColumnAccount, ColumnDescription });
            dgvcTransaction.Dock = DockStyle.Fill;
            dgvcTransaction.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvcTransaction.Location = new Point(0, 38);
            dgvcTransaction.Margin = new Padding(0);
            dgvcTransaction.MultiSelect = false;
            dgvcTransaction.Name = "dgvcTransaction";
            dgvcTransaction.ReadOnly = true;
            dgvcTransaction.Size = new Size(917, 628);
            dgvcTransaction.TabIndex = 1;
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
            // ColumnType
            // 
            ColumnType.Frozen = true;
            ColumnType.HeaderText = "";
            ColumnType.MinimumWidth = 24;
            ColumnType.Name = "ColumnType";
            ColumnType.ReadOnly = true;
            ColumnType.Resizable = DataGridViewTriState.False;
            ColumnType.Width = 24;
            // 
            // ColumnAmount
            // 
            ColumnAmount.HeaderText = "Сумма";
            ColumnAmount.Name = "ColumnAmount";
            ColumnAmount.ReadOnly = true;
            // 
            // ColumnCategory
            // 
            ColumnCategory.FillWeight = 120F;
            ColumnCategory.HeaderText = "Категория";
            ColumnCategory.Name = "ColumnCategory";
            ColumnCategory.ReadOnly = true;
            ColumnCategory.Width = 120;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Дата";
            ColumnDate.Name = "ColumnDate";
            ColumnDate.ReadOnly = true;
            // 
            // ColumnAccount
            // 
            ColumnAccount.FillWeight = 160F;
            ColumnAccount.HeaderText = "Счет";
            ColumnAccount.Name = "ColumnAccount";
            ColumnAccount.ReadOnly = true;
            ColumnAccount.Width = 160;
            // 
            // ColumnDescription
            // 
            ColumnDescription.FillWeight = 160F;
            ColumnDescription.HeaderText = "Описание";
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.ReadOnly = true;
            ColumnDescription.Width = 160;
            // 
            // TransactionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TransactionControl";
            Size = new Size(917, 666);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcTransaction).EndInit();
            tlpEditDataGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private CustomTools.DataGridViewCustom dgvcTransaction;
        private TableLayoutPanel tlpEditDataGrid;
        private Button buttonAdd;
        private Button buttonDeleted;
        private Button buttonEdit;
        private DataGridViewImageColumn ColumnType;
        private DataGridViewTextBoxColumn ColumnAmount;
        private DataGridViewTextBoxColumn ColumnCategory;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnAccount;
        private DataGridViewTextBoxColumn ColumnDescription;
    }
}
