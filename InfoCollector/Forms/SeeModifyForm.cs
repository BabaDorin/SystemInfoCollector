using InfoCollector.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoCollector.Forms
{
    public partial class SeeModifyForm : Form
    {
        struct Unit
        {
            public string Identifier;
            public string Value;
            public bool isTitle;
        }

        private Form1 parentInstance;

        public SeeModifyForm(Form1 parent)
        {
            this.parentInstance = parent;
            InitializeComponent();
            label1.Left = this.Width / 2 - label1.Width / 2;

            DisplayData();
        }

        private void DisplayData()
        {
            Computer computer = Computer.GetInstance();
            List<Unit> units = new List<Unit>();

            // General information
            units.Add(new Unit { Identifier = "ComputerId", Value = computer.ComputerID });
            units.Add(new Unit { Identifier = "TempName", Value = computer.TempName });

            // CPU
            units.Add(new Unit { Identifier = "CPU", isTitle = true });
            units.Add(new Unit { Identifier = "CPUManufacturer", Value = computer.CPU.Manufacturer });
            units.Add(new Unit { Identifier = "CPUName", Value = computer.CPU.Name });
            units.Add(new Unit { Identifier = "CPUArchitecture", Value = computer.CPU.Architecture });
            units.Add(new Unit { Identifier = "NumberOfCores", Value = computer.CPU.NumberOfCores });
            units.Add(new Unit { Identifier = "ProcessorId", Value = computer.CPU.ProcessorId });
            units.Add(new Unit { Identifier = "CPUStatus", Value = computer.CPU.Status });
            units.Add(new Unit { Identifier = "CPUDescription", Value = computer.CPU.Description });

            // STORAGE
            units.Add(new Unit { Identifier = "Storage", isTitle = true });
            units.Add(new Unit { Identifier = "NumberOfStorageDevices", Value = computer.Storage.NumberOfStorageDevices.ToString() });
            int counter = 1;
            foreach (StorageDevice storageDevice in computer.Storage.StorageDevices)
            {
                units.Add(new Unit { Identifier = "Storage device " + counter, isTitle = true });
                units.Add(new Unit { Identifier = "st_" + counter + "_DeviceId", Value = storageDevice.DeviceId });
                units.Add(new Unit { Identifier = "st_" + counter + "_Capacity", Value = storageDevice.Capacity });
                units.Add(new Unit { Identifier = "st_" + counter + "_Type", Value = storageDevice.Type });
                units.Add(new Unit { Identifier = "st_" + counter + "_SerialNumber", Value = storageDevice.SerialNumber });
                counter++;
            }

            // MOTHERBOARD
            units.Add(new Unit { Identifier = "Motherboard", isTitle = true });
            units.Add(new Unit { Identifier = "MotherboardManufacturer", Value = computer.Motherboard.Manufacturer });
            units.Add(new Unit { Identifier = "Product", Value = computer.Motherboard.Product });
            units.Add(new Unit { Identifier = "MotherboardSerialNumber", Value = computer.Motherboard.SerialNumber });
            units.Add(new Unit { Identifier = "MotherboardStatus", Value = computer.Motherboard.Status });
            units.Add(new Unit { Identifier = "BIOSManufacturer", Value = computer.Motherboard.BIOSManufacturer });
            units.Add(new Unit { Identifier = "BIOSSerialNumber", Value = computer.Motherboard.BIOSSerialNumber });

            for (int i = units.Count - 1; i >= 0; i--)
            {
                DisplayUnit(units[i].Identifier, units[i].Value, units[i].isTitle);
            }
        }

        private void DisplayUnit(string identifier, string value, bool isTitle)
        {
            Panel unitPanel = new Panel();
            unitPanel.Dock = DockStyle.Top;
            unitPanel.Height = 55;

            // ex: ComputerID
            Label unitIndentifier = new Label();
            unitIndentifier.Text = identifier;
            unitIndentifier.Font = (isTitle) ? new Font("Tahoma", 13, FontStyle.Bold) : new Font("Tahoma", 10, FontStyle.Bold);
            unitIndentifier.Dock = DockStyle.Top;
            unitIndentifier.TextAlign = ContentAlignment.MiddleCenter;
            unitIndentifier.Height = 20;

            if (isTitle)
            {
                unitIndentifier.Dock = DockStyle.Fill;
                unitPanel.Controls.Add(unitIndentifier);
                panelData.Controls.Add(unitPanel);
                return;
            }

            // ex: L23002X
            TextBox unitValue = new TextBox();
            unitValue.Dock = DockStyle.Top;
            unitValue.Text = value;
            unitValue.Font = new Font("Tahoma", 10);
            unitValue.BackColor = Color.FromArgb(23, 37, 42);
            unitValue.ForeColor = Color.FromArgb(222, 242, 241);
            unitValue.TextAlign = HorizontalAlignment.Center;
            unitValue.BackColor = Color.FromArgb(23, 37, 42);
            unitValue.BorderStyle = BorderStyle.None;
            unitValue.Name = identifier;

            unitPanel.Controls.Add(unitValue);
            unitPanel.Controls.Add(unitIndentifier);

            panelData.Controls.Add(unitPanel);
        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            parentInstance.TogglePanelExport();
            this.Dispose();
        }

        private void btExitSavingChanges_Click(object sender, EventArgs e)
        {
            Computer computer = Computer.GetInstance();

            try
            {
                computer.ComputerID = getTextBoxValue("ComputerID");
                computer.TempName = getTextBoxValue("TempName");

                computer.CPU.Manufacturer = getTextBoxValue("CPUManufacturer");
                computer.CPU.Name = getTextBoxValue("CPUName");
                computer.CPU.NumberOfCores = getTextBoxValue("NumberOfCores");
                computer.CPU.ProcessorId = getTextBoxValue("ProcessorId");
                computer.CPU.Architecture = getTextBoxValue("CPUArchitecture");
                computer.CPU.ProcessorId = getTextBoxValue("ProcessorId");
                computer.CPU.Status = getTextBoxValue("CPUStatus");
                computer.CPU.Description = getTextBoxValue("CPUDescription");

                computer.Storage.NumberOfStorageDevices = int.Parse(getTextBoxValue("NumberOfStorageDevices"));
                for(int i = 1; i <= computer.Storage.NumberOfStorageDevices; i++)
                {
                    computer.Storage.StorageDevices[i-1].DeviceId = getTextBoxValue("st_" + i + "_DeviceId");
                    computer.Storage.StorageDevices[i-1].Capacity = getTextBoxValue("st_" + i + "_Capacity");
                    computer.Storage.StorageDevices[i-1].Type = getTextBoxValue("st_" + i + "_Type");
                    computer.Storage.StorageDevices[i-1].SerialNumber = getTextBoxValue("st_" + i + "_SerialNumber");
                }

                computer.Motherboard.Manufacturer = getTextBoxValue("MotherboardManufacturer");
                computer.Motherboard.Product = getTextBoxValue("Product");
                computer.Motherboard.SerialNumber = getTextBoxValue("MotherboardSerialNumber");
                computer.Motherboard.Status = getTextBoxValue("MotherboardStatus");
                computer.Motherboard.BIOSManufacturer = getTextBoxValue("BIOSManufacturer");
                computer.Motherboard.BIOSSerialNumber = getTextBoxValue("BIOSSerialNumber");

                parentInstance.TogglePanelExport();
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error, lol");
            }
        }

        private string getTextBoxValue(string textBoxName)
        {
            Control tb = this.Controls.Find(textBoxName, true).FirstOrDefault();
            return tb.Text.ToString();
        }
    }
}
