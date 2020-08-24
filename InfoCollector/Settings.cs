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
        public Settings()
        {
            InitializeComponent();
        }

        private void btBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if(browserDialog.ShowDialog() == DialogResult.OK)
            {
                //Properties.Settings.Default.
                //Properties.Settings.Path = browserDialog.SelectedPath;
                //Properties.Settings.sa
                //tbPath.Text = browserDialog.SelectedPath;
            }
        }
    }
}
