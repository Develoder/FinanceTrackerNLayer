using FinanceTracker.Domain.Report;
using FinanceTracker.Domain.Report.ReportDTO;
using FinanceTracker.Domain.Service;
using FinanceTracker.UI.Page.Interface;
using FinanceTracker.UI.ReportInputPanel.Interface;
using FinanceTracker.UI.ReportInputPanel.View;
using MyExtension;
using ScottPlot;

namespace FinanceTracker.UI.Page.Presenter
{
    public class PeriodTransactionForEveryDayPresenter : IPage
    {
        private PeriodTransactionForEveryDayReportDataGenerator _reportDataGenerator;
        private IReportView _reportView;
        private IPeriodTransactionInputView _periodTransactionInputView;
        
        public event EventHandler InformationChanged;
        public event EventHandler Logout;

        public PeriodTransactionForEveryDayPresenter(IReportView reportView)
        {
            _reportView = reportView;

            Initialize();
        }

        private void Initialize()
        {
            CreatePeriodTrnasactionInput();
            CreateReportCreator();
            SetStartDataInViewer();
            GenerateAndShowReport();
        }

        private void CreatePeriodTrnasactionInput()
        {
            _periodTransactionInputView = new PeriodTransactionInputControl();
            _reportView.SetReportInputControl((Control)_periodTransactionInputView);
        }

        private void CreateReportCreator()
        {
            TransactionService transactionService = new();
            _reportDataGenerator = new(transactionService);
            _reportDataGenerator.SetUser(Session.CurrentUser.Id);
        }

        private void SetStartDataInViewer()
        {
            _periodTransactionInputView.StartDate = DateTime.Now.FirstDay();
            _periodTransactionInputView.EndDate = DateTime.Now.LastDay();
            _periodTransactionInputView.Applay += Applay;
        }

        private void Applay(object? sender, EventArgs e)
        {
            GenerateAndShowReport();
        }

        public void PressEnter()
        {
            GenerateAndShowReport();
        }

        private void GenerateAndShowReport()
        {
            DateTime startDate = _periodTransactionInputView.StartDate;
            DateTime endDate = _periodTransactionInputView.EndDate;
            _reportDataGenerator.SetData(startDate, endDate);
            if (_reportDataGenerator.IsAnyTransactionInPeriod())
            {
                ShowReport();
            }
            else
            {
                ShowWarningParameterReport();
            }
        }

        private void ShowReport()
        {
            List<TransactionsForDate> transactionsForDates = _reportDataGenerator.GetTransactionsForDates();
            var a = transactionsForDates.ToDictionary(x => x.DateTime, y => y.AmountTransactions.Sum());
            List<OHLC> prices = transactionsForDates
                .Select(x => new OHLC()
                {
                    DateTime = x.DateTime,
                    Close = (double)Math.Round(x.AmountTransactions.Sum(x => x), 2),
                    TimeSpan = TimeSpan.FromDays(1)
                })
                .ToList();

            Plot plot = _reportView.GetPlot();
            var candlePlot = plot.Add.Candlestick(prices);
            plot.Axes.DateTimeTicksBottom();
        }

        private void ShowWarningParameterReport()
        {
            string title = "Информация";
            string text = "За указанный период, нет транзакций!";
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Control GetControl()
        {
            return (Control)_reportView;
        }

        public string GetHeader()
        {
            return "Транзакции по дням";
        }

        public void Close()
        {
            _reportDataGenerator.Dispose();
        }
    }
}
