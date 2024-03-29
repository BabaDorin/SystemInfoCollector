﻿namespace SystemInfoCollector.Models
{
    public class Storage : Device
    {
        public string Caption { get; set; }
        public string Description { get; set; }
        public string InterfaceType { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Size { get; set; }
        public string MediaType { get; set; } // Do not touch!
    }
}
