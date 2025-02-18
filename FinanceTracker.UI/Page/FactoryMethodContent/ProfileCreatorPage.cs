using FinanceTracker.UI.Page.Interface;
using FinanceTracker.UI.Page.Presenter;
using FinanceTracker.UI.Page.View;

namespace FinanceTracker.UI.Page.FactoryMethodContent
{
    public class ProfileCreatorPage : CreatorPage
    {
        public override IPage Create()
        {
            IProfileView profileControl = new ProfileControl();

            IPage profilePresenter = new ProfilePresenter(profileControl);

            return profilePresenter;
        }
    }
}
