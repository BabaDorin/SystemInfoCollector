using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCollector.Models
{
    class RAM
    {
        public int NumberOfRAMChips { get; set; }
        public string Amount { get; set; }
        public string  Type { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public string ShowInfo()
        {
            string info = "";
            info += "\nRAM Properties:";
            info += "\n-----------------";
            info += "\nManufacturer: " + Manufacturer;
            info += "\nModel: " + Model;
            info += "\nAmount: " + Amount;
            info += "\nType: " + Type;

            return info;
        }
    }
}
