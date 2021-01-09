using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCollector.Models
{
    class Storage
    {
        public Storage()
        {
            StorageDevices = new List<StorageDevice>();
        }

        public int NumberOfStorageDevices { get; set; }
        public List<StorageDevice> StorageDevices { get; set; }

        public string ShowInfo()
        {
            string info = "";
            info += "\nStorage Properties:";
            info += "\n-----------------";
            info += "\nNumber of devices: " + NumberOfStorageDevices;
            foreach (StorageDevice sd in StorageDevices)
            {
                info += "\nManufacturer: " + sd.Manufacturer;
                info += "\nSerialNumber: " + sd.SerialNumber;
                info += "\nType: " + sd.Type;
                info += "\nCapacity: " + sd.Capacity;
                info += "\nDeviceID: " + sd.DeviceId;
            }
            return info;
        }
    }
}
