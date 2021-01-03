using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInfoCollectorV2._0.Models;

namespace SystemInfoCollectorV2._0.Services
{
    class CollectorService
    {
        // Stores types which behave the same
        private static List<Type> ClassicTypes = new List<Type>
        {
             typeof(CPU), typeof(GPU), typeof(RAM), typeof(Storage)
        };

        public CollectorService()
        {
        }

        /// <summary>
        /// Collects data about the system and returns the list of devices of Type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listOfDevices"></param>
        /// <returns></returns>
        public static List<T> CollectDataAndReturnListOfType<T>(List<T> InitialListOfDevices)
        {
            if (ClassicTypes.Contains(typeof(T)))
                return ClassicInfoCollector(InitialListOfDevices);

            if (typeof(T) == typeof(PSU))
                return PSUInfoCollector() as List<T>;

            if (typeof(T) == typeof(Motherboard))
                return MotherboardInfoCollector() as List<T>;

            if (typeof(T) == typeof(NetworkInterface))
                return NetworkInterfaceInfoCollector() as List<T>;

            return new List<T>();
        }

        private static List<T> ClassicInfoCollector<T>(List<T> InitialListOfDevices)
        {
            var list = new List<T>();
            var obj = Activator.CreateInstance<T>();
            
            (obj as Device).TestData();
            
            list.Add(obj);
            
            return list;
        }

        private static List<PSU> PSUInfoCollector()
        {
            var list = new List<PSU>();
            var obj = Activator.CreateInstance<PSU>();
            list.Add(obj);
            
            return list;
        }

        private static List<Motherboard> MotherboardInfoCollector()
        {
            var list = new List<Motherboard>();
            var obj = Activator.CreateInstance<Motherboard>();
            list.Add(obj);

            return list;
        }

        private static List<NetworkInterface> NetworkInterfaceInfoCollector()
        {
            var list = new List<NetworkInterface>();
            var obj = Activator.CreateInstance<NetworkInterface>();
            list.Add(obj);

            return list;
        }
    }
}
