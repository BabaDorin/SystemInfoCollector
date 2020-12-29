using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace InfoCollector.Services.BrowseMicroservices
{
    class NetworkAdapter_Info
    {
        private static void UseThis()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                string fRegistryKey = "SYSTEM\\CurrentControlSet\\Control\\Network\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\" + ni.Id + "\\Connection";
                RegistryKey rk = Registry.LocalMachine.OpenSubKey(fRegistryKey, false);
                if (rk != null)
                {
                    string fPnpInstanceID = rk.GetValue("PnpInstanceID", "").ToString();
                    int fMediaSubType = Convert.ToInt32(rk.GetValue("MediaSubType", 0));
                    if (fPnpInstanceID.Length > 3 && fPnpInstanceID.Substring(0, 3) == "PCI")
                    {
                        Debug.WriteLine(ni.Description);
                        Debug.WriteLine(ni.Name);
                        Debug.WriteLine(ni.NetworkInterfaceType);
                        Debug.WriteLine(ni.Speed);
                        Debug.WriteLine(ni.GetType().ToString());
                        Debug.WriteLine(ni.GetPhysicalAddress().ToString());
                        Debug.WriteLine("-----------------");
                    }
                }
            }
        }
    }
}
