﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInfoCollectorV2._0.Models;
using SystemInfoCollectorV2._0.Services.Collectors;

namespace SystemInfoCollectorV2._0.Services
{
    class CollectorService
    {
        // Stores types which behave the same
        private static List<Type> ClassicTypes = new List<Type>
        {
             typeof(CPU), typeof(GPU), typeof(RAM), typeof(Storage)
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
                return PSUInfoCollector.GetInfo() as List<T>;

            if (typeof(T) == typeof(Motherboard))
                return MotherboardInfoCollector.GetInfo() as List<T>;

            if (typeof(T) == typeof(NetworkInterface))
                return NetworkInterfaceInfoCollector.GetInfo() as List<T>;

            return new List<T>();
        }
    }
}
