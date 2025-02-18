namespace FinanceTracker.UI.Page.Interface
{
    public interface ITransactionView
    {
        public void ShowTransactions(object[][] TransactionViewerObjects);
        public void ShowEmptyTransactions();
        public int GetCurrentTransactionIndex();
        public void ShowTransactionEditorControl(Control editionControl);
        public void ClearTransactionEditionControl();

        public event EventHandler AddTransaction;
        public event EventHandler DeleteTransaction;
        public event EventHandler EditTransaction;
    }
}
