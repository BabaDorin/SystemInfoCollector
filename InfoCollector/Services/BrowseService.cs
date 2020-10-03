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

            lbFeedback.Text = "Initialization...";
            Computer computer = Computer.GetInstance();

            lbFeedback.Text = "Looking for CPU =)";
            computer.CPU = CPU_Info.Info();

            lbFeedback.Text = "Looking for Storage devices (=";
            computer.Storage = Storage_Info.Info();

            lbFeedback.Text = "Looking for Motherboard =)";
            computer.Motherboard = Motherboard_Info.Info();

            lbFeedback.Text = "Looking for GPU (=";
            computer.GPU = GPU_Info.Info();

            return computer;
        }
    }
}
