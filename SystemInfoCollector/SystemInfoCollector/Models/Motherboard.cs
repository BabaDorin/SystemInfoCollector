namespace SystemInfoCollector.Models
{
    public class Motherboard : Device
    {
        public string Manufacturer { get; set; }
        public string Product { get; set; }
        public string SerialNumber { get; set; }

        public Motherboard()
        {
            Manufacturer = string.Empty;
            Product = string.Empty;
            SerialNumber = string.Empty;
        }
    }
}
