using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using InfoCollector.Models;
using InfoCollector.Services;
using InfoCollector.Services.BrowseMicroservices;
using System.Diagnostics;

namespace InfoCollector.Services
{
    class BrowseService
    {

        public static void CollectInformation(Label lbFeedback)
        {

            lbFeedback.Text = "Initialization...";
            Computer computer = Computer.GetInstanceCleaned();

            lbFeedback.Text = "Looking for some RAM info (=";
            computer.RAM = RAM_Info.Info();

            lbFeedback.Text = "Looking for CPU =)";
            computer.CPU = CPU_Info.Info();

            lbFeedback.Text = "Looking for Storage devices (=";
            computer.Storage = Storage_Info.Info();

            lbFeedback.Text = "Looking for Motherboard =)";
            computer.Motherboard = Motherboard_Info.Info();

            lbFeedback.Text = "Looking for GPU (=";
            computer.GPU = GPU_Info.Info();
        }
    }
}
