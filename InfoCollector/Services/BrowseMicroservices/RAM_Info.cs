using InfoCollector.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace InfoCollector.Services.BrowseMicroservices
{
    class RAM_Info
    {
        private static ManagementObjectSearcher RAMSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");

        public static RAM Info()
        {
            // ADD RamDevice class, add RamDevices to RAM, retrieve info about ram chips.
            RAM RAM = new RAM
            {
                NumberOfRAMChips = RAMSearcher.Get().Count,
            };

            try
            {
                foreach (ManagementObject queryObj in RAMSearcher.Get())
                {
                    Debug.WriteLine(queryObj);
                }
            }
            catch (Exception)
            {
                Debug.Write("Error");
            }

            return RAM;
        }

        private static string LookForRAMInfo(string whatToLookFor)
        {
            return Searcher.LookForInformation(whatToLookFor, RAMSearcher);
        }
    }
}
