using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInfoCollectorV2._0.Models;
using SystemInfoCollectorV2._0.Views;

namespace SystemInfoCollectorV2._0.Services.Collectors
{
    class PSUInfoCollector
    {
        public static void GetInfo()
        {
            // Prompt the user to enter data about PSU

            EnterPSUSpecs enterPSUSpecs = new EnterPSUSpecs();
            enterPSUSpecs.ShowDialog();
        }
    }
}
