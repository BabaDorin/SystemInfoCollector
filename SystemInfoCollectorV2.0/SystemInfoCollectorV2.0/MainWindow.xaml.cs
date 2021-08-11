﻿using System.Windows;
using System.Windows.Controls;
using SystemInfoCollectorV2._0.Views;

namespace SystemInfoCollectorV2._0
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateView("Info");
        }

        /// <summary>
        /// Displays the specified view inside the ContentControl
        /// ex: Start for StartView.
        /// </summary>
        /// <param name="parameter">The paramenter is the view's name without the 'View' suffix. Example: 'Start' for StartView</param>
        public void UpdateView(string parameter)
        {
            switch (parameter)
            {
                case "Start":
                    childWindow.Content = StartView.GetInstance();
                    break;
                case "ViewUpdate":
                    childWindow.Content = new ViewUpdateView();
                    break;
                case "Info":
                    childWindow.Content = new InfoView();
                    break;
                case "Preferences":
                    childWindow.Content = new Preferences();
                    break;
                default:
                    childWindow.Content = StartView.GetInstance();
                    break;
            }
        }

        private void btMenuItem_Click(object sender, RoutedEventArgs e)
        {
            UpdateView((sender as Button).Tag.ToString());
        }
    }
}
