﻿#pragma checksum "..\..\..\Administracion\AdministrarReservas.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BD4C7328ABF1A5F4229DE12E4E951A2E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.4927
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using AC.AvalonControlsLibrary.Controls;
using Microsoft.Windows.Controls;
using Microsoft.Windows.Controls.Primitives;
using Schedule;
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


namespace SISAR.Desktop.Administracion {
    
    
    /// <summary>
    /// AdministrarReservas
    /// </summary>
    public partial class AdministrarReservas : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Administracion\AdministrarReservas.xaml"
        internal System.Windows.Controls.GroupBox FormReservas;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Administracion\AdministrarReservas.xaml"
        internal Microsoft.Windows.Controls.DatePicker dpInicio;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Administracion\AdministrarReservas.xaml"
        internal Microsoft.Windows.Controls.DatePicker dpFin;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Administracion\AdministrarReservas.xaml"
        internal Schedule.Schedule CalendarioReservas;
        
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
            System.Uri resourceLocater = new System.Uri("/SISAR.Desktop;component/administracion/administrarreservas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Administracion\AdministrarReservas.xaml"
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
            this.FormReservas = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 2:
            this.dpInicio = ((Microsoft.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.dpFin = ((Microsoft.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.CalendarioReservas = ((Schedule.Schedule)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
