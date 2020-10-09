using InfoCollector.Forms;
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
        public static Panel LastHiddenPanel;
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
            if(panelExport.Visible == true)
                Computer.GetInstance().TempName = tbPCTempName.Text;

            if (rbText.Checked)
            {
                if (collectorService.WriteTextFile())
                {
                    lbFeedback.Text = "Success!";
                    HideActivePanel();
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
                    HideActivePanel();
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
                    HideActivePanel();
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
            DisplayPanelExport();
        }

        public void DisplayLastHiddenPanel()
        {
            LastHiddenPanel.Visible = true;
        }

        public void DisplayPanelExport()
        {
            LastHiddenPanel = panelExport;
            panelExport.Visible = true;
            panelIntroduceData.Visible = false;
        }

        public void HideActivePanel()
        {
            if (panelExport.Visible)
            {
                LastHiddenPanel = panelExport;
                panelExport.Visible = false;
                return;
            }

            if (panelIntroduceData.Visible)
            {
                LastHiddenPanel = panelExport;
                panelExport.Visible = false;
                return;
            }
        }

        public void DisplayPanelIntroduceData()
        {
            LastHiddenPanel = panelIntroduceData;
            panelIntroduceData.Visible = true;
            panelExport.Visible = false;
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
            Computer computer = Computer.GetInstanceCleaned();
            tbRAMChips.Enabled = tbDisks.Enabled = tbGPUs.Enabled = true;
            tbGPUs.Text = tbRAMChips.Text = tbDisks.Text = "";
            lbFeedback.Text = "Introduce data manually. Start by indicating the number of RAM Chips, Disks and GPUs";
        }

        private void tbRAMChips_TextChanged(object sender, EventArgs e)
        {
            RAMChipsValid = checkForValidity(tbRAMChips.Text.ToString());
            enableBtIntroduceIfOK();
        }

        private void btIntroduce_Click(object sender, EventArgs e)
        {
            Computer computer = Computer.GetInstance();
            if (tbDisks.Enabled)
            {
                computer.RAM = new RAM();
                computer.RAM.NumberOfRAMChips = int.Parse(tbRAMChips.Text.ToString());
                for (int i = 0; i < computer.RAM.NumberOfRAMChips; i++)
                {
                    computer.RAM.RAMChips.Add(new RAMDevice());
                }

                computer.Storage = new Storage();
                computer.Storage.NumberOfStorageDevices = int.Parse(tbDisks.Text.ToString());
                for (int i = 0; i < computer.Storage.NumberOfStorageDevices; i++)
                {
                    computer.Storage.StorageDevices.Add(new StorageDevice());
                }

                computer.GPU.NumberOfGPUs = int.Parse(tbGPUs.Text.ToString());
                for (int i = 0; i < computer.GPU.NumberOfGPUs; i++)
                {
                    computer.GPU.GPUDevices.Add(new GPUDevice());
                }

                tbDisks.Enabled = false;
                tbGPUs.Enabled = false;
                tbRAMChips.Enabled = false;
            }

            SeeModifyForm child = new SeeModifyForm(this);
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            this.Controls.Add(child);
            child.BringToFront();
            child.Show();
            DisplayPanelIntroduceData();
        }

        private void btGetInfo_MouseEnter(object sender, EventArgs e)
        {
            lbScan.Visible = true;
        }

        private void btGetInfo_MouseLeave(object sender, EventArgs e)
        {
            lbScan.Visible = false;
        }

        private void btIntroduceData_MouseEnter(object sender, EventArgs e)
        {
            lbIDM.Visible = true;
        }

        private void btIntroduceData_MouseLeave(object sender, EventArgs e)
        {
            lbIDM.Visible = false;
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
