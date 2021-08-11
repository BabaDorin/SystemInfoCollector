using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using SystemInfoCollectorV2._0.ViewModels;

namespace SystemInfoCollectorV2._0.Commands
{
    class ScanCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private StartViewModel _viewModel;

        public ScanCommand(StartViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                _viewModel.FormModel.ScanningEnabled= false;
                _viewModel.FormModel.BtScanContent = "Scanare...";
                new Thread(() =>
                {
                    _viewModel.CollectComputerInformation();
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        _viewModel.FormModel.BtScanContent = "Rezultatele pot fi vizualizate" + Environment.NewLine + "Click pentru a scana din nou";
                        _viewModel.FormModel.ScanningEnabled = true;
                    });
                }).Start();
            }
            catch (Exception ex)
            {
                _viewModel.FormModel.BtScanContent = "S-a produs o eroare la scanarea datelor";
                Debug.WriteLine("Error in btScan.Click: " + ex.Message);
                return;
            }
        }
    }
}
