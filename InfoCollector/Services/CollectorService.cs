using InfoCollector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using InfoCollector.Properties;
using System.Diagnostics;

namespace InfoCollector.Services
{
    class CollectorService
    {
        // Follows Singleton Design Pattern
        private static CollectorService instance;
        public Computer computerInstance;
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
            
            string fileName = GenerateNecessaryFoldersAndReturnFinalPath() + '\\' + Path.GetFileName(computerInstance.TempName) + ".json";

            if (File.Exists(fileName))
                return false;

            
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(computerInstance.Serialize());
            }

            return true;
        }

        public bool WriteTextFile()
        {
            string fileName = GenerateNecessaryFoldersAndReturnFinalPath() + '\\' + Path.GetFileName(computerInstance.TempName) + ".json";

            if (File.Exists(fileName))
                return false;

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(computerInstance.TextContent());
            }

            return true;
        }

        public bool WriteTextAndJSONFiles()
        {
            return WriteJsonFile() && WriteTextFile();
        }

        private string GenerateNecessaryFoldersAndReturnFinalPath()
        {
            computerInstance.TempName = computerInstance.TempName.Replace('/', '\\');
            int backslashes = computerInstance.TempName.Count(x => x == '\\');
            if (backslashes == 0)
                return userSettings.OutputPath;

            // ParentFolder/FileName  =>  /ParentFolder/FileName
            if (backslashes > 0 && computerInstance.TempName[0] != '\\')
                computerInstance.TempName = '\\' + computerInstance.TempName;

            string finalPath = userSettings.OutputPath + Path.GetDirectoryName(computerInstance.TempName).ToLower();
            Directory.CreateDirectory(finalPath);
            return finalPath;
        }
    }
}
