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
        private static ManagementObjectSearcher RAMSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");

        public static RAM Info()
        {
            RAM RAM = new RAM
            {
                NumberOfRAMChips = RAMSearcher.Get().Count,
            };

            try
            {
                foreach (ManagementObject queryObj in RAMSearcher.Get())
                {

                    RAMDevice RAMDevice = new RAMDevice
                    {
                        Manufacturer = queryObj["Manufacturer"].ToString(),
                        Type = getRAMTypeByIdentifier(queryObj["SMBIOSMemoryType"].ToString()),
                        SerialNumber = queryObj["SerialNumber"].ToString(),
                        Amount = queryObj["Capacity"].ToString()
                    };

                    RAM.RAMChips.Add(RAMDevice);
                }
            }
            catch (Exception)
            {
                Debug.Write("Error thrown in RAM_Info");
            }

            return RAM;
        }

        private static string LookForRAMInfo(string whatToLookFor)
        {
            return Searcher.LookForInformation(whatToLookFor, RAMSearcher);
        }

        private static string getRAMTypeByIdentifier(string identifier)
        {
            switch (identifier)
            {
                case "0": return "Unknown";
                case "1": return "Other";
                case "2": return "DRAM";
                case "20": return "DDR";
                case "21": return "DDR2";
                case "24": return "DDR3";
                case "26": return "DDR4";
                default: return identifier;
            }
        }
    }
}
