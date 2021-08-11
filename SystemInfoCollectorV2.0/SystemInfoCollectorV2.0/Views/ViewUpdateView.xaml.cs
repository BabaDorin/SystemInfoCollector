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
        public ViewUpdateView()
        {
            InitializeComponent();

            DisplayFetchedData();
            btSaveChanges.IsEnabled = false;
        }

        private void btSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            // Basically it creates new lists for each type of objects (CPUs, GPUs), for each child groubox
            // a new object is created which in added to the list.

            // This is repeated for every list of components.

            // It might get optimized later.

            Computer computer = Computer.GetInstance();

            foreach (UIElement cschild in componentsStack.Children)
            {
                if (!(cschild is GroupBox))
                    continue;

                var child = (GroupBox)cschild;

                // Now we are in CPUs / GPUs ...
                var currentProp = computer.GetType().GetProperties().First(p => p.Name.ToString() == child.Header.ToString());

                var tempListOfDevices = (IList)currentProp.GetValue(computer, null);
                tempListOfDevices.Clear();

                foreach (UIElement deviceProperties in (child.Content as StackPanel).Children)
                {
                    // Now we are in CPU #1 ...

                    if (deviceProperties is Button) continue;

                    object device = null;
                    switch (child.Header.ToString())
                    {
                        case nameof(computer.CPUs): device = CreateObjectOfType(computer.CPUs); break;
                        case nameof(computer.GPUs): device = CreateObjectOfType(computer.GPUs); break;
                        case nameof(computer.Storages): device = CreateObjectOfType(computer.Storages); break;
                        case nameof(computer.PSUs): device = CreateObjectOfType(computer.PSUs); break;
                        case nameof(computer.RAMs): device = CreateObjectOfType(computer.RAMs); break;
                        case nameof(computer.Motherboards): device = CreateObjectOfType(computer.Motherboards); break;
                        case nameof(computer.NetworkInterfaces): device = CreateObjectOfType(computer.NetworkInterfaces); break;
                        case nameof(computer.Monitors): device = CreateObjectOfType(computer.Monitors); break;
                    }

                    var devicePropertiesContainer = (deviceProperties as GroupBox).Content as StackPanel;
                    for (int i = 2; i < devicePropertiesContainer.Children.Count; i += 2)
                    {
                        var propertyLabel = (devicePropertiesContainer.Children[i - 1] as Label);
                        var propertyTextBox = (devicePropertiesContainer.Children[i] as TextBox);

                        var currentDevicePropertyName = propertyLabel.Content.ToString();
                        var currentDeviceProperty = device.GetType().GetProperties().First(p => p.Name == currentDevicePropertyName);

                        currentDeviceProperty.SetValue(device, propertyTextBox.Text);
                    }

                    tempListOfDevices.Add(device);
                }

                currentProp.SetValue(computer, tempListOfDevices);
            }

            btSaveChanges.IsEnabled = false;
        }

        private void BtnAddChild_Click(object sender, RoutedEventArgs e)
        {
            // Adds a new gropbox representing a new object of necessary type (CPU, GPU...)

            Button button = sender as Button;
            var parent = button.Parent as StackPanel;
            var index = parent.Children.Count - 2; // Stackpanel contains 2 uncounted buttons. 
            Type objType = (Type)button.Tag;
            var obj = Activator.CreateInstance(objType);
            CreateGroupBoxForObject(obj, index, parent);

            SetChildrenVisibility(parent, Visibility.Visible);
            (parent.Children[0] as Button).Content = "Collapse";

            btSaveChanges.IsEnabled = true;
        }

        private void BtRemove_Click(object sender, RoutedEventArgs e)
        {
            // Removes the groubox representing an object.
            // button => stackpaned => groupbox => stackpanel.
            var parent = (sender as Button).Parent as StackPanel;
            var parentOfParent = parent.Parent as GroupBox;
            var parentOfParentOfParent = parentOfParent.Parent as StackPanel;
            parentOfParentOfParent.Children.Remove(parentOfParent);

            btSaveChanges.IsEnabled = true;
        }

        private void BtnToggleVisibility_Click(object sender, RoutedEventArgs e)
        {
            // Expands or collapses object within a list.
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

            SetChildrenVisibility(stackPanel, visibilityToBeSet);
        }

        private void PropertyValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            btSaveChanges.IsEnabled = true;
        }

        /// <summary>
        /// Displays (on view) the lists of components.
        /// </summary>
        private void DisplayFetchedData()
        {
            Computer computer = Computer.GetInstance();

            foreach (var property in computer.GetType().GetProperties())
            {
                if (property.PropertyType.Name.ToString() == "String")
                    continue;

                // property is a list of devices.
                var listOfDevices = property.GetValue(computer) as IList;

                var currentParent = CreateGroupBoxForList(property.Name, listOfDevices);
                for (int i = 0; i < listOfDevices.Count; i++)
                {
                    CreateGroupBoxForObject(listOfDevices[i], i, currentParent);
                }
            }
        }

        private StackPanel CreateGroupBoxForList(string listName, IList list)
        {
            GroupBox listGroupBox = new GroupBox();
            listGroupBox.Header = listName;
            listGroupBox.Style = Application.Current.FindResource("groupBoxStyle") as Style;

            StackPanel stackPanelForChildElements = new StackPanel();

            Button btnToggleVisibility = new Button();
            btnToggleVisibility.Click += BtnToggleVisibility_Click;
            btnToggleVisibility.Content = "Expand";
            btnToggleVisibility.Style = Application.Current.FindResource("CollapseButtonStyle") as Style;
            stackPanelForChildElements.Children.Add(btnToggleVisibility);

            Button btnAddChild = new Button();
            btnAddChild.Click += BtnAddChild_Click;
            btnAddChild.Tag = list.GetType().GetProperty("Item").PropertyType;
            btnAddChild.Content = "+ new object";
            btnAddChild.Style = Application.Current.FindResource("AddButtonStyle") as Style;
            stackPanelForChildElements.Children.Add(btnAddChild);

            listGroupBox.Content = stackPanelForChildElements;
            componentsStack.Children.Add(listGroupBox);

            return stackPanelForChildElements;
        }

        private void CreateGroupBoxForObject(object obj, int index, UIElement parent)
        {
            GroupBox childGroupBox = new GroupBox();
            childGroupBox.Header = $"{obj.GetType().Name} #{index}";
            childGroupBox.Style = Application.Current.FindResource("nestedGroupBoxStyle") as Style;

            StackPanel childStackPanel = new StackPanel();
            childGroupBox.Content = childStackPanel;

            Button btRemove = new Button();
            btRemove.Content = "- remove object";
            btRemove.Click += BtRemove_Click;
            btRemove.Style = Application.Current.FindResource("RemoveButtonStyle") as Style;
            childStackPanel.Children.Add(btRemove);

            foreach (var prop in obj.GetType().GetProperties())
            {
                Label propertyLabel = new Label();
                propertyLabel.Content = prop.Name;

                TextBox propertyValue = new TextBox();
                var value = prop.GetValue(obj);
                propertyValue.Text = (value == null) ? "" : value.ToString();
                propertyValue.TextChanged += PropertyValue_TextChanged;

                childStackPanel.Children.Add(propertyLabel);
                childStackPanel.Children.Add(propertyValue);
            }

            childGroupBox.Visibility = Visibility.Collapsed;
            (parent as StackPanel).Children.Add(childGroupBox);
        }

        private void SetChildrenVisibility(StackPanel parent, Visibility visibilityToBeSet)
        {
            // Shows / Hides children (except buttons) within a stackpanel
            foreach (var item in parent.Children)
            {
                if (item is Button)
                    continue;

                (item as UIElement).Visibility = visibilityToBeSet;
            }
        }

        private object CreateObjectOfType<T>(List<T> list)
        {
            var device = Activator.CreateInstance<T>();
            return device;
        }
    }
}


