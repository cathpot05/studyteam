﻿#pragma checksum "..\..\AuthorData.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C77D987BA99FABE67262BC3F5BA2D3CB"
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
    /// AuthorData
    /// </summary>
    public partial class AuthorData : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\AuthorData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtUASearchToolTip;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AuthorData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUASearch;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\AuthorData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgAuthor;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\AuthorData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAuthoriD;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\AuthorData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAuthorFname;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\AuthorData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAuthorLname;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\AuthorData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel FunctionButtons;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\AuthorData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnA_Add;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\AuthorData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnA_Edit;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\AuthorData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnA_Delete;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\AuthorData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnA_Save;
        
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
            System.Uri resourceLocater = new System.Uri("/SampleSystem;component/authordata.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AuthorData.xaml"
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
            
            #line 8 "..\..\AuthorData.xaml"
            ((SampleSystem.AuthorData)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtUASearchToolTip = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtUASearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\AuthorData.xaml"
            this.txtUASearch.GotFocus += new System.Windows.RoutedEventHandler(this.txtUASearch_GotFocus);
            
            #line default
            #line hidden
            
            #line 42 "..\..\AuthorData.xaml"
            this.txtUASearch.LostFocus += new System.Windows.RoutedEventHandler(this.txtUASearch_LostFocus);
            
            #line default
            #line hidden
            
            #line 42 "..\..\AuthorData.xaml"
            this.txtUASearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtUASearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgAuthor = ((System.Windows.Controls.DataGrid)(target));
            
            #line 51 "..\..\AuthorData.xaml"
            this.dgAuthor.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.dgAuthor_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtAuthoriD = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtAuthorFname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtAuthorLname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.FunctionButtons = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.btnA_Add = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\AuthorData.xaml"
            this.btnA_Add.Click += new System.Windows.RoutedEventHandler(this.btnA_Add_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnA_Edit = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\AuthorData.xaml"
            this.btnA_Edit.Click += new System.Windows.RoutedEventHandler(this.btnA_Edit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnA_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\AuthorData.xaml"
            this.btnA_Delete.Click += new System.Windows.RoutedEventHandler(this.btnA_Delete_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnA_Save = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\AuthorData.xaml"
            this.btnA_Save.Click += new System.Windows.RoutedEventHandler(this.btnA_Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

