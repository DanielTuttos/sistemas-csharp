﻿#pragma checksum "..\..\MenuItemSelectorView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6066058A1D67FD24ED179642D63E01C12FFD3F23"
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
using Samba.Presentation.Controls.UIControls;
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


namespace Samba.Modules.PosModule {
    
    
    /// <summary>
    /// MenuItemSelectorView
    /// </summary>
    public partial class MenuItemSelectorView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\MenuItemSelectorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MenuItemSelectorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition SelectedItemsRow;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MenuItemSelectorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition MenuItemRow;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MenuItemSelectorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition NumeratorRow;
        
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
            System.Uri resourceLocater = new System.Uri("/Samba.Modules.PosModule;component/menuitemselectorview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuItemSelectorView.xaml"
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
            this.SelectedItemsRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 3:
            this.MenuItemRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 4:
            this.NumeratorRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 5:
            
            #line 43 "..\..\MenuItemSelectorView.xaml"
            ((System.Windows.Controls.ItemsControl)(target)).TargetUpdated += new System.EventHandler<System.Windows.Data.DataTransferEventArgs>(this.ItemsControl_TargetUpdated);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 151 "..\..\MenuItemSelectorView.xaml"
            ((System.Windows.Controls.ItemsControl)(target)).TargetUpdated += new System.EventHandler<System.Windows.Data.DataTransferEventArgs>(this.ItemsControl_TargetUpdated_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

