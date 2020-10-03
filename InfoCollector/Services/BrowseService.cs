using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using InfoCollector.Models;
using InfoCollector.Services;
using InfoCollector.Services.BrowseMicroservices;

namespace InfoCollector.Services
{
    class BrowseService
    {

        public static Computer CollectedInformation(Label lbFeedback)
        {
            GPU_Info.GetInfo();

            lbFeedback.Text = "Initialization...";
            Computer computer = Computer.GetInstance();

            lbFeedback.Text = "Hmm... Nice CPU over there";
            computer.CPU = CPU_Info.Info();

            lbFeedback.Text = "Let's check the disks (Don't worry, I won't open that 90GB homework folder)";
            computer.Storage = Storage_Info.Info();

            lbFeedback.Text = "Lemme get some info about your motherboard";
            computer.Motherboard = Motherboard_Info.Info();

            return computer;
        }
    }
}
