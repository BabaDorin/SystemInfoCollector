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
    public partial class ViewUpdateView : UserControl
    {
        private MainWindow _mainWindow;
        public ViewUpdateView()
        {
            InitializeComponent();

            _mainWindow = (MainWindow)Application.Current.MainWindow;
        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.UpdateView("Start");
        }
    }
}
