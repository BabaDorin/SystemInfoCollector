namespace SystemInfoCollector.Models
{
    public class PSU : Device
    {
        public string Model { get; set; }
        public string MaxOutputWattage { get; set; }
        public string SerialNumber { get; set; }
    }
}
