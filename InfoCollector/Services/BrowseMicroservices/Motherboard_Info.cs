using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoCollector.Models;
using System.Management;
using System.Diagnostics;

namespace InfoCollector.Services
{
    class Motherboard_Info
    {
        private static ManagementObjectSearcher baseboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
        private static ManagementObjectSearcher motherboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_MotherboardDevice");
        private static ManagementObjectSearcher biosSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

        public static Motherboard Info()
        {
            Motherboard motherboard = new Motherboard
            {
                Manufacturer = LookForMotherboardInfo("Manufacturer"),
                Product = LookForMotherboardInfo("Product"),
                SerialNumber = LookForMotherboardInfo("SerialNumber"),
                Status = LookForMotherboardInfo("Status"),

                BIOSManufacturer = LookForBIOSInfo("Manufacturer"),
                BIOSSerialNumber = LookForBIOSInfo("SerialNumber"),
            };

            return motherboard;
        }

        private static string LookForMotherboardInfo(string whatToLookFor)
        {
            string result = LookForInformation(whatToLookFor, baseboardSearcher);
            if (result == null)
                result = LookForInformation(whatToLookFor, motherboardSearcher);

            return result;
        }

        private static string LookForBIOSInfo(string whatToLookFor)
        {
            return LookForInformation(whatToLookFor, biosSearcher);
        }

        private static string LookForInformation(string whatToLookFor, ManagementObjectSearcher whereToLookFor)
        {
            try
            {
                foreach (ManagementObject queryObj in whereToLookFor.Get())
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
