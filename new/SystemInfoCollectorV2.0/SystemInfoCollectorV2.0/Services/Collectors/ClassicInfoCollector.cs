using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO;
using System.Diagnostics;
using SystemInfoCollectorV2._0.Models;

namespace SystemInfoCollectorV2._0.Services.Collectors
{
    class ClassicInfoCollector
    {
        private struct Searcher
        {
            public Type Type;
            public string SearcherClass;
        }

        private static List<Searcher> Searchers = new List<Searcher>
        {
            new Searcher
            {
                Type = typeof(CPU),
                SearcherClass = "Win32_Processor"
            },

            new Searcher
            {
                Type = typeof(GPU),
                SearcherClass = "Win32_VideoController"
            },

            new Searcher
            {
                Type = typeof(Storage),
                SearcherClass = "Win32_DiskDrive"
            },

            new Searcher
            {
                Type = typeof(RAM),
                SearcherClass = "Win32_PhysicalMemory"
            },
        };

        public static List<T> GetInfo<T>(List<T> initialListOfDevices)
        {
            var listOfDevices = new List<T>();
            string searcherClass = Searchers.First(s => s.Type == typeof(T)).SearcherClass;

            if (searcherClass == null)
                throw new Exception("No searcher class found for type");

            ManagementObjectSearcher ObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", $"SELECT * FROM {searcherClass}");

            try
            {
                foreach (ManagementObject managementObject in ObjectSearcher.Get())
                {
                    var device = Activator.CreateInstance<T>();

                    foreach (var deviceProperty in device.GetType().GetProperties())
                    {
                        var propValue = managementObject[deviceProperty.Name];
                        string finalPropValue = (propValue == null) ? "" : propValue.ToString();

                        deviceProperty.SetValue(device, finalPropValue);
                    }

                    listOfDevices.Add(device);
                }
            }
            catch (Exception)
            {
                throw new Exception($"There are property names in {typeof(T)} which don't match with " +
                    $"property names from {searcherClass} class");
            }
            
            return listOfDevices;
        }
    }
}
