﻿#pragma checksum "..\..\PladgedForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CDF4B1BDA4834DC2007BC775438AF471455FF673"
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
using zalojnaKushta_2;


namespace zalojnaKushta_2 {
    
    
    /// <summary>
    /// PladgedForm
    /// </summary>
    public partial class PladgedForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\PladgedForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ItemTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\PladgedForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\PladgedForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IncreaseTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\PladgedForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ItemDescTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PladgedForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClientNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\PladgedForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PeriodTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\PladgedForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreatePladgedButton;
        
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
            System.Uri resourceLocater = new System.Uri("/zalojnaKushta 2;component/pladgedform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PladgedForm.xaml"
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
            this.ItemTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.PriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.IncreaseTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ItemDescTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ClientNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PeriodTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CreatePladgedButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\PladgedForm.xaml"
            this.CreatePladgedButton.Click += new System.Windows.RoutedEventHandler(this.CreatePladgedButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

