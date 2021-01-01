using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;
using InfoCollector.Models;

namespace InfoCollector.Services.BrowseMicroservices
{
    class GPU_Info
    {
        private static ManagementObjectSearcher GPUSearcher = new ManagementObjectSearcher("select * from Win32_VideoController");

        public static GPU Info()
        {
            GPU gpu = new GPU{
                NumberOfGPUs = GPUSearcher.Get().Count
            };

            try
            {
                foreach (ManagementObject obj in GPUSearcher.Get())
                {
                    GPUDevice gpuDevice = new GPUDevice
                    {
                        Name = obj["Name"].ToString(),
                        VRAM = obj["AdapterRAM"].ToString()
                    };
                    gpu.GPUDevices.Add(gpuDevice);
                }

            }
            catch (Exception)
            {
                Debug.WriteLine("GPU_Info Error");
            }
            
            return gpu;
        }
    }
}
