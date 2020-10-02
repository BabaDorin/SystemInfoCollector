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
using InfoCollector.Forms;

namespace InfoCollector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Center main controls
            Center(btGetInfo);
            Center(lbFeedback);
            Center(tbPCTempName);
            Center(tbUnderline);
            Center(lbExport);
            btSeeModifyData.Left = this.Width / 2 - 20 - btSeeModifyData.Width;
            btContinue.Left = this.Width / 2 + 20;

            panelExport.Visible = false;
            btContinue.Enabled = false;
        }

        private void btGetInfo_Click(object sender, EventArgs e)
        {
            panelExport.Visible = false;

            CollectorService collectorService = CollectorService.GetInstance();

            lbFeedback.Text = "Browsing...";
            collectorService.GetInfo(lbFeedback);

            lbFeedback.Text = "Enter an unique name for this PC, check an export file type and press Continue. To generate folders, use /FolderName/ComputerName";

            panelExport.Visible = true;
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            CollectorService collectorService = CollectorService.GetInstance();
            collectorService.computerInstance.TempName = tbPCTempName.Text;

            if (rbText.Checked)
            {
                if (collectorService.WriteTextFile())
                {
                    lbFeedback.Text = "Success!";
                    panelExport.Visible = false;
                }
                else
                    lbFeedback.Text = "Unable to write the output file. Maybe there is an another PC with the same name in the destination directory.";

                return;
            }

            if (rbJSON.Checked)
            {
                if (collectorService.WriteJsonFile())
                {
                    lbFeedback.Text = "Success!";
                    panelExport.Visible = false;
                }
                else
                    lbFeedback.Text = "Unable to write the output file. Maybe there is an another PC with the same name in the destination directory.";

                return;
            }

            if (rbTestAndJSON.Checked)
            {
                if (collectorService.WriteTextAndJSONFiles())
                {
                    lbFeedback.Text = "Success!";
                    panelExport.Visible = false;
                }
                else
                    lbFeedback.Text = "Unable to write the output file. Maybe there is an another PC with the same name in the destination directory.";

                return;
            }
        }

        public void Center(Control control)
        {
            control.Left = this.Width / 2 - control.Width / 2;
        }

        private void tbPCTempName_TextChanged(object sender, EventArgs e)
        {
            if(tbPCTempName.Text != "")
                btContinue.Enabled = true;
            else
                btContinue.Enabled = false;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPCTempName.Text != "")
                btContinue.Enabled = true;
            else
                btContinue.Enabled = false;
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();

            settingsForm.ShowDialog();
        }

        private void btSeeModifyData_Click(object sender, EventArgs e)
        {
            // It opens a new form inside parent which will containg all the gathered information
            // about the system. Users will have read and write privillege.
            Computer computer = Computer.GetInstance();
            computer.TempName = tbPCTempName.Text;

            SeeModifyForm child = new SeeModifyForm(this);
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            this.Controls.Add(child);
            child.BringToFront();
            child.Show();

            TogglePanelExport();
        }

        public void TogglePanelExport()
        {
            panelExport.Visible = !panelExport.Visible;
        }
    }
}
