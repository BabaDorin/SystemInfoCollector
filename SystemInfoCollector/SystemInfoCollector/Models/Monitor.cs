namespace SystemInfoCollector.Models
{
    class Monitor : Device
    {
        public string TEMSID { get; set; }
        public string SerialNumber { get; set; }

        public string MonitorManufacturer { get; set; }
        public string Name { get; set; } // Do not touch!
        public string ScreenHeight { get; set; }
        public string ScreenWidth { get; set; }
        public string RefreshRateInHz { get; set; }
    }
}
