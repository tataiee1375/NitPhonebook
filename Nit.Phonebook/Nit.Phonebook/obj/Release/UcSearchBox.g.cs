﻿#pragma checksum "..\..\UcSearchBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2B7435B1D1552A51BA88BCA55ECC24C19A5A2850"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using Nit.Phonebook;
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
using WpfControls;
using WpfControls.Editors;


namespace Nit.Phonebook {
    
    
    /// <summary>
    /// UcSearchBox
    /// </summary>
    public partial class UcSearchBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\UcSearchBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\UcSearchBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton searchEmp;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\UcSearchBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton seacrhPh;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\UcSearchBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfControls.Editors.AutoCompleteTextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\UcSearchBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\UcSearchBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstSearchResults;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\UcSearchBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Card progressBar;
        
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
            System.Uri resourceLocater = new System.Uri("/Nit.Phonebook;component/ucsearchbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UcSearchBox.xaml"
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
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\UcSearchBox.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.searchEmp = ((System.Windows.Controls.RadioButton)(target));
            
            #line 33 "..\..\UcSearchBox.xaml"
            this.searchEmp.Checked += new System.Windows.RoutedEventHandler(this.searchEmp_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.seacrhPh = ((System.Windows.Controls.RadioButton)(target));
            
            #line 36 "..\..\UcSearchBox.xaml"
            this.seacrhPh.Checked += new System.Windows.RoutedEventHandler(this.searchEmp_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtSearch = ((WpfControls.Editors.AutoCompleteTextBox)(target));
            return;
            case 5:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\UcSearchBox.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lstSearchResults = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.progressBar = ((MaterialDesignThemes.Wpf.Card)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

