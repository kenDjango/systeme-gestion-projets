﻿#pragma checksum "..\..\UserControlProjectView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FAD44FA417F82323704494CF0C895204D5D1D4FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SMInterface;
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


namespace SMInterface {
    
    
    /// <summary>
    /// UserControlProjectView
    /// </summary>
    public partial class UserControlProjectView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\UserControlProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost EditDialog;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\UserControlProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboxState;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\UserControlProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listeToDo;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\UserControlProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox inProgess;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\UserControlProjectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox done;
        
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
            System.Uri resourceLocater = new System.Uri("/SMInterface;component/usercontrolprojectview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserControlProjectView.xaml"
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
            this.EditDialog = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 2:
            this.comboxState = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            
            #line 52 "..\..\UserControlProjectView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listeToDo = ((System.Windows.Controls.ListBox)(target));
            
            #line 77 "..\..\UserControlProjectView.xaml"
            this.listeToDo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Liste_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.inProgess = ((System.Windows.Controls.ListBox)(target));
            
            #line 107 "..\..\UserControlProjectView.xaml"
            this.inProgess.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Liste_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.done = ((System.Windows.Controls.ListBox)(target));
            
            #line 136 "..\..\UserControlProjectView.xaml"
            this.done.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Liste_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

