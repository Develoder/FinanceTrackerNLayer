using FinanceTracker.UI.EditionPanel.View.Interface;

namespace FinanceTracker.UI.EditionPanel.View
{
    public partial class AccountEditorControl : UserControl, IAccountEditorView
    {
        public string AccountName { get => tbName.Text; set => tbName.Text = value; }
        public int IndexTypeAccount { get => cbTypeAccount.SelectedIndex; set => cbTypeAccount.SelectedIndex = value; }

        public event EventHandler Cancel;
        public event EventHandler Apply;

        public AccountEditorControl()
        {
            InitializeComponent();
        }

        public void SetAllTypeAccount(string[] nameTypeAccounts)
        {
            cbTypeAccount.Items.Clear();
            cbTypeAccount.Items.AddRange(nameTypeAccounts);
        }

        public void CreateAccount()
        {
            tbName.Text = string.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Apply.Invoke(this, EventArgs.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Cancel.Invoke(this, EventArgs.Empty);
        }

        public void ShowWarning(string text)
        {
            labelWarning.Text = text;
            labelWarning.Visible = true;
        }

        public void ClearWarning()
        {
            labelWarning.Visible = false;
        }
    }
}
