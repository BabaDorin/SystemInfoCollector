using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoCollector.Models
{
    public class PSU : Device
    {
        public string Model { get; set; }
        public string MaxOutputWattage { get; set; }
        public string SerialNumber { get; set; }
    }
}
