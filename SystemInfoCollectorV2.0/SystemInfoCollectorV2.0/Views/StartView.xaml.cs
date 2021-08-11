using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using SystemInfoCollectorV2._0.Models;

namespace SystemInfoCollectorV2._0.Views
{
    public partial class StartView : UserControl, INotifyPropertyChanged
    {
        private Visibility usedVisibility;

        public Visibility UsedVisibility
        {
            get { return usedVisibility; }
            set { usedVisibility = value; NotifyPropertyChanged("UsedVisibility"); }
        }

        private Visibility notUsedVisibility;

        public Visibility NotUsedVisibility
        {
            get { return notUsedVisibility; }
            set { notUsedVisibility = value; NotifyPropertyChanged("NotUsedVisibility"); }
        }

        private Visibility workingVisibility;

        public Visibility WorkingVisibility
        {
            get { return workingVisibility; }
            set { workingVisibility = value; NotifyPropertyChanged("WorkingVisibility"); }
        }

        private Visibility notWorkingVisibility;

        public Visibility NotWorkingVisibility
        {
            get { return notWorkingVisibility; }
            set { notWorkingVisibility = value; NotifyPropertyChanged("NotWorkingVisibility"); }
        }

        // We need only one instance of this class
        private static StartView instance;
        private MainWindow _mainWindow;
        private Computer _computer = Computer.GetInstance();


        private StartView()
        {
            InitializeComponent();
            _mainWindow = (MainWindow)Application.Current.MainWindow;
            this.DataContext = this;
            
            WorkingVisibility = Visibility.Visible;
            NotWorkingVisibility = Visibility.Hidden;
            UsedVisibility = Visibility.Visible;
            NotUsedVisibility = Visibility.Hidden;
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
                btScanContent.Text = "Scanare...";
                new Thread(() =>
                {
                    _computer.RetrieveData();
                    Application.Current.Dispatcher.Invoke(() => 
                    {
                        btScanContent.Text = "Rezultatele pot fi vizualizate" + Environment.NewLine + "Click pentru a scana din nou";
                        btScan.IsEnabled = true;
                    });
                }).Start();
            }
            catch (Exception ex)
            {
                btScan.Content = "S-a produs o eroare la scanarea datelor";
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
            _computer.Identifier = tbPCIdentifier.Text.Trim();
            _computer.TeamViewerID = tbTVID.Text.Trim();
            _computer.TeamViewerPassword = tbTVPassword.Text.Trim();
            _computer.Description = tbDescription.Text.Trim();

            if (_computer.TEMSID == "")
            {
                var Result = MessageBox.Show("N-au fost indicate valori pentru TEMSID. Doriti sa continuati?", ";(", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

                if (Result == MessageBoxResult.No || Result == MessageBoxResult.Cancel)
                    return;
            }

            JSONSerializer.Serialize();
        }

        private void btUsed_Click(object sender, RoutedEventArgs e)
        {
            _computer.IsUsed = Convert.ToBoolean((sender as Button).Tag.ToString());

            if (_computer.IsUsed)
            {
                UsedVisibility = Visibility.Visible;
                NotUsedVisibility = Visibility.Hidden;
                return;
            }

            UsedVisibility = Visibility.Hidden;
            NotUsedVisibility = Visibility.Visible;
        }

        private void btWorking_Click(object sender, RoutedEventArgs e)
        {
            _computer.Working = Convert.ToBoolean((sender as Button).Tag.ToString());

            if (_computer.Working)
            {
                WorkingVisibility = Visibility.Visible;
                NotWorkingVisibility = Visibility.Hidden;
                return;
            }

            WorkingVisibility = Visibility.Hidden;
            NotWorkingVisibility = Visibility.Visible;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}