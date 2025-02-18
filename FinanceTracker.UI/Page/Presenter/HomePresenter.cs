using FinanceTracker.UI.Page.Interface;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI.Page.Presenter
{
    public class HomePresenter : IPage
    {
        private IHomeView _homeView;
        private UserAccountBalanceService _userAccountBalanceService;

        public event EventHandler InformationChanged;
        public event EventHandler Logout;

        public HomePresenter(IHomeView homeView, UserAccountBalanceService userAccountBalanceService)
        {
            _homeView = homeView;
            _userAccountBalanceService = userAccountBalanceService;

            Initialize();
        }

        private void Initialize()
        {
            _userAccountBalanceService.SetUser(Session.CurrentUser);
            _userAccountBalanceService.UpdateInformationBalanced();

            if (_userAccountBalanceService.IsHasAccount)
            {
                string text =
                "\nПриложение позволяет пользователям вести учет своих доходов и расходов, анализировать свои финансовые данные и планировать бюджет." +
                "\r\n\r\nОсновные возможности" +
                "\r\n\r\n- Регистрация новых пользователей и аутентификация" +
                "\r\n- Управление банковскими счетами и кредитными картами" +
                "\r\n- Добавление транзакций с указанием категории, суммы и даты" +
                "\r\n- Просмотр статистики и графиков по категориям расходов и доходов" +
                "\r\n- Поддержка различных методов оплаты и категорий транзакций";
                _homeView.ShowInformation(text);
            }
            else
            {
                _homeView.ShowInformation("Чтобы начать работу вы должны создать счет.\n\nСчет можно создать в разделе \"Счет\"");
            }
        }

        public string GetHeader()
        {
            return "Главная";
        }

        public void Close()
        {
            _userAccountBalanceService.Dispose();
        }

        public Control GetControl()
        {
            return (Control)_homeView;
        }

        public void PressEnter()
        {
            
        }
    }
}
