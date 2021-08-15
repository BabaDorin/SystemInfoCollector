namespace SystemInfoCollector.Models
{
    public class Motherboard : Device
    {
        public string Manufacturer { get; set; }
        public string Product { get; set; }
        public string SerialNumber { get; set; }
    }
}
