﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoCollectorV2._0.Models
{
    public class NetworkInterface : Device
    {
        public string PhysicalAddress { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string NetworkInterfaceType { get; set; }
        public string Speed { get; set; }
    }
}