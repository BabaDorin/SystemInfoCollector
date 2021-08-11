using System;
using System.Windows;
using System.Windows.Input;
using SystemInfoCollectorV2._0.ViewModels;

namespace SystemInfoCollectorV2._0.Commands
{
    class ChangeUsingStatusCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private StartViewModel _viewModel;

        public ChangeUsingStatusCommand(StartViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.FormModel.IsUsed = Convert.ToBoolean(parameter.ToString());
        }
    }
}
