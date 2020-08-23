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

        public Computer CollectedInformation()
        {
            Computer computer = Computer.GetInstance();
            computer.CPU = CPU_Info.Info();
            computer.Storage = Storage_Info.Info();
            computer.OS = OS_Info.Info();
            computer.Motherboard = Motherboard_Info.Info();

            return computer;
        }
    }
}
