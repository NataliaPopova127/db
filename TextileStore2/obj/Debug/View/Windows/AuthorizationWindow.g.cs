﻿#pragma checksum "..\..\..\..\View\Windows\AuthorizationWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CCEDCD77B2C0903F48F0343C5D8509F7F00A21D907DA41D69BE31FDCB7458F23"
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
using TextileStore.View.Windows;


namespace TextileStore.View.Windows {
    
    
    /// <summary>
    /// AuthorizationWindow
    /// </summary>
    public partial class AuthorizationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\View\Windows\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgLogotype;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\Windows\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame mainFrame;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\View\Windows\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewProductList;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\View\Windows\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAuthorization;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\Windows\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel mainStackPanel;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\Windows\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLogin;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\Windows\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPassword;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\Windows\AuthorizationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSignIn;
        
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
            System.Uri resourceLocater = new System.Uri("/TextileStore2;component/view/windows/authorizationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Windows\AuthorizationWindow.xaml"
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
            this.imgLogotype = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 3:
            this.btnViewProductList = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\View\Windows\AuthorizationWindow.xaml"
            this.btnViewProductList.Click += new System.Windows.RoutedEventHandler(this.btnViewProductList_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAuthorization = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\View\Windows\AuthorizationWindow.xaml"
            this.btnAuthorization.Click += new System.Windows.RoutedEventHandler(this.btnAuthorization_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mainStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.tbLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnSignIn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\View\Windows\AuthorizationWindow.xaml"
            this.btnSignIn.Click += new System.Windows.RoutedEventHandler(this.btnSignIn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

