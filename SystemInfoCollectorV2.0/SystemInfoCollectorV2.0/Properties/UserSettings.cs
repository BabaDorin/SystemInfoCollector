using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoCollectorV2._0.Properties
{
    class UserSettings : ApplicationSettingsBase
    {
        private static UserSettings instance;

        public static UserSettings GetInstance()
        {
            if (instance == null)
                instance = new UserSettings();

            return instance;
        }

        [UserScopedSetting]
        public string OutputPath
        {
            get
            {
                return (this["OutputPath"] == null)
                    ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    : this["OutputPath"].ToString();
            }
            set
            {
                this["OutputPath"] = value;
            }
        }
    }
}
