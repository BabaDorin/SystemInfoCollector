using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SystemInfoCollectorV2._0.Models;

namespace SystemInfoCollectorV2._0.Views
{
    public partial class StartView : UserControl
    {

        // We need only one instance of this class
        private static StartView instance;
        private MainWindow _mainWindow;
        private Computer _computer = Computer.GetInstance();

        private StartView()
        {
            InitializeComponent();
            _mainWindow = (MainWindow)Application.Current.MainWindow;
        }

        public static StartView GetInstance()
        {
            if (instance == null)
            {
                instance = new StartView();
            }

            return instance;
        }


        private void btScan_Click(object sender, RoutedEventArgs e)
        {
            // Starts a new thead which will collect information about the computer.
            try
            {
                btScan.IsEnabled = false;
                btScanContent.Text = "Scanning...";
                new Thread(() =>
                {
                    _computer.RetrieveData();
                    Application.Current.Dispatcher.Invoke((Action)delegate
                    {
                        btScanContent.Text = "See results on View / Update page" + Environment.NewLine + "Click to start scanning again";
                        btScan.IsEnabled = true;
                    });
                }).Start();
            }
            catch (Exception ex)
            {
                btScan.Content = "An unknown error happened when looking for data.";
                Debug.WriteLine("Error in btScan.Click: " + ex.Message);
                return;
            }
        }

        private void btViewUpdate_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.UpdateView("ViewUpdate");
        }

        private void btWriteFile_Click(object sender, RoutedEventArgs e)
        {
            _computer.TEMSID = tbTEMSID.Text.Trim();
            _computer.Room = tbRoom.Text.Trim();
            _computer.Identifier = tbPCIdentifier.Text.Trim();
            _computer.TeamViewerID = tbTVID.Text.Trim();
            _computer.TeamViewerPassword = tbTVPassword.Text.Trim();
            _computer.Description = tbDescription.Text.Trim();

            if (_computer.TEMSID == "" || _computer.Room == "")
            {
                var Result = MessageBox.Show("N-au fost indicate valori pentru TEMSID si numarul salii. Doriti sa continuati?", ";(", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

                if (Result == MessageBoxResult.No || Result == MessageBoxResult.Cancel)
                    return;
            }

            JSONSerializer.Serialize();
        }
    }
}