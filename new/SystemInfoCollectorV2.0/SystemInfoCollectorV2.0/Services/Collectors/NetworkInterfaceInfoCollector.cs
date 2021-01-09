using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using SystemInfoCollectorV2._0.Models;

namespace SystemInfoCollectorV2._0.Services.Collectors
{
    class NetworkInterfaceInfoCollector
    {
        public static List<SystemInfoCollectorV2._0.Models.NetworkInterface> GetInfo()
        {
            var list = new List<SystemInfoCollectorV2._0.Models.NetworkInterface>();

            foreach (System.Net.NetworkInformation.NetworkInterface ni in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                // We are interested only in physical network interfaces.
                // Physical interfaces are marked in registry with a PCI prefix.
                string fRegistryKey = "SYSTEM\\CurrentControlSet\\Control\\Network\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\" + ni.Id + "\\Connection";

                RegistryKey rk = Registry.LocalMachine.OpenSubKey(fRegistryKey, false);
                if (rk != null)
                {
                    string fPnpInstanceID = rk.GetValue("PnpInstanceID", "").ToString();
                
                    if (fPnpInstanceID.Length > 3 && fPnpInstanceID.Substring(0, 3) == "PCI")
                    {
                        Models.NetworkInterface networkInterface = new Models.NetworkInterface
                        {
                            Name = ni.Name,
                            Description = ni.Description,
                            Speed = ni.Speed.ToString(),
                            NetworkInterfaceType = ni.NetworkInterfaceType.ToString(),
                            PhysicalAddress = ni.GetPhysicalAddress().ToString()
                        };

                        list.Add(networkInterface);
                    }
                }
            }

            return list;
        }
    }
}
