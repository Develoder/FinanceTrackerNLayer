using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
#if DEBUG
            HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();
#endif

            ApplicationConfiguration.Initialize();

            MainForm mainForm = new();
            UserService userService = new();
            MainFormPresenter mainFormPresenter = new(mainForm, userService);
            Application.Run(mainForm);
        }
    }
}