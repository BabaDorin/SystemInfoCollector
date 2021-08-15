using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using SystemInfoCollector.Models;

namespace SystemInfoCollector.Services.Collectors
{
    static class ClassicInfoCollector
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

            new Searcher
            {
                Type = typeof(Monitor),
                SearcherClass = "Win32_DesktopMonitor"
            },
        };

        /// <summary>
        /// Returns a list containing objects along with info that have been gathered about them, according to 
        /// objects properties.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="initialListOfDevices"></param>
        /// <returns></returns>
        public static List<T> GetInfo<T>(List<T> initialListOfDevices)
        {
            var listOfDevices = new List<T>();
            string searcherClass = Searchers.First(s => s.Type == typeof(T)).SearcherClass;

            if (searcherClass == null)
                throw new Exception("No searcher class found for type");

            ManagementObjectSearcher ObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", $"SELECT * FROM {searcherClass}");

            foreach (ManagementObject managementObject in ObjectSearcher.Get())
            {
                var device = Activator.CreateInstance<T>();
                foreach (var deviceProperty in device.GetType().GetProperties())
                {
                    try
                    {
                        var propValue = managementObject[deviceProperty.Name];
                        string finalPropValue = propValue?.ToString() ?? "";

                        deviceProperty.SetValue(device, finalPropValue);
                    }
                    catch (Exception)
                    {
                        deviceProperty.SetValue(device, "");
                    }
                }

                listOfDevices.Add(device);
            }

            return listOfDevices;
        }
    }
}
