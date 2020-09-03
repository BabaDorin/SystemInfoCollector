using InfoCollector.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoCollector
{
    public partial class Settings : Form
    {
        private UserSettings userSettings = UserSettings.GetInstance();
        public Settings()
        {
            InitializeComponent();

            label1.Visible = false;
            tbPath.Text = userSettings.OutputPath;
        }

        private void btBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if(browserDialog.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = browserDialog.SelectedPath;
                label1.Visible = false;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            userSettings.OutputPath = tbPath.Text;
            userSettings.Save();
        }
    }
}
