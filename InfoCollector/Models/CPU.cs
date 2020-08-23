using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCollector.Models
{
    class CPU
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Architecture { get; set; }
        public string NumberOfCores { get; set; }
        public string ProcessorId { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public string ShowInfo()
        {
            string info = "";
            info += "\nCPU Properties:";
            info += "\n-----------------";
            info += "\nName: " + Name;
            info += "\nArchitecture: " + Architecture;
            info += "\nNumberOfCores: " + NumberOfCores;
            info += "\nProcessorId: " + ProcessorId;
            info += "\nStatus: " + Status;
            info += "\nDescription: " + Description;

            return info;
        }
    }
}
