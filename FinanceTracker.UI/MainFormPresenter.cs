using FinanceTracker.UI.WindowPanel.FactoryMethodWindowPanel;
using FinanceTracker.UI.WindowPanel.Interface;
using FinanceTracker.Domain.Service;

namespace FinanceTracker.UI
{
    public class MainFormPresenter
    {
        private IMainFormView _mainFormView;
        private UserService _userService;

        private CreatorWindowPanel _creatorWindowPanel;
        private IWindowPanel _windowPanel;

        public MainFormPresenter(IMainFormView mainFormView, UserService userService)
        {
            _mainFormView = mainFormView;
            _userService = userService;

            _mainFormView.PressEnter += PressEnter;
            _mainFormView.FormClosingEvent += FormClosing;

            Initialize();
        }

        public void Initialize()
        {
            if (_userService.AnyUser())
                SetNewWindow(new LoginCreatorWindowPanel());
            else
                SetNewWindow(new RegistrationCreatorWindowPanel());
            
            _userService.Dispose();
        }

        private void SetNewWindowPanel(object? sender, CreatorWindowPanel creatorWindowPanel)
        {
            SetNewWindow(creatorWindowPanel);
        }

        private void SetNewWindow(CreatorWindowPanel creatorWindowPanel)
        {
            _creatorWindowPanel = creatorWindowPanel;
            CreateWindow();
            _mainFormView.ShowWindow(_windowPanel.GetControl());
        }

        private void CreateWindow()
        {
            IWindowPanel windowPanel = _creatorWindowPanel.Create();

            if (_windowPanel != null)
                _windowPanel.SetNewWindow -= SetNewWindowPanel;

            _windowPanel = windowPanel;
            _windowPanel.SetNewWindow += SetNewWindowPanel;
        }

        private void PressEnter(object? sender, EventArgs e)
        {
            _windowPanel.PressEnter();
        }

        private void FormClosing(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
