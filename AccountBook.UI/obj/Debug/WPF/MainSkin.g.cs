﻿#pragma checksum "..\..\..\WPF\MainSkin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9BF0F5FC579159BE768663339BF5D383"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using AccountBook.WPF;
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
using WMControl;


namespace AccountBook.WPF {
    
    
    /// <summary>
    /// MainSkin
    /// </summary>
    public partial class MainSkin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\WPF\MainSkin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border skinBrush;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\WPF\MainSkin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WMControl.WMButton btnPopClose;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\WPF\MainSkin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSkinOpen;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\WPF\MainSkin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSkinConfirm;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\WPF\MainSkin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSkinCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/AccountBook;component/wpf/mainskin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WPF\MainSkin.xaml"
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
            
            #line 14 "..\..\..\WPF\MainSkin.xaml"
            ((AccountBook.WPF.MainSkin)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.skinBrush = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.btnPopClose = ((WMControl.WMButton)(target));
            
            #line 30 "..\..\..\WPF\MainSkin.xaml"
            this.btnPopClose.Click += new System.Windows.RoutedEventHandler(this.btnSkinClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSkinOpen = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\WPF\MainSkin.xaml"
            this.btnSkinOpen.Click += new System.Windows.RoutedEventHandler(this.btnSkinOpen_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSkinConfirm = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\WPF\MainSkin.xaml"
            this.btnSkinConfirm.Click += new System.Windows.RoutedEventHandler(this.btnSkinConfirm_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSkinCancel = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\WPF\MainSkin.xaml"
            this.btnSkinCancel.Click += new System.Windows.RoutedEventHandler(this.btnSkinCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
