using System.ComponentModel;

namespace FinanceTracker.UI.CustomTools
{
    public class CollapsePanel : FlowLayoutPanel
    {
        [Category("Collapse")]
        [DefaultValue(TypeDirection.Vertical)]
        [Description("Направление сворачивания\\разворачивания")]
        public TypeDirection Direction { get; set; } = TypeDirection.Vertical;

        [Category("Collapse")]
        [DefaultValue(0)]
        [Description("Минимальный горизонтальный размер (обязателен при горизонтальном использовании)")]
        public int HorizontalMinSize { get; set; } = 0;

        [Category("Collapse")]
        [DefaultValue(50)]
        [Description("Время в милесекундах на сворачивания\\разворачивания")]
        public int TimeCollapse { get; set; } = 50;

        [Category("Collapse")]
        [DefaultValue(10)]
        [Description("Интервал между подсчетами сворачивания\\разворачивания")]
        public int TimerInterval { get; set; } = 10;

        [Category("Collapse")]
        [DefaultValue(StateCollapse.Collapse)]
        [Description("Первоначальное состояние сворачивания\\разворачивания")]
        public StateCollapse InitialView { get; set; } = StateCollapse.Collapse;

        public enum StateCollapse
        {
            /// <summary>
            /// Свернутый
            /// </summary>
            Collapse,
            /// <summary>
            /// Развернутый
            /// </summary>
            Expanded
        }

        public enum TypeDirection
        {
            Horizontal,
            Vertical
        }

        private System.Windows.Forms.Timer _timer;

        private int _minSize;
        private int _maxSize;
        private float _stepChnagSize = -1;

        /// <summary>
        /// Свернут
        /// </summary>
        bool _isCollapsed = false;
        private float _cunnertSize;

        public CollapsePanel()
        {
            _timer = new();
            _timer.Interval = TimerInterval;
            _timer.Tick += _timer_Tick;
        }

        public void ExecuteCollapse()
        {
            if (_stepChnagSize == -1)
            {
                InitializationStartParameters();
            }

            if (_timer.Enabled)
                _isCollapsed = !_isCollapsed;

            _timer.Start();
        }

        /// <summary>
        /// Нужно вызвать данный метод после загрузки формы, для того чтобы применить начальное свойство <see cref="InitialView"/>
        /// </summary>
        public void InitializationStartParameters()
        {
            if (Direction == TypeDirection.Horizontal)
            {
                SetHorizontalSize();
            }
            else
            {
                Button? button = FindButton();

                if (button == null)
                    return;

                SetVerticalSize(button ?? throw new Exception());
            }

            _cunnertSize = InitialView == StateCollapse.Collapse ? _minSize : _maxSize;
            _stepChnagSize = (_maxSize - _minSize) / ((float)TimeCollapse / TimerInterval);
            _isCollapsed = InitialView == StateCollapse.Collapse;

            ApplySize();
        }

        private void SetHorizontalSize()
        {
            _minSize = HorizontalMinSize;
            _maxSize = Width;
        }

        private void SetVerticalSize(Button button)
        {
            _minSize = button.Size.Height;
            _maxSize = button.Size.Height * Controls.Count;
        }

        private Button? FindButton()
        {
            Button? button = null;
            foreach (object? control in Controls)
            {
                if (control is Button)
                {
                    button = (Button)control;
                }
            }

            return button;
        }

        private void ApplySize()
        {
            if (Direction == TypeDirection.Horizontal)
                Width = (int)_cunnertSize;
            else
                Height = (int)_cunnertSize;
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            if (_isCollapsed)
                MakeCollapse();
            else
                MakeSuccess();

            ApplySize();
        }

        private void MakeCollapse()
        {
            _cunnertSize += _stepChnagSize;
            if (_cunnertSize >= _maxSize)
            {
                _cunnertSize = _maxSize;
                _timer.Stop();
                _isCollapsed = false;
            }
        }

        private void MakeSuccess()
        {
            _cunnertSize -= _stepChnagSize;
            if (_cunnertSize <= _minSize)
            {
                _cunnertSize = _minSize;
                _timer.Stop();
                _isCollapsed = true;
            }
        }
    }
}
