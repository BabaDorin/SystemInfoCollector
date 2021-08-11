using System;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using System.Windows;
using SystemInfoCollectorV2._0.Properties;

namespace SystemInfoCollectorV2._0.Models
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

                MessageBox.Show(fileName);

                if (File.Exists(fileName))
                {
                    MessageBox.Show("There is already a file with the same name in output directory. The file has not been written.");
                    return false;
                }

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.Write(new JavaScriptSerializer().Serialize(computerInstance));
                }
                
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to write json file. Invalid TempName");
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
