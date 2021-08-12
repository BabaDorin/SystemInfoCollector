using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SystemInfoCollector.ViewModels;

namespace SystemInfoCollector.Commands
{
    class ExportToJsonCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private StartViewModel _viewModel;

        public ExportToJsonCommand(StartViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.ExportToJson();
        }
    }
}
