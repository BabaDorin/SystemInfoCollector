using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace InfoCollector.Services.BrowseMicroservices
{
    class Searcher
    {
        public static string LookForInformation(string whatToLookFor, ManagementObjectSearcher whereToLookFor)
        {
            try
            {
                foreach (ManagementObject queryObj in whereToLookFor.Get())
                    return queryObj[whatToLookFor].ToString();
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
