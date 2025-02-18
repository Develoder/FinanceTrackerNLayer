using FinanceTracker.Service;
using FinanceTracker.Service.Interface;
using FinanceTracker.UI.WindowPanel.Interface;
using FinanceTracker.UI.WindowPanel.Presenter;
using FinanceTracker.UI.WindowPanel.View;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI.WindowPanel.FactoryMethodWindowPanel
{
    public class RegistrationCreatorWindowPanel : CreatorWindowPanel
    {
        public override IWindowPanel Create()
        {
            IRegistrationView registrationControl = new RegistrationControl();
            UserService userService = new();
            IAuthService registryAuthService = new RegistryAuthService();

            RegistrationPresenter registrationPresenter = new(registrationControl, userService, registryAuthService);
            return registrationPresenter;
        }
    }
}
