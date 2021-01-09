using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.IO;

namespace InfoCollector.Properties
{
    class UserSettings: ApplicationSettingsBase
    {
        private static UserSettings instance;

        public static UserSettings GetInstance()
        {
            if (instance == null)
                instance = new UserSettings();

            return instance;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("none")]
        public string OutputPath
        {
            get
            {
                string outputPath = this["OutputPath"].ToString();
                if (outputPath == "none")
                    return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                else
                    return outputPath;
            }
            set
            {
                this["OutputPath"] = value;
            }
        }
    }
}
