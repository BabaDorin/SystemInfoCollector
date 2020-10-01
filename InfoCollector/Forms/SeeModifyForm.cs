using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoCollector.Forms
{
    public partial class SeeModifyForm : Form
    {
        private Form1 parentInstance;
        public SeeModifyForm(Form1 parent)
        {
            this.parentInstance = parent;
            InitializeComponent();
            label1.Left = this.Width / 2 - label1.Width / 2;
        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            parentInstance.TogglePanelExport();
            this.Close();
        }
    }
}
