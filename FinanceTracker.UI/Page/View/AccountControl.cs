using FinanceTracker.UI.CustomTools;
using FinanceTracker.UI.Page.Interface;

namespace FinanceTracker.UI.Page.View
{
    public partial class AccountControl : UserControl, IAccountView
    {
        private CenterPanel _centerPanel;

        public event EventHandler AddAccount;
        public event EventHandler DeleteAccount;
        public event EventHandler EditAccount;

        public AccountControl()
        {
            InitializeComponent();
        }

        public void ShowAccounts(object[][] accountViewerDataObjects)
        {
            dgvcAccount.Rows.Clear();

            foreach (object[] accountViewerDataObject in accountViewerDataObjects)
            {
                InsertDataGrid(accountViewerDataObject);
            }

            ChagneEditionMode(true);
        }

        private void InsertDataGrid(object[] accountViewerDataObject)
        {
            DataGridViewRow row = GetNewRow();

            for (int i = 0; i < accountViewerDataObject.Length; i++)
            {
                row.Cells[i].Value = accountViewerDataObject[i];
            }
        }

        private DataGridViewRow GetNewRow()
        {
            int id = dgvcAccount.Rows.Add();
            DataGridViewRow row = dgvcAccount.Rows[id];

            return row;
        }

        public void ShowEmptyAccounts()
        {
            dgvcAccount.Rows.Clear();
            ChagneEditionMode(false);
        }

        private void ChagneEditionMode(bool isEdition)
        {
            buttonDeleted.Enabled = isEdition;
            buttonEdit.Enabled = isEdition;
        }

        public int GetCurrentAccountIndex()
        {
            return dgvcAccount.CurrentRow.Index;
        }

        public void ShowAccountEditorControl(Control editionControl)
        {
            _centerPanel = new CenterPanel();
            _centerPanel.Add(editionControl);
            _centerPanel.Dock = DockStyle.Fill;
            Controls.Add(_centerPanel);
            _centerPanel.BringToFront();
        }

        public void ClearAccountEditionControl()
        {
            _centerPanel.Clear();
            Controls.Remove(_centerPanel);
            _centerPanel.Dispose();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddAccount.Invoke(this, EventArgs.Empty);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditAccount.Invoke(this, EventArgs.Empty);
        }

        private void buttonDeleted_Click(object sender, EventArgs e)
        {
            DeleteAccount.Invoke(this, EventArgs.Empty);
        }
    }
}
