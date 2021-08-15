namespace SystemInfoCollector.Models
{
    public class PSU : Device
    {
        public string Model { get; set; }
        public string MaxOutputWattage { get; set; }
        public string SerialNumber { get; set; }

        public PSU()
        {
            Model = string.Empty;
            SerialNumber = "0";
            MaxOutputWattage = string.Empty;
        }
    }
}
