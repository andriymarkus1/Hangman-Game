﻿#pragma checksum "..\..\DifficultySelectionMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D8005CBF821EC7ACFD3644DA038A637059502E749DDEAD27E820E8A03D2F9C27"
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
using System.Windows.Forms.Integration;
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
using Шибениця_2._0;


namespace Шибениця_2._0 {
    
    
    /// <summary>
    /// DifficultySelectionMenu
    /// </summary>
    public partial class DifficultySelectionMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\DifficultySelectionMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas DCanvas;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\DifficultySelectionMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\DifficultySelectionMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DText;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\DifficultySelectionMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton EasyRadio;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\DifficultySelectionMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MidRadio;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\DifficultySelectionMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton HighRadio;
        
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
            System.Uri resourceLocater = new System.Uri("/Шибениця 2.0;component/difficultyselectionmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DifficultySelectionMenu.xaml"
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
            this.DCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.DName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.DText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.EasyRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 59 "..\..\DifficultySelectionMenu.xaml"
            this.EasyRadio.Checked += new System.Windows.RoutedEventHandler(this.EasyRadio_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MidRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 69 "..\..\DifficultySelectionMenu.xaml"
            this.MidRadio.Checked += new System.Windows.RoutedEventHandler(this.MidRadio_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HighRadio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 79 "..\..\DifficultySelectionMenu.xaml"
            this.HighRadio.Checked += new System.Windows.RoutedEventHandler(this.HighRadio_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 89 "..\..\DifficultySelectionMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewGameButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 99 "..\..\DifficultySelectionMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToMenuButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 141 "..\..\DifficultySelectionMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseAppButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

