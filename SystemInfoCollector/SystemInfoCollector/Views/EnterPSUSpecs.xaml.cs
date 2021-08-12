using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SystemInfoCollector.Models;

namespace SystemInfoCollector.Views
{
    public partial class EnterPSUSpecs : Window
    {
        private static Regex serialNumberRegex = new Regex(@"^[a-zA-Z0-9]+$");

        public EnterPSUSpecs()
        {
            InitializeComponent();
        }

        private void tbSerialNumber_KeyDown(object sender, KeyEventArgs e)
        {
            // No spaces allowed
            if (e.Key == Key.Space)
                e.Handled = false;
        }

        private void tbSerialNumber_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // No spaces allowed
            e.Handled = (e.Key == Key.Space);

            base.OnPreviewKeyDown(e);
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            SaveData();

            this.Close();
        }

        /// <summary>
        /// Create an instance of PSU having provided by user values and inserts it into
        /// computer's list of PSUs
        /// </summary>
        private void SaveData()
        {
            Computer computer = Computer.GetInstance();
            computer.PSUs.Add(new PSU
            {
                SerialNumber = tbSerialNumber.Text.Trim().ToString().ToUpper(),
                Model = tbModel.Text.Trim().ToString().ToUpper(),
                MaxOutputWattage = tbMaxWattage.Text.Trim().ToString()
            });
        }
    }
}
