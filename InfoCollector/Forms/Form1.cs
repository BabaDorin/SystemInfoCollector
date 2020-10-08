﻿using InfoCollector.Forms;
using InfoCollector.Models;
using InfoCollector.Services;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace InfoCollector
{
    public partial class Form1 : Form
    {
        private bool RAMChipsValid, DisksValid, GPUsValid;
        public Form1()
        {
            InitializeComponent();

            // Center main controls
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
            panelIntroduceData.Visible = false;

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
            if (tbPCTempName.Text != "")
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

        private void tbDisks_TextChanged(object sender, EventArgs e)
        {
            DisksValid = checkForValidity(tbDisks.Text.ToString());
            enableBtIntroduceIfOK();
        }

        private void tbGPUs_TextChanged(object sender, EventArgs e)
        {
            GPUsValid = checkForValidity(tbGPUs.Text.ToString());
            enableBtIntroduceIfOK();
        }

        private void btIntroduceData_Click(object sender, EventArgs e)
        {
            panelExport.Visible = false;
            panelIntroduceData.Visible = true;
        }

        private void tbRAMChips_TextChanged(object sender, EventArgs e)
        {
            RAMChipsValid = checkForValidity(tbRAMChips.Text.ToString());
            enableBtIntroduceIfOK();
        }

        private bool checkForValidity(string input)
        {
            bool validInput;
            try
            {
                int n = int.Parse(input);
                if (n > 0 && n < 10)
                    validInput = true;
                else
                    validInput = false;
            }
            catch (Exception)
            {
                validInput = false;
            }

            return validInput;
        }
        
        private void enableBtIntroduceIfOK()
        {
            if (DisksValid && RAMChipsValid && GPUsValid)
                btIntroduce.Enabled = true;
            else
                btIntroduce.Enabled = false;
        }
    }
}
