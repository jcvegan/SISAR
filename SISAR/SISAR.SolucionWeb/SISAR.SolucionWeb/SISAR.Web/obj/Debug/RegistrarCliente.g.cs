#pragma checksum "C:\Users\Alberto\Desktop\SISAR 2009 2\SISAR\SISAR.SolucionWeb\SISAR.SolucionWeb\SISAR.Web\RegistrarCliente.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "18819CD37985CCEC5F6D4BFADDF8E52F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.3603
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SISAR.Web {
    
    
    public partial class RegistrarCliente : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox txtNroDoc;
        
        internal System.Windows.Controls.TextBox txtNombre;
        
        internal System.Windows.Controls.TextBox txtApellido;
        
        internal System.Windows.Controls.DatePicker dtFechNac;
        
        internal System.Windows.Controls.TextBox txtDireccion;
        
        internal System.Windows.Controls.TextBox txtCorreo;
        
        internal System.Windows.Controls.TextBox txtTelefono;
        
        internal System.Windows.Controls.Button btnRegistrar;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SISAR.Web;component/RegistrarCliente.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtNroDoc = ((System.Windows.Controls.TextBox)(this.FindName("txtNroDoc")));
            this.txtNombre = ((System.Windows.Controls.TextBox)(this.FindName("txtNombre")));
            this.txtApellido = ((System.Windows.Controls.TextBox)(this.FindName("txtApellido")));
            this.dtFechNac = ((System.Windows.Controls.DatePicker)(this.FindName("dtFechNac")));
            this.txtDireccion = ((System.Windows.Controls.TextBox)(this.FindName("txtDireccion")));
            this.txtCorreo = ((System.Windows.Controls.TextBox)(this.FindName("txtCorreo")));
            this.txtTelefono = ((System.Windows.Controls.TextBox)(this.FindName("txtTelefono")));
            this.btnRegistrar = ((System.Windows.Controls.Button)(this.FindName("btnRegistrar")));
        }
    }
}
