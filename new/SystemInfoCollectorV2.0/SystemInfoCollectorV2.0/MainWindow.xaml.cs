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
            UpdateView("Start");

            EnterPSUSpecs enterPSUSpecs = new EnterPSUSpecs();
            enterPSUSpecs.Show();
        }

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
                default:
                    childWindow.Content = StartView.GetInstance();
                    break;
            }
        }
    }
}
