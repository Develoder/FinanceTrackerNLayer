namespace FinanceTracker.UI.EditionPanel.Interface
{
    public interface ITransactionEditorView
    {
        public decimal Amount { get; set; }
        public int CategoryTransactionIndex { get; set; }
        public int AccountIndex { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        public void SetIncomeMode();
        public void SetExpenseMode();
        public void SetCategoryTransactions(string[] categoryTransactionNames);
        public void SetAccountNames(string[] accountNames);
        void ShowWarning(string textWarning);
        void ClearWarning();

        public event EventHandler ChangeTypeTransaction;
        public event EventHandler Cancel;
        public event EventHandler Apply;
    }
}
