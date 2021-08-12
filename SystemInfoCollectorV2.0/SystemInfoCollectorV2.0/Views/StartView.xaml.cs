using System.Windows.Controls;
using SystemInfoCollectorV2._0.ViewModels;

namespace SystemInfoCollectorV2._0.Views
{
    public partial class StartView : UserControl
    {
        // We need only one instance of this class
        private static StartView instance;

        private StartView()
        {
            InitializeComponent();
            DataContext = new StartViewModel(this);
        }

        public static StartView GetInstance()
        {
            if (instance == null)
                instance = new StartView();

            return instance;
        }
    }
}