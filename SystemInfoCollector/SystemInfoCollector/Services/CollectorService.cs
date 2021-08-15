using System;
using System.Collections.Generic;
using SystemInfoCollector.Models;
using SystemInfoCollector.Services.Collectors;

namespace SystemInfoCollector.Services
{
    static class CollectorService
    {
        // Stores types which behave the same (ClassicInfoCollector will be applied to them)
        private static List<Type> ClassicTypes = new List<Type>
        {
             typeof(CPU), typeof(GPU), typeof(RAM), typeof(Storage), typeof(Monitor)
        };

        /// <summary>
        /// Collects data about the system and returns the list of devices of Type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listOfDevices"></param>
        /// <returns></returns>
        public static List<T> CollectDataAndReturnListOfType<T>(List<T> initialListOfDevices)
        {
            if (ClassicTypes.Contains(typeof(T)))
                return ClassicInfoCollector.GetInfo(initialListOfDevices);

            if (typeof(T) == typeof(PSU))
            {
                PSUInfoCollector.GetInfo();
                return Computer.GetInstance().PSUs as List<T>;
            }
            
            if (typeof(T) == typeof(Motherboard))
                return MotherboardInfoCollector.GetInfo() as List<T>;

            if (typeof(T) == typeof(NetworkInterface))
                return NetworkInterfaceInfoCollector.GetInfo() as List<T>;

            return new List<T>();
        }
    }
}
