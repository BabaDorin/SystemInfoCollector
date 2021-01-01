using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoCollectorV2._0.Models
{
    class Computer
    {
        public string TEMSID { get; set; }

        public List<CPU> CPUs { get; set; }
        public List<GPU> GPUs { get; set; }
        public List<PSU> PSUs { get; set; }
        public List<Motherboard> Motherboards { get; set; } // The motherboard is stored in a list to follow the design.
        public List<NetworkInterface> NetworkInterfaces { get; set; }
        public List<RAM> RAMs { get; set; }
        public List<Storage> Storages { get; set; }

    }
}
