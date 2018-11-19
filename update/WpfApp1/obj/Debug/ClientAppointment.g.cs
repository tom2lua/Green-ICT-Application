﻿#pragma checksum "..\..\ClientAppointment.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3B7241CFF72BDD2D3F3C58B5E3EBA2DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HamburgerMenu;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// ClientAppointment
    /// </summary>
    public partial class ClientAppointment : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\ClientAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image isaac_benhesed_249427_jpg;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ClientAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid appointmentGrid;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ClientAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\ClientAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\ClientAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button modifyButton;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\ClientAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelcancelButton;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\ClientAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmCancelButton;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\ClientAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label noappointmentMess;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\ClientAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label warningMess;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/clientappointment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClientAppointment.xaml"
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
            this.isaac_benhesed_249427_jpg = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            
            #line 41 "..\..\ClientAppointment.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Appointment_Selected);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 42 "..\..\ClientAppointment.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Booking_Selected);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 43 "..\..\ClientAppointment.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Profile_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 44 "..\..\ClientAppointment.xaml"
            ((HamburgerMenu.HamburgerMenuItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.About_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.appointmentGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\ClientAppointment.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.modifyButton = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\ClientAppointment.xaml"
            this.modifyButton.Click += new System.Windows.RoutedEventHandler(this.modifyButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cancelcancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\ClientAppointment.xaml"
            this.cancelcancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelcancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.confirmCancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\ClientAppointment.xaml"
            this.confirmCancelButton.Click += new System.Windows.RoutedEventHandler(this.confirmCancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.noappointmentMess = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.warningMess = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
