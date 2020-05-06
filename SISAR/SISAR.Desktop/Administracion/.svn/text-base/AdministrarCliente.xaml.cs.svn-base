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
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;
using System.ComponentModel;
using System.Windows.Threading;

namespace SISAR.Desktop.Administracion
{
    /// <summary>
    /// Lógica de interacción para AdministrarCliente.xaml
    /// </summary>
    public partial class AdministrarCliente : UserControl
    {
        #region Variables
        L_Cliente _cliente;
        int _index;
        #endregion        

        #region Constructos
        public AdministrarCliente()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(AdministrarCliente_Loaded);
            _cliente = new L_Cliente();
        }
        #endregion
                
        void AdministrarCliente_Loaded(object sender, RoutedEventArgs e)
        {
            ConsultarClientes();            
        }
        private void lvClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvClientes.SelectedItem != null)
            {
                DataRowView view = lvClientes.SelectedItem as DataRowView;
                txtDNI_Cliente.Text = view["Id_Usuario"].ToString();
                txtNombres.Text = view["Nombres"].ToString();
                txtApellidos.Text = view["Apellidos"].ToString();
                txtTelefono.Text = view["Telefono"].ToString();
                txtDireccion.Text = view["Direccion"].ToString();
                txtEmail.Text = view["Email"].ToString();
                dtFechaRegistro.SelectedDate = Convert.ToDateTime(view["Fecha_Registro"].ToString()).Date;
                txtContraseña.Text = view["Contraseña"].ToString();
                chkActivo.IsChecked = (view["Estado"].ToString()=="ACTIVO");
                dtFechaNacimiento.SelectedDate = Convert.ToDateTime(view["Fecha_Nacimiento"].ToString()).Date;
                _index = lvClientes.SelectedIndex;
            }
        }

        #region Metodos de Enlace
        public void RegistroCliente()
        {
            try
            {
                if (lvClientes.SelectedItem == null)
                {
                    NuevoCliente();
                    ConsultarClientes();
                }
                else
                {
                    ActualizarCliente();
                    ConsultarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void NuevoCliente()
        {
            T_Usuario _clienteNuevo = new T_Usuario();
            LeerDatos(_clienteNuevo);
            MessageBox.Show(_cliente.Insert(_clienteNuevo));
        }
        private void ActualizarCliente()
        {
            T_Usuario _clienteActualizado = new T_Usuario();
            LeerDatos(_clienteActualizado);
            MessageBox.Show(_cliente.Update(_clienteActualizado));
        }
        private void LeerDatos(T_Usuario _clienteNuevo)
        {
            _clienteNuevo.Id_Usuario = Convert.ToInt32(txtDNI_Cliente.Text);
            _clienteNuevo.Nombres = txtNombres.Text;
            _clienteNuevo.Apellidos = txtApellidos.Text;
            _clienteNuevo.Telefono = txtTelefono.Text;
            _clienteNuevo.Direccion = txtDireccion.Text;
            _clienteNuevo.Email = txtEmail.Text;
            _clienteNuevo.Fecha_Registro = Convert.ToDateTime(dtFechaRegistro.SelectedDate);
            _clienteNuevo.Contraseña = txtContraseña.Text;
            _clienteNuevo.Estado = (chkActivo.IsChecked == true ? T_Usuario.ACTIVO : T_Usuario.INACTIVO);
            _clienteNuevo.Fecha_Nacimiento = Convert.ToDateTime(dtFechaNacimiento.SelectedDate);
        }
        public void EliminarCliente()
        {
            _cliente.Delete(Convert.ToInt32(txtDNI_Cliente.Text));
            ConsultarClientes();
        }
        public void ConsultarClientes()
        {
            lvClientes.DataContext = _cliente.SelectAll().Tables[0].DefaultView;
        }
        public void LimpiarCliente()
        {
            txtDNI_Cliente.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            dtFechaRegistro.SelectedDate = DateTime.Now;
            txtContraseña.Text = "";
            chkActivo.IsChecked = false;
            dtFechaNacimiento.SelectedDate = DateTime.Now;
        }
        #endregion

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