using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCollector.Models
{
    class Computer
    {
        // Used for storing OS and hardware information.

        public Computer()
        {
            CPU = new CPU();
            Storage = new Storage();
            OS = new OS();
        }

        public string ComputerID { get; set; } //5-6 Digit code
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public CPU CPU { get; set; }
        public Storage Storage { get; set; }
        public OS OS { get; set; }
    }
}
