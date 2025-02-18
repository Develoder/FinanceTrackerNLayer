using FinanceTracker.UI.CustomTools;
using FinanceTracker.UI.Page.Interface;

namespace FinanceTracker.UI.Page.View
{
    public partial class TransactionControl : UserControl, ITransactionView
    {
        private CenterPanel _centerPanel;

        public event EventHandler AddTransaction;
        public event EventHandler DeleteTransaction;
        public event EventHandler EditTransaction;

        public TransactionControl()
        {
            InitializeComponent();
        }

        public void ShowTransactions(object[][] TransactionViewerObjects)
        {
            dgvcTransaction.Rows.Clear();

            foreach (object[] accountViewerObject in TransactionViewerObjects)
            {
                InsertDataGrid(accountViewerObject);
            }

            ChagneEditionMode(true);
        }

        private void InsertDataGrid(object[] accountViewerObject)
        {
            DataGridViewRow row = GetNewRow();

            for (int i = 0; i < accountViewerObject.Length; i++)
            {
                row.Cells[i].Value = accountViewerObject[i];
            }
        }

        private DataGridViewRow GetNewRow()
        {
            int id = dgvcTransaction.Rows.Add();
            DataGridViewRow row = dgvcTransaction.Rows[id];

            return row;
        }

        public void ShowEmptyTransactions()
        {
            dgvcTransaction.Rows.Clear();
            ChagneEditionMode(false);
        }

        private void ChagneEditionMode(bool isEdition)
        {
            buttonDeleted.Enabled = isEdition;
            buttonEdit.Enabled = isEdition;
        }

        public int GetCurrentTransactionIndex()
        {
            return dgvcTransaction.CurrentRow.Index;
        }

        public void ShowTransactionEditorControl(Control editionControl)
        {
            _centerPanel = new CenterPanel();
            _centerPanel.Add(editionControl);
            _centerPanel.Dock = DockStyle.Fill;
            Controls.Add(_centerPanel);
            _centerPanel.BringToFront();
        }

        public void ClearTransactionEditionControl()
        {
            _centerPanel.Clear();
            Controls.Remove(_centerPanel);
            _centerPanel.Dispose();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTransaction.Invoke(this, EventArgs.Empty);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditTransaction.Invoke(this, EventArgs.Empty);
        }

        private void buttonDeleted_Click(object sender, EventArgs e)
        {
            DeleteTransaction.Invoke(this, EventArgs.Empty);
        }
    }
}
