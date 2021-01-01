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
        public List<RAMDevice>  RAMChips { get; set; }

        public RAM()
        {
            RAMChips = new List<RAMDevice>();
        }

        public string ShowInfo()
        {
            string info = "";
            info += "\nRAM Properties:";
            info += "\n-----------------";
            info += "\nNumberOfRAMChips: " + NumberOfRAMChips;
            foreach (RAMDevice rd in RAMChips)
            {
                info += "\nManufacturer: " + rd.Manufacturer;
                info += "\nAmount: " + rd.Amount;
                info += "\nType: " + rd.Type;
                info += "\nSerialNumber: " + rd.SerialNumber;
            }
            return info;
        }
    }
}
