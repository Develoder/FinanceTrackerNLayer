using FinanceTracker.UI.Page.Interface;
using FinanceTracker.UI.Page.Presenter;
using FinanceTracker.UI.Page.View;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI.Page.FactoryMethodContent
{
    public class HomeCreatorPage : CreatorPage
    {
        public override IPage Create()
        {
            IHomeView homeControl = new HomeControl();
            UserAccountBalanceService userAccountBalanceService = new();

            IPage homePresenter = new HomePresenter(homeControl, userAccountBalanceService);
            return homePresenter;
        }
    }
}
