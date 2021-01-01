using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCollector.Models
{
    class CPU
    {
        // TODO: Treat the case with multiple processors

        // Add L2CacheSize field
        // Add L3CacheSize field
        // Add ThreadCount field
        // Add MaxClockSpeed field
        // Add SocketDesignation field
        // Add UniqueId field
        // Add VirtualizationFirmwareEnabled field
        // Apparently, Processor does not have an unique ID.
        // ProcessorID will be the actual ProcessorID, concatenated with a GUID.

        public string Manufacturer { get; set; }
        public string Name { get; set; }

        private string architecture;
        public string Architecture { 
            
            get 
            {
                return architecture;
            }

            set
            {
                switch (value)
                {
                    case "0": architecture = "x86"; break;
                    case "1": architecture = "MIPS"; break;
                    case "2": architecture = "Alpha"; break;
                    case "3": architecture = "PowerPC"; break;
                    case "5": architecture = "ARM"; break;
                    case "6": architecture = "ia64"; break;
                    case "9": architecture = "x64"; break;
                    default: architecture = "unknown"; break;
                }
            }
        }
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
