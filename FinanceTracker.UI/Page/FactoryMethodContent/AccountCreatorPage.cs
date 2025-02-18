using FinanceTracker.UI.Page.Interface;
using FinanceTracker.UI.Page.Presenter;
using FinanceTracker.UI.Page.View;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI.Page.FactoryMethodContent
{
    public class AccountCreatorPage : CreatorPage
    {
        public override IPage Create()
        {
            IAccountView accountControl = new AccountControl();
            AccountViewerService accountViewerService = new();
            AccountService accountService = new();

            IPage accountPresenter = new AccountPresenter(accountControl, accountViewerService, accountService);
            return accountPresenter;
        }
    }
}
