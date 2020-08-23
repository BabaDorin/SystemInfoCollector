using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoCollector.Models;

namespace InfoCollector.Services
{
    class CPU_Info
    {
        public static CPU Info()
        {
            return new CPU();
        }
    }
}
