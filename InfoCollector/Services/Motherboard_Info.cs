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
        public static Motherboard Info()
        {
            Motherboard motherboard = new Motherboard
            {
                Manufacturer = LookForMotherboardInfo("Manufacturer"),
                Product = LookForMotherboardInfo("Product"),
                SerialNumber = LookForMotherboardInfo("SerialNumber"),
                Status = LookForMotherboardInfo("Status"),
                SystemName = LookForMotherboardInfo("SystemName"),

                BIOSManufacturer = LookForBIOSInfo("Manufacturer"),
                BIOSSerialNumber = LookForBIOSInfo("SerialNumber"),
            };
            return motherboard;
        }

        private static ManagementObjectSearcher baseboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
        private static ManagementObjectSearcher motherboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_MotherboardDevice");
        private static ManagementObjectSearcher biosSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

        private static string LookForMotherboardInfo(string whatToLookFor)
        {
            string result = LookInBaseboard(whatToLookFor);
            if (result == null)
                result = LookInMotherboard(whatToLookFor);

            return result;
        }

        private static string LookInBaseboard(string whatToLookFor)
        {
            try
            {
                foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    return queryObj[whatToLookFor].ToString();
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static string LookInMotherboard(string whatToLookFor)
        {
            try
            {
                foreach (ManagementObject queryObj in motherboardSearcher.Get())
                    return queryObj[whatToLookFor].ToString();
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static string LookForBIOSInfo(string whatToLookFor)
        {
            try
            {
                foreach (ManagementObject queryObj in biosSearcher.Get())
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
