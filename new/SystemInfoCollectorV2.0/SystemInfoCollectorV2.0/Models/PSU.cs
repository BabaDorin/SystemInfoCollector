using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoCollectorV2._0.Models
{
    class PSU
    {
        public string Model { get; set; }
        public int InputWattage { get; set; }
        public int OutputWattage { get; set; }
        public string SerialNumber { get; set; }
    }
}
