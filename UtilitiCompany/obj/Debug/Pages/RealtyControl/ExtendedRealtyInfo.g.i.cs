﻿#pragma checksum "..\..\..\..\Pages\RealtyControl\ExtendedRealtyInfo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6385D2EE49324DEC831C064754D7F25115DDE92D44E31DB9722C197AE523501E"
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
using UtilitiCompany.Pages.RealtyControl;


namespace UtilitiCompany.Pages.RealtyControl {
    
    
    /// <summary>
    /// ExtendedRealtyInfo
    /// </summary>
    public partial class ExtendedRealtyInfo : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\Pages\RealtyControl\ExtendedRealtyInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\RealtyControl\ExtendedRealtyInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RealtyImage;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\RealtyControl\ExtendedRealtyInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AddressLbl;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Pages\RealtyControl\ExtendedRealtyInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DistrictLbl;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\RealtyControl\ExtendedRealtyInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox MetersList;
        
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
            System.Uri resourceLocater = new System.Uri("/UtilitiCompany;component/pages/realtycontrol/extendedrealtyinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\RealtyControl\ExtendedRealtyInfo.xaml"
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
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.RealtyImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.AddressLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.DistrictLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.MetersList = ((System.Windows.Controls.ListBox)(target));
            
            #line 33 "..\..\..\..\Pages\RealtyControl\ExtendedRealtyInfo.xaml"
            this.MetersList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MetersList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

