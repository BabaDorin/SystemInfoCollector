namespace SystemInfoCollector.Models
{
    public class NetworkInterface : Device
    {
        private string speed;

        public string PhysicalAddress { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string NetworkInterfaceType { get; set; }
        public string Speed
        {
            get { return speed; }
            set
            {
                speed = (value == "-1") ? "0" : value;
            }
        }

        public NetworkInterface()
        {
            PhysicalAddress = string.Empty;
            Description = string.Empty;
            Name = string.Empty;
            NetworkInterfaceType = string.Empty;
            Speed = "0";
        }
    }
}
