﻿#pragma checksum "..\..\OdstraniOseboIzPodjejta.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7191F1770651EE4AD9166C23E96FE5FB8C900979"
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
using WpfApp;


namespace WpfApp {
    
    
    /// <summary>
    /// OdstraniOseboIzPodjejta
    /// </summary>
    public partial class OdstraniOseboIzPodjejta : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\OdstraniOseboIzPodjejta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridViewOseba;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\OdstraniOseboIzPodjejta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridViewPod;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\OdstraniOseboIzPodjejta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bttPotrdi;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\OdstraniOseboIzPodjejta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bttPreklici;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp;component/odstranioseboizpodjejta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OdstraniOseboIzPodjejta.xaml"
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
            this.dataGridViewOseba = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.dataGridViewPod = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.bttPotrdi = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\OdstraniOseboIzPodjejta.xaml"
            this.bttPotrdi.Click += new System.Windows.RoutedEventHandler(this.bttPotrdi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bttPreklici = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\OdstraniOseboIzPodjejta.xaml"
            this.bttPreklici.Click += new System.Windows.RoutedEventHandler(this.bttPreklici_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

