using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoCollectorV2._0.Models
{
    public class Motherboard : Device
    {
        public string Manufacturer { get; set; }
        public string Product { get; set; }
        public string SerialNumber { get; set; }
        //public string BIOSManufacturer { get; set; }
        //public string BIOSSerialNumber { get; set; } // if SerialNumber fails
    }
}
