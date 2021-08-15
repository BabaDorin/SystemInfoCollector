using SystemInfoCollector.Views;

namespace SystemInfoCollector.Services.Collectors
{
    static class PSUInfoCollector
    {
        public static void GetInfo()
        {
            // Prompt the user to enter data about PSU
            EnterPSUSpecs enterPSUSpecs = new EnterPSUSpecs();
            enterPSUSpecs.ShowDialog();
        }
    }
}
