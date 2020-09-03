using InfoCollector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using InfoCollector.Properties;

namespace InfoCollector.Services
{
    class CollectorService
    {
        // Follows Singleton Design Pattern
        private static CollectorService instance;
        public Computer computerInstance;
        public string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private UserSettings userSettings = UserSettings.GetInstance();

        private CollectorService()
        {
        }

        public static CollectorService GetInstance()
        {
            if (instance == null)
                instance = new CollectorService();

            return instance;
        }

        public void GetInfo(Label lbFeedback)
        {
            computerInstance = BrowseService.CollectedInformation(lbFeedback);
        }

        public bool WriteJsonFile()
        {
            string fileName = computerInstance.TempName + ".json";

            if (File.Exists(userSettings.OutputPath + "\\" + fileName))
                return false;

            using (StreamWriter sw = new StreamWriter(userSettings.OutputPath + "\\" + computerInstance.TempName+".json"))
            {
                sw.Write(computerInstance.Serialize());
            }

            return true;
        }

        public bool WriteTextFile()
        {
            string fileName = computerInstance.TempName + ".txt";

            if (File.Exists(userSettings.OutputPath + "\\" + fileName))
                return false;

            using (StreamWriter sw = new StreamWriter(userSettings.OutputPath + "\\" + computerInstance.TempName + ".txt"))
            {
                sw.Write(computerInstance.TextContent());
            }

            return true;
        }

        public bool WriteTextAndJSONFiles()
        {
            return WriteJsonFile() && WriteTextFile();
        }
    }
}
