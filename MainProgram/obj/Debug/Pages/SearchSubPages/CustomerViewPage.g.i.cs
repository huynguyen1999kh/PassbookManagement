﻿#pragma checksum "..\..\..\..\Pages\SearchSubPages\CustomerViewPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "832153961DBC11AC3A79ABEF6A6CAC2FE6D3D0AA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MainProgram.Converter;
using MainProgram.Pages.SearchSubPages;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace MainProgram.Pages.SearchSubPages {
    
    
    /// <summary>
    /// CustomerViewPage
    /// </summary>
    public partial class CustomerViewPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\..\..\Pages\SearchSubPages\CustomerViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox_Search;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Pages\SearchSubPages\CustomerViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_ClearText;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Pages\SearchSubPages\CustomerViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButton_searchID;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Pages\SearchSubPages\CustomerViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButton_searchName;
        
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
            System.Uri resourceLocater = new System.Uri("/MainProgram;component/pages/searchsubpages/customerviewpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\SearchSubPages\CustomerViewPage.xaml"
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
            this.Textbox_Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\..\..\Pages\SearchSubPages\CustomerViewPage.xaml"
            this.Textbox_Search.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_Search_KeyDown);
            
            #line default
            #line hidden
            
            #line 70 "..\..\..\..\Pages\SearchSubPages\CustomerViewPage.xaml"
            this.Textbox_Search.KeyUp += new System.Windows.Input.KeyEventHandler(this.TextBox_Search_KeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Button_ClearText = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\Pages\SearchSubPages\CustomerViewPage.xaml"
            this.Button_ClearText.Click += new System.Windows.RoutedEventHandler(this.Button_ClearText_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RadioButton_searchID = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.RadioButton_searchName = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

