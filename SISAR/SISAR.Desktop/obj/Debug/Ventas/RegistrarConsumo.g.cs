﻿#pragma checksum "..\..\..\Ventas\RegistrarConsumo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "89155C49C021F5450FEDF6D111325B0A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.4927
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace SISAR.Desktop.Ventas {
    
    
    /// <summary>
    /// RegistrarConsumo
    /// </summary>
    public partial class RegistrarConsumo : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Ventas\RegistrarConsumo.xaml"
        internal System.Windows.Controls.TabControl Zonas;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Ventas\RegistrarConsumo.xaml"
        internal System.Windows.Controls.ListView lvDetallePedido;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Ventas\RegistrarConsumo.xaml"
        internal System.Windows.Controls.TextBox txtSubTotal;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Ventas\RegistrarConsumo.xaml"
        internal System.Windows.Controls.TextBox txtIGV;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Ventas\RegistrarConsumo.xaml"
        internal System.Windows.Controls.TextBox txtTotal;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SISAR.Desktop;component/ventas/registrarconsumo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ventas\RegistrarConsumo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\..\Ventas\RegistrarConsumo.xaml"
            ((SISAR.Desktop.Ventas.RegistrarConsumo)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Zonas = ((System.Windows.Controls.TabControl)(target));
            
            #line 17 "..\..\..\Ventas\RegistrarConsumo.xaml"
            this.Zonas.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Zonas_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lvDetallePedido = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.txtSubTotal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtIGV = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtTotal = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
