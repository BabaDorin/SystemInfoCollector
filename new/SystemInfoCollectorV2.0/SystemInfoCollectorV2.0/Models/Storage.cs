using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoCollectorV2._0.Models
{
    public class Storage : Device
    {
        public string Caption { get; set; }
        public string Description { get; set; }
        public string InterfaceTyoe { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Size { get; set; }
    }
}
