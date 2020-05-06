using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using SISAR.Logica;
using SISAR.Entidades;

namespace SISAR.Desktop.Administracion
{
    /// <summary>
    /// Lógica de interacción para AdministrarEmpleados.xaml
    /// </summary>
    public partial class AdministrarEmpleados : UserControl
    {
        #region Variables
        L_Usuario _usuario;
        int _index;
        #endregion 
        
        #region Constructos
        public AdministrarEmpleados()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(AdministrarEmpleados_Loaded);
            _usuario = new L_Usuario();
        }
        #endregion

        void AdministrarEmpleados_Loaded(object sender, RoutedEventArgs e)
        {
            L_Perfil _perfil = new L_Perfil();
            cbPerfil.DataContext = _perfil.SelectAllforEmploye().Tables[0].DefaultView;
            cbPerfil.SelectedIndex = 0;
            L_Local _local = new L_Local();
            cbLocal.DataContext = _local.SelectAll().Tables[0].DefaultView;
            cbLocal.SelectedIndex = 0;
            ConsultarEmpleado();
        }

        private void lvEmpleado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvEmpleado.SelectedItem != null)
            {
                DataRowView view = lvEmpleado.SelectedItem as DataRowView;
                txtDNI.Text = view["Id_Usuario"].ToString();
                txtNombres.Text = view["Nombres"].ToString();
                txtApellidos.Text = view["Apellidos"].ToString();
                txtTelefono.Text = view["Telefono"].ToString();
                txtDireccion.Text = view["Direccion"].ToString();
                cbLocal.SelectedValue = view["Id_Local"].ToString();
                txtEmail.Text = view["Email"].ToString();
                dtFechaRegistro.SelectedDate = Convert.ToDateTime(view["Fecha_Registro"].ToString()).Date;
                txtContraseña.Text = view["Contraseña"].ToString();
                chkActivo.IsChecked = (view["Estado"].ToString() == "ACTIVO");
                dtFechaNacimiento.SelectedDate = Convert.ToDateTime(view["Fecha_Nacimiento"].ToString()).Date;
                cbPerfil.SelectedValue = view["Id_Perfil"].ToString();
                _index = lvEmpleado.SelectedIndex;
            }
        }

        #region Metodos de Enlace
        public void RegistroCliente()
        {
            try
            {
                if (lvEmpleado.SelectedItem == null)
                {
                    NuevoEmpleado();
                    ConsultarEmpleado();
                }
                else
                {
                    ActualizarEmpleado();
                    ConsultarEmpleado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void NuevoEmpleado()
        {
            T_Usuario _empleadoNuevo = new T_Usuario();
            LeerDatos(_empleadoNuevo);
            MessageBox.Show(_usuario.Insert(_empleadoNuevo));
        }
        private void ActualizarEmpleado()
        {
            T_Usuario _empleadoActualizado = new T_Usuario();
            LeerDatos(_empleadoActualizado);
            MessageBox.Show(_usuario.Update(_empleadoActualizado));
        }
        private void LeerDatos(T_Usuario _clienteNuevo)
        {
            _clienteNuevo.Id_Usuario = Convert.ToInt32(0+txtDNI.Text);
            _clienteNuevo.Nombres = txtNombres.Text;
            _clienteNuevo.Apellidos = txtApellidos.Text;
            _clienteNuevo.Telefono = txtTelefono.Text;
            _clienteNuevo.Direccion = txtDireccion.Text;
            _clienteNuevo.Id_Local = Convert.ToInt32(cbLocal.SelectedValue);
            _clienteNuevo.Email = txtEmail.Text;
            _clienteNuevo.Fecha_Registro = Convert.ToDateTime(dtFechaRegistro.SelectedDate);
            _clienteNuevo.Contraseña = txtContraseña.Text;
            _clienteNuevo.Estado = (chkActivo.IsChecked == true ? T_Usuario.ACTIVO : T_Usuario.INACTIVO);
            _clienteNuevo.Fecha_Nacimiento = Convert.ToDateTime(dtFechaNacimiento.SelectedDate);
            _clienteNuevo.Id_Perfil = Convert.ToInt32(cbPerfil.SelectedValue);
        }
        public void EliminarEmpleado()
        {
            _usuario.Delete(Convert.ToInt32(txtDNI.Text));
            ConsultarEmpleado();
        }
        public void ConsultarEmpleado()
        {
            lvEmpleado.DataContext = _usuario.SelectAllEmployee().Tables[0].DefaultView;
        }
        #endregion

        internal void LimpiarCliente()
        {
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cbLocal.SelectedIndex = 0;
            txtEmail.Text = "";
            dtFechaRegistro.SelectedDate = DateTime.Now;
            txtContraseña.Text = "";
            chkActivo.IsChecked = false;
            dtFechaNacimiento.SelectedDate = DateTime.Now;
            cbPerfil.SelectedIndex = 0;
        }

        private void Digito_KeyDown(object sender, KeyEventArgs e)
        {
            Validators validators = new Validators();
            if (!validators.IsDigit(e.Key))
                e.Handled = true;
        }
        private void Letra_KeyDown(object sender, KeyEventArgs e)
        {
            Validators validators = new Validators();
            if (!validators.IsLetter(e.Key))
                e.Handled = true;
        }
        private void LetraODigito_KeyDown(object sender, KeyEventArgs e)
        {
            Validators validators = new Validators();
            if (!validators.IsLetterOrDigit(e.Key))
                e.Handled = true;
        }
    }
}
