using FinanceTracker.UI.Page.Interface;
using FinanceTracker.UI.Page.Presenter;
using FinanceTracker.UI.Page.View;

namespace FinanceTracker.UI.Page.FactoryMethodContent
{
    public class PeriodTransactionForEveryDayCreatorPage : CreatorPage
    {
        public override IPage Create()
        {
            IReportView reportView = new ReportControl();
            IPage periodTransactionForEveryDayPage = new PeriodTransactionForEveryDayPresenter(reportView);

            return periodTransactionForEveryDayPage;
        }
    }
}
