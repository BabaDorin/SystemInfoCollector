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
        private static CollectorService instance;

        private CollectorService()
        {

        }

        public static CollectorService GetInstance()
        {
            if (instance == null)
                instance = new CollectorService();

            return instance;
        }

        public void GetInfo()
        {
            
        }
    }
}
