﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using SystemInfoCollectorV2._0.Commands;
using SystemInfoCollectorV2._0.Models;
using SystemInfoCollectorV2._0.Views;

namespace SystemInfoCollectorV2._0.ViewModels
{
    class StartViewModel : INotifyPropertyChanged
    {
        readonly Computer _computer;

        private PCGeneralInfoFormModel formModel;

        public PCGeneralInfoFormModel FormModel
        {
            get { return formModel; }
            set { formModel = value; NotifyPropertyChanged(nameof(FormModel)); }
        }

        public ICommand ScanCommand { get; set; }
        public ICommand ExportToJsonCommand { get; set; }
        public ICommand ChangeUsingStatusCommand { get; set; }
        public ICommand ChangeWorkingStatusCommand { get; set; }

        public StartViewModel(StartView view)
        {
            _computer = Computer.GetInstance();
            FormModel = new PCGeneralInfoFormModel();

            ScanCommand = new ScanCommand(this);
            ExportToJsonCommand = new ExportToJsonCommand(this);
            ChangeUsingStatusCommand = new ChangeUsingStatusCommand(this);
            ChangeWorkingStatusCommand = new ChangeWorkingStatusCommand(this);
        }

        public void CollectComputerInformation()
        {
            _computer.RetrieveData();
        }

        public void ExportToJson()
        {
            string validationResult = FormModel.Validate();
            
            if(validationResult != null)
            {
                MessageBox.Show(validationResult);
                return;
            }

            _computer.TEMSID = FormModel.TEMSID;
            _computer.Identifier = FormModel.Identifier;
            _computer.TeamViewerID = FormModel.TeamViewerID;
            _computer.TeamViewerPassword = FormModel.TeamViewerPassword;
            _computer.Description = FormModel.Description;

            ComputerJSONSerializer.Serialize();
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