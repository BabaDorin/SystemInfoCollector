using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCollector.Models
{
    class StorageDevice
    {
        public string DeviceId { get; set; }
        public string Manufacturer { get; set; }
        public string Capacity { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }
    }
}
