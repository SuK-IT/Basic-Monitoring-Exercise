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
        private Timer updateInterface = new Timer(1);

        public MainWindow()
        {
            InitializeComponent();
            updateInterface.Elapsed += UpdateInterface_Elapsed;
            updateInterface.Start();
        }

        private void UpdateInterface_Elapsed(object sender, ElapsedEventArgs e)
        {
            processCounter.Dispatcher.Invoke(() => {

                processCounter.Content = $"Currently Running Processes: {Processes.GetRunningProcessesCount()}";
            
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Currently Running Processes: {Processes.GetRunningProcessesCount()}");
        }
    }
}
