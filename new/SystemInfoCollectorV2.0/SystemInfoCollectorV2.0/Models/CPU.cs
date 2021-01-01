using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoCollectorV2._0.Models
{
    class CPU : Device
    {
        private string architecture;

        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Architecture
        {

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
        public int NumberOfCores { get; set; }
        public string ProcessorId { get; set; }
        public string Description { get; set; }
        public int L2CacheSize { get; set; }
        public int L3CacheSize { get; set; }
        public int ThreadCount { get; set; }
        public int MaxClockSpeed { get; set; }
        public string SocketDesignation { get; set; }
        public bool VirtualizationFirmwareEnabled { get; set; }
    }
}
