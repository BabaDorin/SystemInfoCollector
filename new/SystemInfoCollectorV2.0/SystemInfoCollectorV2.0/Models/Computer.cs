using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoCollectorV2._0.Models
{
    class Computer
    {
        // follows singleton pattern
        private static Computer instance;

        private Computer()
        {
            CPUs = new List<CPU>();
            GPUs = new List<GPU>();
            Motherboards = new List<Motherboard>();
            NetworkInterfaces = new List<NetworkInterface>();
            RAMs = new List<RAM>();
            Storages = new List<Storage>();
            PSUs = new List<PSU>();
        }

        public static Computer GetInstance()
        {
            if (instance == null)
                instance = new Computer();

            return instance;
        }


        public string TEMSID { get; set; }

        public List<CPU> CPUs { get; set; }
        public List<GPU> GPUs { get; set; }
        public List<PSU> PSUs { get; set; }
        public List<Motherboard> Motherboards { get; set; } // The motherboard is stored in a list to follow the design.
        public List<NetworkInterface> NetworkInterfaces { get; set; }
        public List<RAM> RAMs { get; set; }
        public List<Storage> Storages { get; set; }


        public void TestData()
        {
            TEMSID = "307PC1";

            CPUs = PopulateTestList(CPUs);
            GPUs = PopulateTestList(GPUs);
            Motherboards = PopulateTestList(Motherboards);
            NetworkInterfaces = PopulateTestList(NetworkInterfaces);
            RAMs = PopulateTestList(RAMs);
            Storages = PopulateTestList(Storages);
            PSUs = PopulateTestList(PSUs);

            CPUs[0].DisplayData();
            GPUs[0].DisplayData();
            Motherboards[0].DisplayData();
            NetworkInterfaces[0].DisplayData();
            RAMs[0].DisplayData();
            Storages[0].DisplayData();
            PSUs[0].DisplayData();
        }

        public List<T> PopulateTestList<T>(List<T> list)
        {
            InitList(ref list);
            var obj = Activator.CreateInstance<T>();
            (obj as Device).TestData();
            list.Add(obj);
            list.Add(obj);
            return list;
        }

        public void InitList<T>(ref List<T> list)
        {
            list = new List<T>();
        }
    }
}
