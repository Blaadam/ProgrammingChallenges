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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Timers;
using Timer = System.Timers.Timer;

namespace Challenge14
{
    /// <summary>
    /// Interaction logic for LoadingScreen.xaml
    /// </summary>
    public partial class LoadingScreen : Window
    {
        Timer LoadingTimer;
        public LoadingScreen()
        {
            InitializeComponent();

            LoadingTimer = new Timer(50);
            LoadingTimer.Elapsed += new ElapsedEventHandler(TimerTick);
            LoadingTimer.Start();
        }


        private void TimerTick(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, (Action)(() =>
            {
                if (PBar.Value >= 100) {
                    LoadingTimer.Stop();

                    MainWindow window = new MainWindow();
                    this.Close();
                    window.ShowDialog();

                    return;
                }

                PBar.Value += 1;
                PercentageDisplay.Text = $"{PBar.Value.ToString()}%";
            }));
        }
    }
}
