using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfoCollector.Services;
using InfoCollector.Models;
using System.Diagnostics;

namespace InfoCollector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Center main controls
            btGetInfo.Left = this.Width / 2 - btGetInfo.Width / 2;
            lbFeedback.Left = this.Width / 2 - lbFeedback.Width / 2;
        }

        private void btGetInfo_Click(object sender, EventArgs e)
        {
            CollectorService collectorService = CollectorService.GetInstance();

            lbFeedback.Text = "Browsing...";
            collectorService.GetInfo(lbFeedback);

            if (!collectorService.WriteJsonFile())
                Debug.WriteLine("Unable to write the json file, maybe the file already exists in the destination folder.");
        }
    }
}
