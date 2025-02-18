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
    public class PeriodCircleCategoryTransactionPresenter : IPage
    {
        private PeriodAmountTransactionFromCategoryReportDataGenerator _reportDataGenerator;
        private IReportView _reportView;
        private IPeriodCategoryInputView _periodCategoryInputView;

        public event EventHandler InformationChanged;
        public event EventHandler Logout;

        public PeriodCircleCategoryTransactionPresenter(IReportView reportView)
        {
            _reportView = reportView;

            Initialize();
        }

        private void Initialize()
        {
            CreatePeriodCategoryInput();
            CreateReportCreator();
            SetStartDataInViewer();
            GenerateAndShowReport();
        }

        private void CreatePeriodCategoryInput()
        {
            _periodCategoryInputView = new PeriodCategoryInputControl();
            _reportView.SetReportInputControl((Control)_periodCategoryInputView);
        }

        private void CreateReportCreator()
        {
            TransactionService transactionService = new();
            _reportDataGenerator = new(transactionService);
            _reportDataGenerator.SetUser(Session.CurrentUser.Id);
        }

        private void SetStartDataInViewer()
        {
            _periodCategoryInputView.StartDate = DateTime.Now.FirstDay();
            _periodCategoryInputView.EndDate = DateTime.Now.LastDay();
            _periodCategoryInputView.Applay += Applay;
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
            DateTime startDate = _periodCategoryInputView.StartDate;
            DateTime endDate = _periodCategoryInputView.EndDate;
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
            List<CategoryAmountTransaction> categoryAmountTransactions = _reportDataGenerator.GetTransactionsForDates();

            List<PieSlice> slices = categoryAmountTransactions.Select
                (
                 x => new PieSlice()
                 {
                     Value = (double)x.Amounts.Sum(),
                     FillColor = Generate.RandomColor(),
                     Label = $"{x.CategoryName} - {x.Amounts.Sum():#,##0.##} ₽"
                 }
                )
                .ToList();

            Plot plot = _reportView.GetPlot();
            ScottPlot.Plottables.Pie pie = plot.Add.Pie(slices);
            pie.ShowSliceLabels = true;
            pie.ExplodeFraction = 0.1d;

            plot.HideGrid();
            plot.Layout.Frameless();
            plot.ScaleFactor = 1.2f;

            plot.Style.Background(ScottPlot.Color.FromHex("#000000"), ScottPlot.Color.FromHex("#f0f0f0"));
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
            return "Расход по категориям";
        }

        public void Close()
        {
            _reportDataGenerator.Dispose();
        }
    }
}
