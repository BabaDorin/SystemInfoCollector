using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInfoCollectorV2._0.Models;

namespace SystemInfoCollectorV2._0.Services.Collectors
{
    class PSUInfoCollector
    {
        public static List<PSU> GetInfo()
        {
            var list = new List<PSU>();
            var obj = Activator.CreateInstance<PSU>();
            list.Add(obj);

            return list;
        }
    }
}
