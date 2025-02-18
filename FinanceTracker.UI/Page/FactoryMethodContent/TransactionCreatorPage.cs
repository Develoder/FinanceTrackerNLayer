using FinanceTracker.UI.Page.Interface;
using FinanceTracker.UI.Page.Presenter;
using FinanceTracker.UI.Page.View;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI.Page.FactoryMethodContent
{
    public class TransactionCreatorPage : CreatorPage
    {
        public override IPage Create()
        {
            ITransactionView transactionControl = new TransactionControl();
            TransactionService transactionService = new();
            TransactionViewerService transactionViewerService = new();

            IPage transactionPage = new TransactionPresenter(transactionControl, transactionViewerService, transactionService);
            return transactionPage;
        }
    }
}
