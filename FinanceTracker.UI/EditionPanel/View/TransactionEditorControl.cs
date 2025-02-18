using FinanceTracker.UI.EditionPanel.Interface;

namespace FinanceTracker.UI.EditionPanel.View
{
    public partial class TransactionEditorControl : UserControl, ITransactionEditorView
    {
        public decimal Amount { get => nbcAmount.GetDecimal() ?? throw new NullReferenceException(); set => nbcAmount.SetValue(value); }
        public int CategoryTransactionIndex { get => cbCategory.SelectedIndex; set => cbCategory.SelectedIndex = value; }
        public int AccountIndex { get => cbAccount.SelectedIndex; set => cbAccount.SelectedIndex = value; }
        public DateTime DateTime { get => dtpDate.Value; set => dtpDate.Value = value; }
        public string Description { get => tbDescription.Text; set => tbDescription.Text = value; }

        public event EventHandler ChangeTypeTransaction;
        public event EventHandler Cancel;
        public event EventHandler Apply;

        public TransactionEditorControl()
        {
            InitializeComponent();
        }

        public void SetCategoryTransactions(string[] categoryTransactionNames)
        {
            cbCategory.Items.Clear();
            cbCategory.Items.AddRange(categoryTransactionNames);
        }

        public void SetAccountNames(string[] accountNames)
        {
            cbAccount.Items.Clear();
            cbAccount.Items.AddRange(accountNames);
        }

        public void ShowWarning(string textWarning)
        {
            labelWarning.Text = textWarning;
        }

        public void ClearWarning()
        {
            labelWarning.Text = string.Empty;
        }

        public void SetIncomeMode()
        {
            buttonType.Text = "Доход";
            buttonType.Image = Resources.plus_16;
        }

        public void SetExpenseMode()
        {
            buttonType.Text = "Расход";
            buttonType.Image = Resources.minus_16;
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            ChangeTypeTransaction.Invoke(this, EventArgs.Empty);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Apply.Invoke(this, EventArgs.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Cancel.Invoke(this, EventArgs.Empty);
        }
    }
}
