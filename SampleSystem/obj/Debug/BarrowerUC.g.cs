﻿#pragma checksum "..\..\BarrowerUC.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "83BD1D1069C8338197FCF832F6A61232"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SampleSystem;
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


namespace SampleSystem {
    
    
    /// <summary>
    /// BarrowerUC
    /// </summary>
    public partial class BarrowerUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\BarrowerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtSearchToolTip;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\BarrowerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUBSearch;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\BarrowerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgBarrower;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\BarrowerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBarrowerId;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\BarrowerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFname;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\BarrowerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLname;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\BarrowerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboCourse;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\BarrowerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel FunctionButtons_Book;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\BarrowerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnB_Add;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\BarrowerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnB_Edit;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\BarrowerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnB_Delete;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\BarrowerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnB_Save;
        
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
            System.Uri resourceLocater = new System.Uri("/SampleSystem;component/barroweruc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BarrowerUC.xaml"
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
            
            #line 8 "..\..\BarrowerUC.xaml"
            ((SampleSystem.BarrowerUC)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtSearchToolTip = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtUBSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\BarrowerUC.xaml"
            this.txtUBSearch.GotFocus += new System.Windows.RoutedEventHandler(this.txtUBSearch_GotFocus);
            
            #line default
            #line hidden
            
            #line 43 "..\..\BarrowerUC.xaml"
            this.txtUBSearch.LostFocus += new System.Windows.RoutedEventHandler(this.txtUBSearch_LostFocus);
            
            #line default
            #line hidden
            
            #line 43 "..\..\BarrowerUC.xaml"
            this.txtUBSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtUBSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgBarrower = ((System.Windows.Controls.DataGrid)(target));
            
            #line 49 "..\..\BarrowerUC.xaml"
            this.dgBarrower.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.dgBarrower_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtBarrowerId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtFname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtLname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.cboCourse = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.FunctionButtons_Book = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            this.btnB_Add = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\BarrowerUC.xaml"
            this.btnB_Add.Click += new System.Windows.RoutedEventHandler(this.btnB_Add_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnB_Edit = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\BarrowerUC.xaml"
            this.btnB_Edit.Click += new System.Windows.RoutedEventHandler(this.btnB_Edit_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnB_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\BarrowerUC.xaml"
            this.btnB_Delete.Click += new System.Windows.RoutedEventHandler(this.btnB_Delete_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnB_Save = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\BarrowerUC.xaml"
            this.btnB_Save.Click += new System.Windows.RoutedEventHandler(this.btnB_Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

