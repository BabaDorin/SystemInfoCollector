using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemInfoCollector.Models;
using SystemInfoCollector.Views;

namespace SystemInfoCollector.Services.Collectors
{
    static class PSUInfoCollector
    {
        public static void GetInfo()
        {
            // Prompt the user to enter data about PSU
            EnterPSUSpecs enterPSUSpecs = new EnterPSUSpecs();
            enterPSUSpecs.ShowDialog();
        }
    }
}
