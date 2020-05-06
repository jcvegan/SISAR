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
using SISAR.Entidades;
using SISAR.Logica;

namespace SISAR.Desktop.Administracion
{
    /// <summary>
    /// Lógica de interacción para AdministrarLocal.xaml
    /// </summary>
    public partial class AdministrarLocal : UserControl
    {
        #region Variables
        T_Local _local;
        L_Local _l_local;
        #endregion

        public AdministrarLocal()
        {
            InitializeComponent();
            _local = new T_Local();
            _l_local = new L_Local();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ConsultarLocal();
        }

        private void lvLocal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvLocal.SelectedItem != null)
            {
                DataRowView view = lvLocal.SelectedItem as DataRowView;
                txtCodigo.Text = view["Id_Local"].ToString();
                txtNombre.Text = view["Nombre"].ToString();
                txtDireccion.Text = view["Direccion"].ToString();
                txtTelefono.Text = view["Telefono"].ToString();
            }
        }

        #region Metodos de Enlace
        public void RegistroLocal()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                    NuevoLocal();
                else
                    ActualizarLocal();
                ConsultarLocal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void NuevoLocal()
        {
            LeerDatos(_local);
            MessageBox.Show(_l_local.Insert(_local));
        }
        private void ActualizarLocal()
        {
            LeerDatos(_local);
            MessageBox.Show(_l_local.Update(_local));
        }
        private void LeerDatos(T_Local _local)
        {
            _local.Id_Local = Convert.ToInt32(0+txtCodigo.Text);
            _local.Nombre = txtNombre.Text;
            _local.Direccion = txtDireccion.Text;
            _local.Telefono = Convert.ToInt32(txtTelefono.Text);
        }
        public void EliminarLocal()
        {
            _l_local.Delete(Convert.ToInt32(txtCodigo.Text));
            ConsultarLocal();
        }
        public void ConsultarLocal()
        {
            lvLocal.DataContext = _l_local.SelectAll().Tables[0].DefaultView;
        }
        public void LimpiarLocal()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
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
