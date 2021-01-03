using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using SystemInfoCollectorV2._0.Models;

namespace SystemInfoCollectorV2._0.Services.Collectors
{
    class NetworkInterfaceInfoCollector
    {
        public static List<SystemInfoCollectorV2._0.Models.NetworkInterface> GetInfo()
        {
            var list = new List<SystemInfoCollectorV2._0.Models.NetworkInterface>();
            var obj = new SystemInfoCollectorV2._0.Models.NetworkInterface();
            list.Add(obj);

            return list;
        }
    }
}
