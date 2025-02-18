using FinanceTracker.UI.WindowPanel.Interface;
using FinanceTracker.UI.WindowPanel.Presenter;
using FinanceTracker.UI.WindowPanel.View;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI.WindowPanel.FactoryMethodWindowPanel
{
    public class ManiMenuCreatorWindowPanel : CreatorWindowPanel
    {
        public override IWindowPanel Create()
        {
            IMainMenuView mainMenuView = new MainMenuControl();
            UserAccountBalanceService userAccountBalanceService = new();

            IWindowPanel mainMenuPresenter = new MainMenuPresenter(mainMenuView, userAccountBalanceService);
            return mainMenuPresenter;
        }
    }
}
