using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoCollectorV2._0.Models
{
    public class CPU : Device
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

        public void TestData()
        {
            Manufacturer = "Test Manufacturer";
            Name = "Test Name";
            architecture = "Test Architecture";
            ProcessorId = "Test ProcessorId";
            Description = "Test Description";
            SocketDesignation = "Test SocketDesignation";
            NumberOfCores = 234;
            L2CacheSize = 234;
            L3CacheSize = 234;
            ThreadCount = 234;
            MaxClockSpeed = 234;
            VirtualizationFirmwareEnabled = true;
        }
    }
}
