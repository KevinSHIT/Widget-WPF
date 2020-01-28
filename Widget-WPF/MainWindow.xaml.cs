using System;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;

using Widget_WPF.Win32;
using MessageBox = System.Windows.MessageBox;

namespace Widget_WPF
{

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public Thread t;

        public NotifyIcon notify;
        readonly BrushConverter bc = new BrushConverter();
        readonly Setting s;

        public MainWindow()
        {
            InitializeComponent();
            InitializeNotifyIcon();
            InitializeContextMenuStrip();
            t = new Thread(new ThreadStart(SetTime));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            MouseMove += MainWindow_MouseMove;
            Topmost = false;
            s = new Setting(this);

        }

        private void MainWindow_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && !lockForm.Checked)
            {
                this.DragMove();
            }
        }

        public void UpdateFormColor(string htmlCode)
        {
            Background = (Brush)bc.ConvertFrom(htmlCode);
        }


        private void Button_Click(object sender, RoutedEventArgs e) => ShowSetting();

        private void Setting_Click(object sender, EventArgs e) => ShowSetting();

        private void Exit_Click(object sender, EventArgs e) => Environment.Exit(0);

        public void RefreshBackColor(string htmlColor)
        {
            try
            {
                Background = (Brush)bc.ConvertFrom(htmlColor);
            }
            catch
            {
                //MessageBox.Show("设置颜色出现错误，您输入的颜色有问题？已回滚至上一个色彩。", "错误", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
        public void SetTime()
        {
            while (true)
            {
                Dispatcher.Invoke(new Action(delegate
                {
                    Hour.Content = Tool.GetDate(Tool.Mode.Hour).PadLeft(2, '0');
                    Date.Content = Tool.GetDate(Tool.Mode.Date);
                    Minute.Content = Tool.GetDate(Tool.Mode.Minute).PadLeft(2, '0');
                    Second.Content = Tool.GetDate(Tool.Mode.Second).PadLeft(2, '0');
                }));

                Thread.Sleep(100);
            }
        }

        #region 初始化
        readonly ContextMenuStrip cms = new ContextMenuStrip();
        private void InitializeNotifyIcon()
        {
            notify = new System.Windows.Forms.NotifyIcon
            {
                Text = "Time Widger",
                Icon = new System.Drawing.Icon(@"cby3o-13tit-004.ico"),
                Visible = true,
                ContextMenuStrip = cms
            };

        }

        ToolStripMenuItem exit, lockForm, setting;
        ToolStripSeparator tss;
        ToolStripLabel name;
        private void InitializeContextMenuStrip()
        {
            cms.RenderMode = ToolStripRenderMode.Professional;
            cms.ShowCheckMargin = true;
            cms.ShowImageMargin = false;
            exit = new ToolStripMenuItem();
            exit.Click += Exit_Click;
            exit.Text = "退出";

            lockForm = new ToolStripMenuItem();
            lockForm.Click += LockForm_Click;
            lockForm.Text = "锁定";

            setting = new ToolStripMenuItem();
            setting.Click += Setting_Click;
            setting.Text = "设置";

            tss = new ToolStripSeparator();

            name = new ToolStripLabel
            {
                Text = "Widget-WPF"
            };

            cms.Items.AddRange(new ToolStripItem[]
            {
                name,
                tss,
                lockForm,
                setting,
                exit

            });
        }

        private void MW_Loaded(object sender, RoutedEventArgs e)
        {
            WindowInteropHelper wndHelper = new WindowInteropHelper(this);

            int exStyle = (int)Api.GetWindowLong(wndHelper.Handle, (int)Api.GetWindowLongFields.GWL_EXSTYLE);

            exStyle |= (int)Api.ExtendedWindowStyles.WS_EX_TOOLWINDOW;

            Api.SetWindowLong(wndHelper.Handle, (int)Api.GetWindowLongFields.GWL_EXSTYLE, (IntPtr)exStyle);

            Api.SetParent(new WindowInteropHelper(this).Handle, Api.GetDesktopPtr());

        }



        private void ShowSetting()
        {
            //s = new Setting(this);
            try
            {
                s.ShowDialog();
            }
            catch
            { }
        }

        private void LockForm_Click(object sender, EventArgs e)
        {
            if (lockForm.Checked == true)
            {
                lockForm.Checked = false;
            }
            else
            {
                lockForm.Checked = true;
            }
        }
        #endregion

    }



    class Tool
    {
        public enum Mode
        {
            Hour = 0,
            Minute = 1,
            Date = 2,
            Second = 3
        }

        public static string GetDate(Mode mode)
        {
            switch (mode)
            {
                case Mode.Minute:
                    return DateTime.Now.Minute.ToString();
                case Mode.Hour:
                    return DateTime.Now.Hour.ToString();
                case Mode.Date:
                    return DateTime.Now.ToLongDateString().ToString();
                case Mode.Second:
                    return DateTime.Now.Second.ToString();

                default:
                    throw new ArgumentOutOfRangeException("Your mode is not valid!");
            }

        }

    }
}
