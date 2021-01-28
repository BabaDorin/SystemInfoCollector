﻿#pragma checksum "..\..\..\Views\StartView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C309702402507633BFE6255ED68564E34460FDB9ADD0130B944C7B976EBF9938"
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
    /// StartView
    /// </summary>
    public partial class StartView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btScan;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btScanContent;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTEMSID;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbRoom;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPCIdentifier;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDescription;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTVID;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTVPassword;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btViewUpdate;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\..\Views\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btWriteFile;
        
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
            System.Uri resourceLocater = new System.Uri("/SystemInfoCollectorV2.0;component/views/startview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\StartView.xaml"
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
            this.btScan = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Views\StartView.xaml"
            this.btScan.Click += new System.Windows.RoutedEventHandler(this.btScan_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btScanContent = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tbTEMSID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbRoom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbPCIdentifier = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbTVID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbTVPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btViewUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 205 "..\..\..\Views\StartView.xaml"
            this.btViewUpdate.Click += new System.Windows.RoutedEventHandler(this.btViewUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btWriteFile = ((System.Windows.Controls.Button)(target));
            
            #line 213 "..\..\..\Views\StartView.xaml"
            this.btWriteFile.Click += new System.Windows.RoutedEventHandler(this.btWriteFile_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

