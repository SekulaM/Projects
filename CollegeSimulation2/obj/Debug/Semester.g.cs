﻿#pragma checksum "..\..\Semester.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DA72F04DE2FC1144BB28D26D5A1C1399FC8E1511D19DE6820FA16A9F694D5DE9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CollegeSimulation2;
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


namespace CollegeSimulation2 {
    
    
    /// <summary>
    /// Semester
    /// </summary>
    public partial class Semester : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Semester.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtSemester;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Semester.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgStudentsSemester;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Semester.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTestsResults;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Semester.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRetakes;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Semester.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtAlert;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Semester.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNextSemester;
        
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
            System.Uri resourceLocater = new System.Uri("/CollegeSimulation2;component/semester.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Semester.xaml"
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
            this.txtSemester = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.dgStudentsSemester = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.btnTestsResults = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Semester.xaml"
            this.btnTestsResults.Click += new System.Windows.RoutedEventHandler(this.btnTestsResults_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnRetakes = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Semester.xaml"
            this.btnRetakes.Click += new System.Windows.RoutedEventHandler(this.btnRetakes_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtAlert = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.btnNextSemester = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Semester.xaml"
            this.btnNextSemester.Click += new System.Windows.RoutedEventHandler(this.btnNextSemester_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
