using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;

namespace SystemInfoCollector.ViewModels
{
    class PCGeneralInfoFormModel : INotifyPropertyChanged
    {
        private bool scanningEnabled;
        public bool ScanningEnabled
        {
            get { return scanningEnabled; }
            set { scanningEnabled = value; NotifyPropertyChanged(nameof(ScanningEnabled)); }
        }

        private string btScanContent;
        public string BtScanContent
        {
            get { return btScanContent; }
            set { btScanContent = value; NotifyPropertyChanged(nameof(BtScanContent)); }
        }

        private string temsID;
        public string TEMSID
        {
            get { return temsID; }
            set { temsID = value; NotifyPropertyChanged(nameof(TEMSID)); }
        }

        private string identifier;
        public string Identifier
        {
            get { return identifier; }
            set { identifier = value; NotifyPropertyChanged(nameof(Identifier)); }
        }

        private string teamViewerID;
        public string TeamViewerID
        {
            get { return teamViewerID; }
            set { teamViewerID = value; NotifyPropertyChanged(nameof(TeamViewerID)); }
        }

        private string teamViewerPassword;
        public string TeamViewerPassword
        {
            get { return teamViewerPassword; }
            set { teamViewerPassword = value; NotifyPropertyChanged(nameof(TeamViewerPassword)); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; NotifyPropertyChanged(nameof(Description)); }
        }

        private bool isUsed;

        public bool IsUsed
        {
            get { return isUsed; }
            set 
            { 
                isUsed = value;

                if (value)
                {
                    UsedVisibility = Visibility.Visible;
                    NotUsedVisibility = Visibility.Hidden;
                }
                else
                {
                    UsedVisibility = Visibility.Hidden;
                    NotUsedVisibility = Visibility.Visible;
                }
            }
        }

        private bool isDefect;

        public bool IsDefect
        {
            get { return isDefect; }
            set 
            { 
                isDefect = value;
                
                if (value)
                {
                    WorkingVisibility = Visibility.Hidden;
                    NotWorkingVisibility = Visibility.Visible;
                }
                else
                {
                    WorkingVisibility = Visibility.Visible;
                    NotWorkingVisibility = Visibility.Hidden;
                }
            }
        }

        private Visibility usedVisibility;
        public Visibility UsedVisibility
        {
            get { return usedVisibility; }
            set { usedVisibility = value; NotifyPropertyChanged(nameof(UsedVisibility)); }
        }

        private Visibility notUsedVisibility;
        public Visibility NotUsedVisibility
        {
            get { return notUsedVisibility; }
            set { notUsedVisibility = value; NotifyPropertyChanged(nameof(NotUsedVisibility)); }
        }

        private Visibility workingVisibility;
        public Visibility WorkingVisibility
        {
            get { return workingVisibility; }
            set { workingVisibility = value; NotifyPropertyChanged(nameof(WorkingVisibility)); }
        }

        private Visibility notWorkingVisibility;
        public Visibility NotWorkingVisibility
        {
            get { return notWorkingVisibility; }
            set { notWorkingVisibility = value; NotifyPropertyChanged(nameof(NotWorkingVisibility)); }
        }

        /// <summary>
        /// Validates form's fields
        /// </summary>
        /// <returns>Null if everything is Ok, othwerwise - returns an error message</returns>
        public string Validate()
        {
            var properties = this.GetType().GetProperties();
            
            // trim string properties
            foreach(PropertyInfo prop in properties)
            {
                if (prop.PropertyType == typeof(string))
                {
                    prop.SetValue(this, prop.GetValue(this)?.ToString().Trim());
                }
            }

            if (String.IsNullOrEmpty(TEMSID))
                return "TEMSID-ul calculatorului nu este specificat.";

            if (String.IsNullOrEmpty(Identifier))
                return "Indentificatorul calculatorului nu este specificat";

            return null;
        }

        public PCGeneralInfoFormModel()
        {
            BtScanContent = "Scanare calculator";
            ScanningEnabled = true;

            WorkingVisibility = Visibility.Visible;
            NotWorkingVisibility = Visibility.Hidden;
            UsedVisibility = Visibility.Visible;
            NotUsedVisibility = Visibility.Hidden;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
