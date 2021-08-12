using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using SystemInfoCollector.Properties;

namespace SystemInfoCollector.Models
{
    static class ComputerJSONSerializer
    {
        private static UserSettings userSettings = UserSettings.GetInstance();

        /// <summary>
        /// Serializes the current computer instance and writes JSON file to output directory.
        /// Returns false if something went wrong.
        /// </summary>
        /// <returns></returns>
        public static bool Serialize()
        {
            try
            {
                Computer computerInstance = Computer.GetInstance();
                string fileName = GenerateNecessaryFoldersAndReturnFinalPath() + '\\' + Path.GetFileName(computerInstance.TEMSID) + ".json";
                computerInstance.TEMSID = Path.GetFileName(computerInstance.TEMSID);

                if (File.Exists(fileName))
                {
                    MessageBox.Show("Există deja un fișier cu același nume în folderul indicat. Fișierul nu a fost scris.");
                    return false;
                }

                using (StreamWriter sw = new StreamWriter(fileName))
                sw.Write(JsonConvert.SerializeObject(computerInstance));

                MessageBox.Show(fileName);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("S-a produs o eroare: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Generates folders according to provided TEMSID value
        /// </summary>
        /// <returns></returns>
        private static string GenerateNecessaryFoldersAndReturnFinalPath()
        {
            Computer computerInstance = Computer.GetInstance();
            computerInstance.TEMSID = computerInstance.TEMSID.Replace('/', '\\');
            int backslashes = computerInstance.TEMSID.Count(x => x == '\\');
            if (backslashes == 0)
                return userSettings.OutputPath;

            // ParentFolder/FileName  =>  /ParentFolder/FileName
            if (backslashes > 0 && computerInstance.TEMSID[0] != '\\')
                computerInstance.TEMSID = '\\' + computerInstance.TEMSID;

            string finalPath = userSettings.OutputPath + Path.GetDirectoryName(computerInstance.TEMSID).ToLower();
            Directory.CreateDirectory(finalPath);
            return finalPath;
        }
    }
}
