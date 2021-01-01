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

namespace SystemInfoCollectorV2._0.Views
{
    public partial class StartView : UserControl
    {
        // We need only one instance of this class
        private static StartView instance;
        private StartView()
        {
            InitializeComponent();
        }

        public static StartView GetInstance()
        {
            if(instance == null)
            {
                instance = new StartView();
            }

            return instance;
        }

        private void btTest_Click(object sender, RoutedEventArgs e)
        {
            btTest.Content = "cf muian";
        }

        private void btTest2_Click(object sender, RoutedEventArgs e)
        {
            var MainWindow = (MainWindow)System.Windows.Application.Current.MainWindow;
            MainWindow.UpdateView("ViewUpdate");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btScan_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btIntroduceManually_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btViewUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btWriteFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
