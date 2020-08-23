using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoCollector.Services
{
    class CollectorService
    {
        // Follows Singleton Design Pattern
        private static CollectorService collectorService;

        private CollectorService()
        {

        }

        public static CollectorService GetInstance()
        {
            if (collectorService != null)
                return collectorService;
            else
                return new CollectorService();
        }

        public void GetInfo()
        {
            
        }
    }
}
