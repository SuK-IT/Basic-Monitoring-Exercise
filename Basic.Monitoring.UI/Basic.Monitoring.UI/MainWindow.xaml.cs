using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;

using BasicMonitor.Data;

namespace Basic.Monitoring.UI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer updateInterface = new Timer(100);

        public MainWindow()
        {
            InitializeComponent();
            updateInterface.Elapsed += UpdateInterface_Elapsed;
            updateInterface.Start();
            this.Title = $"BasicMonitor - Monitoring: {OS.GetComputerName()}";
        }

        private void UpdateInterface_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                var procCounterQuery = $"Currently Running Processes: {Processes.GetRunningProcessesCount()}";
                processCounter.Dispatcher.Invoke(() =>
                {
                    processCounter.Content = procCounterQuery;

                });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{OS.GetComputerName()}");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            updateInterface.Stop();
        }
    }
}
