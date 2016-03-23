using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace RegimentOfFoot.Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _allowDirectNavigation = false;
        private NavigatingCancelEventArgs _navArgs = null;
        private Duration _duration = new Duration(TimeSpan.FromSeconds(1));
        private double _oldHeight = 0;
        private MainPage homePage = new MainPage();

        public MainWindow()
        {
            InitializeComponent();
            Populate();
            Application.Current.ShutdownMode = ShutdownMode.OnLastWindowClose;
        }

        private void Populate()
        {
            //Frame.Navigate(new MainPage());

        }

        private void Frame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (Content != null && !_allowDirectNavigation)
            {
                e.Cancel = true;

                _navArgs = e;
                _oldHeight = Frame.ActualHeight;

                var animation0 = new DoubleAnimation
                {
                    From = Frame.ActualHeight,
                    To = 0,
                    Duration = _duration
                };
                animation0.Completed += SlideCompleted;
                Frame.BeginAnimation(HeightProperty, animation0);
            }
            _allowDirectNavigation = false;
        }
        private void SlideCompleted(object sender, EventArgs e)
        {
            _allowDirectNavigation = true;
            switch (_navArgs.NavigationMode)
            {
                case NavigationMode.New:
                    if (_navArgs.Uri == null)
                        Frame.Navigate(_navArgs.Content);
                    else
                        Frame.Navigate(_navArgs.Uri);
                    break;
                case NavigationMode.Back:
                    Frame.GoBack();
                    break;
                case NavigationMode.Forward:
                    Frame.GoForward();
                    break;
                case NavigationMode.Refresh:
                    Frame.Refresh();
                    break;
            }

            Dispatcher.BeginInvoke(DispatcherPriority.Loaded,
                (ThreadStart)delegate ()
                {
                    var animation0 = new DoubleAnimation
                    {
                        From = 0,
                        To = _oldHeight,
                        Duration = _duration
                    };
                    Frame.BeginAnimation(HeightProperty, animation0);
                });
        }
    }

}
