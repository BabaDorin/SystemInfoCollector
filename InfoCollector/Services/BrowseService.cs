using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoCollector.Models;
using InfoCollector.Services;

namespace InfoCollector.Services
{
    class BrowseService
    {
        // It browses the computer to find relevant information.

        public Computer CollectedInformation()
        {
            Computer computer = new Computer();
            computer.CPU = CPU_Info.Info();
            computer.Storage = Storage_Info.Info();
            computer.OS = OS_Info.Info();
            return new Computer();
        }

        private void GeneralInfo()
        {
            // Looks for general info about the computer, like manufacturer, model etc.

        }
    }
}
