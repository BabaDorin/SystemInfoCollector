using InfoCollector.Models;
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
            units.Add(new Unit { Identifier = "TempName", Value = computer.TempName});
            
            // CPU
            units.Add(new Unit { Identifier = "CPU", isTitle = true});
            units.Add(new Unit { Identifier = "Manufacturer", Value = computer.CPU.Manufacturer });
            units.Add(new Unit { Identifier = "Name", Value = computer.CPU.Name });
            units.Add(new Unit { Identifier = "Architecture", Value = computer.CPU.Architecture });
            units.Add(new Unit { Identifier = "Number of Cores", Value = computer.CPU.NumberOfCores });
            units.Add(new Unit { Identifier = "ProcessorId", Value = computer.CPU.ProcessorId });
            units.Add(new Unit { Identifier = "Status", Value = computer.CPU.Status });
            units.Add(new Unit { Identifier = "Description", Value = computer.CPU.Description });


            for(int i = units.Count - 1; i >= 0; i--)
            {
                DisplayUnit(units[i].Identifier, units[i].Value, units[i].isTitle);
            }
        }

        private void DisplayUnit(string label, string value, bool isTitle)
        {
            Panel unitPanel = new Panel();
            unitPanel.Dock = DockStyle.Top;
            unitPanel.Height = 55;

            // ex: ComputerID
            Label unitIndentifier = new Label();
            unitIndentifier.Text = label;
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

            unitPanel.Controls.Add(unitValue);
            unitPanel.Controls.Add(unitIndentifier);
            
            panelData.Controls.Add(unitPanel);
        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            parentInstance.TogglePanelExport();
            this.Dispose();
        }
    }
}
