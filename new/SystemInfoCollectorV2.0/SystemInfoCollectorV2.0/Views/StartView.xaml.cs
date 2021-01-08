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
using SystemInfoCollectorV2._0.Models;

namespace SystemInfoCollectorV2._0.Views
{
    public partial class StartView : UserControl
    {

        // We need only one instance of this class
        private static StartView instance;
        private MainWindow _mainWindow;
        
        private StartView()
        {
            InitializeComponent();
            _mainWindow = (MainWindow)Application.Current.MainWindow;
        }

        public static StartView GetInstance()
        {
            if(instance == null)
            {
                instance = new StartView();
            }

            return instance;
        }


        private void btScan_Click(object sender, RoutedEventArgs e)
        {
            Computer computer = Computer.GetInstance();
            //computer.TestData();
            computer.RetrieveData();

           
        }

        private void btIntroduceManually_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btViewUpdate_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.UpdateView("ViewUpdate");
        }

        private void btWriteFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
