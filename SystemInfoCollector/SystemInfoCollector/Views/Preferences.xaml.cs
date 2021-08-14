using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using SystemInfoCollector.Properties;

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
            using (FolderBrowserDialog browserDialog = new FolderBrowserDialog())
            {
                if (browserDialog.ShowDialog() == DialogResult.OK)
                {
                    tbOutputPath.Text = browserDialog.SelectedPath;
                }
            }
        }
    }
}
