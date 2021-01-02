using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SystemInfoCollectorV2._0.Models;

namespace SystemInfoCollectorV2._0.Views
{
    public partial class ViewUpdateView : UserControl
    {
        private MainWindow _mainWindow;
        public ViewUpdateView()
        {
            InitializeComponent();

            _mainWindow = (MainWindow)Application.Current.MainWindow;

            DisplayFetchedData();
        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.UpdateView("Start");
        }

        private void DisplayFetchedData()
        {
            Computer computer = Computer.GetInstance();
            computer.TestData();

            foreach (var property in computer.GetType().GetProperties())
            {
                if(property.PropertyType.Name.ToString() == "String")
                    continue;

                // property is a list of devices.
                var listOfDevices = property.GetValue(computer) as IList;
                //var listOfDevices = (List<object>)property.GetValue(computer);

                var currentParent = CreateGroupBoxForList(property.Name);
                for (int i = 0; i < listOfDevices.Count; i++)
                {
                    CreateGroupBoxForObject(listOfDevices[i], i, currentParent);
                }
            }
        }

        private StackPanel CreateGroupBoxForList(string listName)
        {
            GroupBox listGroupBox = new GroupBox();
            listGroupBox.Header = listName;
            listGroupBox.Style = Resources["groupBoxStyle"] as Style;

            StackPanel stackPanelForChildElements = new StackPanel();

            Button btnToggleVisibility = new Button();
            btnToggleVisibility.Click += BtnToggleVisibility_Click;
            btnToggleVisibility.Content = "Expand";
            stackPanelForChildElements.Children.Add(btnToggleVisibility);

            listGroupBox.Content = stackPanelForChildElements;
            componentsStack.Children.Add(listGroupBox);

            return stackPanelForChildElements;
        }

        private void BtnToggleVisibility_Click(object sender, RoutedEventArgs e)
        {
            var btSender = sender as Button;
            var stackPanel = btSender.Parent as StackPanel;
            var visibilityToBeSet = Visibility.Visible;

            if (btSender.Content.ToString() == "Expand")
            {
                visibilityToBeSet = Visibility.Visible;
                btSender.Content = "Collapse";
            }
            else
            {
                visibilityToBeSet = Visibility.Collapsed;
                btSender.Content = "Expand";
            }

            foreach (var item in stackPanel.Children)
            {
                if (item is Button)
                    continue;

                (item as UIElement).Visibility = visibilityToBeSet;
            }
        }

        

        private void CreateGroupBoxForObject(object obj, int index, UIElement parent)
        {
            GroupBox childGroupBox = new GroupBox();
            childGroupBox.Header = $"{obj.GetType().Name} #{index}";
            childGroupBox.Style = Resources["groupBoxStyle"] as Style;

            StackPanel childStackPanel = new StackPanel();
            childGroupBox.Content = childStackPanel;

            foreach (var prop in obj.GetType().GetProperties())
            {
                Label propertyLabel = new Label();
                propertyLabel.Content = $"{prop.Name} ({prop.GetType().Name})";

                TextBox propertyValue = new TextBox();
                propertyValue.Text = prop.GetValue(obj).ToString();

                childStackPanel.Children.Add(propertyLabel);
                childStackPanel.Children.Add(propertyValue);
            }

            childGroupBox.Visibility = Visibility.Collapsed;
            (parent as StackPanel).Children.Add(childGroupBox);
        }
    }
}
