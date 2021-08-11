using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using SystemInfoCollectorV2._0.Models;

namespace SystemInfoCollectorV2._0.Services.Collectors
{
    static class MotherboardInfoCollector
    {
        public static List<Motherboard> GetInfo()
        {
            ManagementObjectSearcher baseboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
            ManagementObjectSearcher motherboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_MotherboardDevice");
            ManagementObjectSearcher biosSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            var list = new List<Motherboard>();
            Motherboard motherboard = new Motherboard();

            SearchInfo(baseboardSearcher, ref motherboard);
            SearchInfo(motherboardSearcher, ref motherboard);
            SearchInfo(biosSearcher, ref motherboard);

            list.Add(motherboard);
            return list;
        }

        private static void SearchInfo(ManagementObjectSearcher searcher, ref Motherboard motherboard)
        {
            foreach (ManagementObject managementObject in searcher.Get())
            {
                foreach (var deviceProperty in motherboard.GetType().GetProperties())
                {
                    var currentPropValue = deviceProperty.GetValue(motherboard);
                    if (currentPropValue != null && currentPropValue.ToString().Trim()!="")
                        continue;

                    object propValue = null;
                    try
                    {
                        propValue = managementObject[deviceProperty.Name];
                    }
                    catch (Exception)
                    {
                        // Not found - The property has not been found in this searcher class. propValue will remain null, it's OK.
                    }
                    string finalPropValue = (propValue == null) ? "" : propValue.ToString();
                    deviceProperty.SetValue(motherboard, finalPropValue);
                }
            }
        }
    }
}
