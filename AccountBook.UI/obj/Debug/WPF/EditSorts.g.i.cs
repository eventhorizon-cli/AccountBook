﻿#pragma checksum "..\..\..\WPF\EditSorts.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "972C0150469EB652A3035A769DC8228E"
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
    /// EditSorts
    /// </summary>
    public partial class EditSorts : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\WPF\EditSorts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border editBrush;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\WPF\EditSorts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WMControl.WMButton btnMessageClose;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\WPF\EditSorts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSort;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\WPF\EditSorts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoEdit;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\WPF\EditSorts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoAdd;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\WPF\EditSorts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoDelete;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\WPF\EditSorts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNewSort;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\WPF\EditSorts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfirm;
        
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
            System.Uri resourceLocater = new System.Uri("/AccountBook;component/wpf/editsorts.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WPF\EditSorts.xaml"
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
            
            #line 14 "..\..\..\WPF\EditSorts.xaml"
            ((AccountBook.WPF.EditSorts)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.editBrush = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.btnMessageClose = ((WMControl.WMButton)(target));
            
            #line 24 "..\..\..\WPF\EditSorts.xaml"
            this.btnMessageClose.Click += new System.Windows.RoutedEventHandler(this.btnEditClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\WPF\EditSorts.xaml"
            this.cmbSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rdoEdit = ((System.Windows.Controls.RadioButton)(target));
            
            #line 44 "..\..\..\WPF\EditSorts.xaml"
            this.rdoEdit.Checked += new System.Windows.RoutedEventHandler(this.rdoEdit_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rdoAdd = ((System.Windows.Controls.RadioButton)(target));
            
            #line 45 "..\..\..\WPF\EditSorts.xaml"
            this.rdoAdd.Checked += new System.Windows.RoutedEventHandler(this.rdoAdd_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.rdoDelete = ((System.Windows.Controls.RadioButton)(target));
            
            #line 46 "..\..\..\WPF\EditSorts.xaml"
            this.rdoDelete.Checked += new System.Windows.RoutedEventHandler(this.rdoDelete_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtNewSort = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnConfirm = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\WPF\EditSorts.xaml"
            this.btnConfirm.Click += new System.Windows.RoutedEventHandler(this.btnConfirm_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

