using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoCollectorV2._0.Models
{
    public class PSU : Device
    {
        public string Model { get; set; }
        public string MinInputWattage { get; set; }
        public string MaxOutputWattage { get; set; }
        public string SerialNumber { get; set; }
    }
}
