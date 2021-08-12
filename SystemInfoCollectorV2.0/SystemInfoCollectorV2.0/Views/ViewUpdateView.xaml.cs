using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
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
            // a new object is created and added tot he list of components.

            Computer computer = Computer.GetInstance();
            PropertyInfo[] computerProperties = computer.GetType().GetProperties();

            foreach (UIElement cschild in componentsStack.Children)
            {
                if (!(cschild is GroupBox))
                    continue;

                var child = (GroupBox)cschild;

                // Now we are in CPUs / GPUs ...
                // Search the property with the same name as current gropubox header
                var currentProp = computer.GetType().GetProperties().First(p => p.Name.ToString() == child.Header.ToString());

                // Get and then update the current list of components
                var tempListOfDevices = (IList)currentProp.GetValue(computer, null);
               
                // We clear the list because it will be constructed from scratch based on information provided by the UI
                tempListOfDevices.Clear();

                var devices = (child.Content as StackPanel).Children;
                foreach (UIElement devicePropertyCollection in devices)
                {
                    // Now we are in CPU #1 ...
                    // It is a GrouBox with the following structure
                    // • GroupBox
                    //    |
                    //    |---- Stackpanel
                    //    |         |
                    //    |         |----- Remove button
                    //    |         |
                    //    |         |----- CPU's properties (Label = property name, TextBox = property value) 
                    //    |
                    //    |---- + Add New Button

                    if (devicePropertyCollection is Button) continue;

                    // A new device is created of list type
                    object device = null;
                    switch (child.Header.ToString())
                    {
                        case nameof(computer.CPUs): device = CreateObjectOfType<CPU>(); break;
                        case nameof(computer.GPUs): device = CreateObjectOfType<GPU>(); break;
                        case nameof(computer.Storages): device = CreateObjectOfType<Storage>(); break;
                        case nameof(computer.PSUs): device = CreateObjectOfType<PSU>(); break;
                        case nameof(computer.RAMs): device = CreateObjectOfType<RAM>(); break;
                        case nameof(computer.Motherboards): device = CreateObjectOfType<Motherboard>(); break;
                        case nameof(computer.NetworkInterfaces): device = CreateObjectOfType<NetworkInterface>(); break;
                        case nameof(computer.Monitors): device = CreateObjectOfType<Monitor>(); break;
                    }

                    var devicePropertiesContainer = (devicePropertyCollection as GroupBox).Content as StackPanel;

                    // The first element within the stackpanel is a button. We skip it.
                    // For each property (Where the name is label's content and value - the text within the textbox placed right after the label
                    // This way the device object is being populated with values for it's properties
                    for (int i = 2; i < devicePropertiesContainer.Children.Count; i += 2)
                    {
                        var propertyName = (devicePropertiesContainer.Children[i - 1] as Label).Content.ToString();
                        var propertyValue = (devicePropertiesContainer.Children[i] as TextBox).Text.ToString();

                        var currentDeviceProperty = device.GetType().GetProperties().First(p => p.Name == propertyName);
                        currentDeviceProperty.SetValue(device, propertyValue);
                    }

                    tempListOfDevices.Add(device);
                }

                currentProp.SetValue(computer, tempListOfDevices);
            }

            btSaveChanges.IsEnabled = false;
        }

        /// <summary>
        /// Creates a new GroupBox represeting a new instance of a specific type (Ex. CPU, GPU etc.) and appends it
        /// to the collection of groupbox of the same type 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddChild_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var parent = button.Parent as StackPanel;
            var index = parent.Children.Count - 2; // Stackpanel contains 2 uncounted buttons. 
            var obj = Activator.CreateInstance((Type)button.Tag);
            CreateGroupBoxForObject(obj, index, parent);

            SetChildrenVisibility(parent, Visibility.Visible);
            (parent.Children[0] as Button).Content = "Collapse";

            btSaveChanges.IsEnabled = true;
        }

        private void BtRemove_Click(object sender, RoutedEventArgs e)
        {
            // Removes the groubox representing an object.
            // button => stackpanel[0] => groupbox => stackpanel[1].
            // Button click triggers the removal of groupbox from stackpanel[1]
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
        /// BEFREE: Enumetator pattern 
        /// </summary>
        private void DisplayFetchedData()
        {
            Computer computer = Computer.GetInstance();
    
            foreach(PropertyInfo collectionProperty in computer)
            {
                var listOfDevices = collectionProperty.GetValue(computer) as IList;

                var currentParent = CreateGroupBoxForCollection(collectionProperty.Name, listOfDevices);
                for (int i = 0; i < listOfDevices.Count; i++)
                    CreateGroupBoxForObject(listOfDevices[i], i, currentParent);
            }
        }

        private StackPanel CreateGroupBoxForCollection(string listName, IList list)
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

        private object CreateObjectOfType<T>()
        {
            var device = Activator.CreateInstance<T>();
            return device;
        }
    }
}