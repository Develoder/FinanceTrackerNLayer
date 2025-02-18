using FinanceTracker.Service;
using FinanceTracker.Service.Interface;
using FinanceTracker.UI.WindowPanel.Interface;
using FinanceTracker.UI.WindowPanel.Presenter;
using FinanceTracker.UI.WindowPanel.View;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI.WindowPanel.FactoryMethodWindowPanel
{
    public class LoginCreatorWindowPanel : CreatorWindowPanel
    {
        public override IWindowPanel Create()
        {
            ILoginView loginView = new LoginControl();
            UserService userService = new();
            IAuthService registryAuthService = new RegistryAuthService();

            LoginPresenter loginPresenter = new(loginView, userService, registryAuthService);
            return loginPresenter;
        }
    }
}
