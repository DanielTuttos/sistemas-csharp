﻿#pragma checksum "..\..\TicketExplorerView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1EB317913CD4471CA89D4B79D7F62AF0F3918012"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FlexButton;
using Samba.Localization.Engine;
using Samba.Localization.Extensions;
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


namespace Samba.Modules.TicketModule {
    
    
    /// <summary>
    /// TicketExplorerView
    /// </summary>
    public partial class TicketExplorerView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\TicketExplorerView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Samba.Modules.TicketModule;component/ticketexplorerview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TicketExplorerView.xaml"
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
            this.DataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 64 "..\..\TicketExplorerView.xaml"
            this.DataGrid.AddHandler(System.Windows.Controls.ScrollViewer.ScrollChangedEvent, new System.Windows.Controls.ScrollChangedEventHandler(this.DataGrid_ScrollChanged));
            
            #line default
            #line hidden
            
            #line 66 "..\..\TicketExplorerView.xaml"
            this.DataGrid.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.DataGrid_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 67 "..\..\TicketExplorerView.xaml"
            this.DataGrid.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DataGrid_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 68 "..\..\TicketExplorerView.xaml"
            this.DataGrid.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.DataGrid_PreviewKeyUp);
            
            #line default
            #line hidden
            
            #line 68 "..\..\TicketExplorerView.xaml"
            this.DataGrid.DataContextChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.DataGrid_DataContextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

