﻿#pragma checksum "..\..\..\Views\EnterPSUSpecs.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "18C7DAF663EFB3370E4980A7DAFE2D49A3B1029B6601F4109C5D8DF3C8F958B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using SystemInfoCollectorV2._0.Views;


namespace SystemInfoCollectorV2._0.Views {
    
    
    /// <summary>
    /// EnterPSUSpecs
    /// </summary>
    public partial class EnterPSUSpecs : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\Views\EnterPSUSpecs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbModel;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\EnterPSUSpecs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbModel;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Views\EnterPSUSpecs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSerialNumber;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Views\EnterPSUSpecs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMaxWattage;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Views\EnterPSUSpecs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSave;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SystemInfoCollectorV2.0;component/views/enterpsuspecs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\EnterPSUSpecs.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lbModel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.tbModel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbSerialNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\Views\EnterPSUSpecs.xaml"
            this.tbSerialNumber.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.tbSerialNumber_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbMaxWattage = ((System.Windows.Controls.TextBox)(target));
            
            #line 68 "..\..\..\Views\EnterPSUSpecs.xaml"
            this.tbMaxWattage.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.tbSerialNumber_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btSave = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\Views\EnterPSUSpecs.xaml"
            this.btSave.Click += new System.Windows.RoutedEventHandler(this.btSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

