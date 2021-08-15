using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using SystemInfoCollector.Services;

namespace SystemInfoCollector.Models
{
    [JsonObject]
    class Computer : IEnumerable
    {
        // follows singleton pattern
        [JsonIgnore]
        private static Computer instance;

        private Computer()
        {
            TEMSID = String.Empty;
            Identifier = String.Empty;
            TeamViewerID = String.Empty;
            TeamViewerPassword = String.Empty;
            Description = String.Empty;

            CPUs = new List<CPU>();
            GPUs = new List<GPU>();
            Motherboards = new List<Motherboard>();
            NetworkInterfaces = new List<NetworkInterface>();
            RAMs = new List<RAM>();
            Storages = new List<Storage>();
            PSUs = new List<PSU>();
            Monitors = new List<Monitor>();
        }

        /// <summary>
        /// Returns the only instance of computer class (Singleton design pattern).
        /// </summary>
        /// <returns></returns>
        public static Computer GetInstance()
        {
            if (instance == null)
                instance = new Computer();

            return instance;
        }

        public string TEMSID { get; set; }
        public string Identifier { get; set; }
        public string TeamViewerID { get; set; }
        public bool IsUsed { get; set; }
        public bool Working { get; set; }
        public string TeamViewerPassword { get; set; }
        public string Description { get; set; }

        // All of the components are stored in generic lists, which makes 
        // generic functions for Reading / wrinting simpler and easier to implement.
        public List<CPU> CPUs { get; set; }
        public List<GPU> GPUs { get; set; }
        public List<PSU> PSUs { get; set; }
        public List<Motherboard> Motherboards { get; set; } 
        public List<NetworkInterface> NetworkInterfaces { get; set; }
        public List<Monitor> Monitors { get; set; }
        public List<RAM> RAMs { get; set; }
        public List<Storage> Storages { get; set; }

        /// <summary>
        /// Displays collected information in Output (For debugging).
        /// </summary>
        public void DisplayData()
        {
            Debug.WriteLine("==============================================");
            Debug.WriteLine(TEMSID);
            CPUs.ForEach(s => s.DisplayData());
            GPUs.ForEach(s => s.DisplayData());
            PSUs.ForEach(s => s.DisplayData());
            Motherboards.ForEach(s => s.DisplayData());
            NetworkInterfaces.ForEach(s => s.DisplayData());
            RAMs.ForEach(s => s.DisplayData());
            Storages.ForEach(s => s.DisplayData());
            Monitors.ForEach(s => s.DisplayData());
        }

        /// <summary>
        /// Retrieves information about computer components and stores it in computer's properties.
        /// </summary>
        public void RetrieveData()
        {
            CPUs = CollectorService.CollectDataAndReturnListOfType(CPUs);
            GPUs = CollectorService.CollectDataAndReturnListOfType(GPUs);
            Motherboards = CollectorService.CollectDataAndReturnListOfType(Motherboards);
            NetworkInterfaces = CollectorService.CollectDataAndReturnListOfType(NetworkInterfaces);
            RAMs = CollectorService.CollectDataAndReturnListOfType(RAMs);
            Storages = CollectorService.CollectDataAndReturnListOfType(Storages);
            Monitors = CollectorService.CollectDataAndReturnListOfType(Monitors);
            
            // This action accesses UI Thread.
            Application.Current.Dispatcher.Invoke((Action)delegate {
                PSUs = CollectorService.CollectDataAndReturnListOfType(PSUs);
            });

            // Filters
            Storages.RemoveAll(q => q.MediaType != "Fixed hard disk media");
            Monitors.RemoveAll(q => q.Name == "Default Monitor" || q.Name == "Generic PnP Monitor");
        }

        /// <summary>
        /// Initializes the list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public void InitList<T>(ref List<T> list)
        {
            list = new List<T>();
        }

        public IEnumerator GetEnumerator()
        {
            return new DeviceCollectionPropertyEnumerator();
        }
    }
}
