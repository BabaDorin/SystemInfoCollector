using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace InfoCollector.Models
{
    class Computer
    {
        // Used for storing OS and hardware information.
        // Follows singleton pattern

        private static Computer instance;

        private Computer()
        {
            CPU = new CPU();
            Storage = new Storage();
            OS = new OS();
            Motherboard = new Motherboard();
        }

        public static Computer GetInstance()
        {
            if (instance == null)
                instance = new Computer();

            return instance;
        }

        public string ComputerID { get; set; } //5-6 Digit code
        public string TempName { get; set; } // This will be the json file name for a computer.
        public CPU CPU { get; set; }
        public Storage Storage { get; set; }
        public OS OS { get; set; }
        public Motherboard Motherboard { get; set; }

        public string Serialize()
        {
            if (instance == null) return "Unable to serialize, the object is null.";
            var json = new JavaScriptSerializer().Serialize(instance);
            Console.WriteLine(json);
            return json;
        }
    }
}
