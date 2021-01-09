using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using SystemInfoCollectorV2._0.Views;

namespace SystemInfoCollectorV2._0
{
    public partial class MainWindow : Window
    {
        public List<CPU> CPUs { get; set; }
        public int intProperty { get; set; }
        public string stringProperty { get; set; }
        public float floatProperty { get; set; }
        public double doubleProperty { get; set; }
        public bool boolProperty { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            UpdateView("Info");
        }

        /// <summary>
        /// Updates the view according to the parameter. The paramenter is the view's name without the 'View' suffix,
        /// ex: Start for StartView.
        /// </summary>
        /// <param name="parameter"></param>
        public void UpdateView(string parameter)
        {
            switch (parameter)
            {
                case "Start":
                    childWindow.Content = StartView.GetInstance();
                    break;
                case "ViewUpdate":
                    childWindow.Content = new ViewUpdateView();
                    break;
                case "Info":
                    childWindow.Content = new InfoView();
                    break;
                case "Preferences":
                    childWindow.Content = new Preferences();
                    break;
                default:
                    childWindow.Content = StartView.GetInstance();
                    break;
            }
        }

        private void btHome_Click(object sender, RoutedEventArgs e)
        {
            UpdateView("Start");
        }

        private void btViewUpdate_Click(object sender, RoutedEventArgs e)
        {
            UpdateView("ViewUpdate");
        }

        private void btPreferences_Click(object sender, RoutedEventArgs e)
        {
            UpdateView("Preferences");
        }

        private void btInfo_Click(object sender, RoutedEventArgs e)
        {
            UpdateView("Info");
        }
    }
}
