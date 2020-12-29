using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCollector.Models
{
    class Motherboard
    {
        // Fields to keep: Manufacturer, Product, SerialNumber, BiosManufacturer.
        public string Manufacturer { get; set; }
        public string Product { get; set; }
        public string SerialNumber { get; set; }
        public string Status { get; set; }
        public string BIOSManufacturer { get; set; }
        public string BIOSSerialNumber { get; set; }

        public string ShowInfo()
        {
            string info = "";
            info += "\nMotherboard Properties:";
            info += "\n-----------------";
            info += "\nManufacturer: " + Manufacturer;
            info += "\nProduct: " + Product;
            info += "\nSerialNumber: " + SerialNumber;
            info += "\nStatus: " + Status;
            info += "\nBIOS Manufacturer: " + BIOSManufacturer;
            info += "\nBIOS SerialNumber: " + BIOSSerialNumber;

            return info;
        }
    }
}
