﻿#pragma checksum "..\..\AbonentsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "401AF7600E21089A0832CA7C63223EA5CE6A2F61217CD6B0E4120BF6506EBFE4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Itogovaya_rabota_provider;
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


namespace Itogovaya_rabota_provider {
    
    
    /// <summary>
    /// AbonentsWindow
    /// </summary>
    public partial class AbonentsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\AbonentsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchPersonalAccount;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AbonentsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearchSurname;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AbonentsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFilterRaions;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AbonentsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFIlterStreets;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\AbonentsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFilterNumberHome;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\AbonentsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgSubscribers;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\AbonentsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbActive;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\AbonentsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbNoActive;
        
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
            System.Uri resourceLocater = new System.Uri("/Itogovaya_rabota_provider;component/abonentswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AbonentsWindow.xaml"
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
            this.tbSearchPersonalAccount = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\AbonentsWindow.xaml"
            this.tbSearchPersonalAccount.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbSearchPersonalAccount_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 28 "..\..\AbonentsWindow.xaml"
            this.tbSearchPersonalAccount.SelectionChanged += new System.Windows.RoutedEventHandler(this.tbSearchSurname_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbSearchSurname = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\AbonentsWindow.xaml"
            this.tbSearchSurname.SelectionChanged += new System.Windows.RoutedEventHandler(this.tbSearchSurname_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbFilterRaions = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\AbonentsWindow.xaml"
            this.cmbFilterRaions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbFilterRaion_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbFIlterStreets = ((System.Windows.Controls.ComboBox)(target));
            
            #line 46 "..\..\AbonentsWindow.xaml"
            this.cmbFIlterStreets.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbFilterStreet_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmbFilterNumberHome = ((System.Windows.Controls.ComboBox)(target));
            
            #line 52 "..\..\AbonentsWindow.xaml"
            this.cmbFilterNumberHome.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbFiltNomerHouse_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgSubscribers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 59 "..\..\AbonentsWindow.xaml"
            this.dgSubscribers.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dgSubscribers_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbActive = ((System.Windows.Controls.CheckBox)(target));
            
            #line 76 "..\..\AbonentsWindow.xaml"
            this.cbActive.Click += new System.Windows.RoutedEventHandler(this.cbActive_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbNoActive = ((System.Windows.Controls.CheckBox)(target));
            
            #line 87 "..\..\AbonentsWindow.xaml"
            this.cbNoActive.Click += new System.Windows.RoutedEventHandler(this.cbActive_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

