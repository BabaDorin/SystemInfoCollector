using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCollector.Models
{
    class GPU
    {
        public GPU()
        {
            GPUDevices = new List<GPUDevice>();
        }

        public int NumberOfGPUs { get; set; }
        public List<GPUDevice> GPUDevices { get; set; }

        public string ShowInfo()
        {
            string info = "";
            info += "\nGPU Properties:";
            info += "\n-----------------";
            info += "\nNumber of devices: " + NumberOfGPUs;
            foreach (GPUDevice gd in GPUDevices)
            {
                info += "\nName: " + gd.Name;
                info += "\nVRAM: " + gd.VRAM;
            }

            return info;
        }
    }
}
