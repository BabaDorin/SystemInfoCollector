using System;
using System.Configuration;

namespace SystemInfoCollector.Properties
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
