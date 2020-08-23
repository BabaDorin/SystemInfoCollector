using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoCollector.Models;
using System.Management;

namespace InfoCollector.Services
{
    class CPU_Info
    {
        private static ManagementObjectSearcher CPUSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

        public static CPU Info()
        {
            CPU CPU = new CPU
            {
                Manufacturer = LookForCPUInfo("Manufacturer"),
                Architecture = LookForCPUInfo("Architecture"),
                Name = LookForCPUInfo("Name"),
                Status = LookForCPUInfo("Status"),
                Description = LookForCPUInfo("Description"),
                NumberOfCores = LookForCPUInfo("NumberOfCores"),
                ProcessorId = LookForCPUInfo("ProcessorId"),
            };

            return CPU;
        }

        private static string LookForCPUInfo(string whatToLookFor)
        {
            try
            {
                foreach (ManagementObject queryObj in CPUSearcher.Get())
                    return queryObj[whatToLookFor].ToString();
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
