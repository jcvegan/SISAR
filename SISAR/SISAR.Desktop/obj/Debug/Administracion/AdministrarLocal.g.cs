﻿#pragma checksum "..\..\..\Administracion\AdministrarLocal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "37BFAA7F47C8B0280700748E0CD02B0F"
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


namespace SISAR.Desktop.Administracion {
    
    
    /// <summary>
    /// AdministrarLocal
    /// </summary>
    public partial class AdministrarLocal : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\Administracion\AdministrarLocal.xaml"
        internal System.Windows.Controls.GroupBox Form;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Administracion\AdministrarLocal.xaml"
        internal System.Windows.Controls.TextBox txtCodigo;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Administracion\AdministrarLocal.xaml"
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Administracion\AdministrarLocal.xaml"
        internal System.Windows.Controls.TextBox txtDireccion;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Administracion\AdministrarLocal.xaml"
        internal System.Windows.Controls.TextBox txtTelefono;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Administracion\AdministrarLocal.xaml"
        internal System.Windows.Controls.ListView lvLocal;
        
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
            System.Uri resourceLocater = new System.Uri("/SISAR.Desktop;component/administracion/administrarlocal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Administracion\AdministrarLocal.xaml"
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
            
            #line 4 "..\..\..\Administracion\AdministrarLocal.xaml"
            ((SISAR.Desktop.Administracion.AdministrarLocal)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Form = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 3:
            this.txtCodigo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\Administracion\AdministrarLocal.xaml"
            this.txtNombre.KeyDown += new System.Windows.Input.KeyEventHandler(this.Letra_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtDireccion = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\Administracion\AdministrarLocal.xaml"
            this.txtDireccion.KeyDown += new System.Windows.Input.KeyEventHandler(this.LetraODigito_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtTelefono = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\Administracion\AdministrarLocal.xaml"
            this.txtTelefono.KeyDown += new System.Windows.Input.KeyEventHandler(this.Digito_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lvLocal = ((System.Windows.Controls.ListView)(target));
            
            #line 29 "..\..\..\Administracion\AdministrarLocal.xaml"
            this.lvLocal.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvLocal_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
