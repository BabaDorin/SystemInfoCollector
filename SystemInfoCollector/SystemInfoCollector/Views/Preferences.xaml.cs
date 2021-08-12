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
using System.IO;
using SystemInfoCollector.Properties;
using Microsoft.Win32;
using System.Windows.Forms;

namespace SystemInfoCollector.Views
{
    public partial class Preferences : System.Windows.Controls.UserControl
    {
        private UserSettings userSettings;
        public Preferences()
        {
            InitializeComponent();

            userSettings = UserSettings.GetInstance();

            var outputPath = userSettings.OutputPath;

            if(outputPath == null || outputPath == "")
                outputPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            tbOutputPath.Text = outputPath;

            btSaveChanges.IsEnabled = false;
        }

        private void btSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            userSettings.OutputPath = tbOutputPath.Text.Trim();
            userSettings.Save();

            btSaveChanges.IsEnabled = false;
        }

        private void tbOutputPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            btSaveChanges.IsEnabled = true;
        }

        private void btBrowse_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                tbOutputPath.Text = browserDialog.SelectedPath;
            }
        }
    }
}
