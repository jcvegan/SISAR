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
    /// Lógica de interacción para AdministrarZona.xaml
    /// </summary>
    public partial class AdministrarZona : UserControl
    {
        #region Variables
        T_Zona _zona;
        L_Zona _lzona;
        int _idlocal;
        #endregion

        public AdministrarZona(int _idlocal)
        {
            InitializeComponent();
            _zona = new T_Zona();
            _lzona = new L_Zona();
            this._idlocal = _idlocal;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ConsultarZona();
        }

        private void lvZona_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvZona.SelectedItem != null)
            {
                DataRowView view = lvZona.SelectedItem as DataRowView;
                txtCodigo.Text = view["Id_Zona"].ToString();
                txtNombre.Text = view["Nombre"].ToString();
                txtDescripcion.Text = view["Descripcion"].ToString();
                txtLocal.Text = view["Id_Local"].ToString();
                txtAforo.Text = view["Aforo"].ToString();
            }
        }

        #region Metodos de Enlace
        public void RegistroZona()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                    NuevoZona();
                else
                    ActualizarZona();
                ConsultarZona();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void NuevoZona()
        {
            LeerDatos(_zona);
            MessageBox.Show(_lzona.Insert(_zona));
        }
        private void ActualizarZona()
        {
            LeerDatos(_zona);
            MessageBox.Show(_lzona.Update(_zona));
        }
        private void LeerDatos(T_Zona _zona)
        {
            _zona.Id_Zona = Convert.ToInt32(0 + txtCodigo.Text);
            _zona.Nombre = txtNombre.Text;
            _zona.Descripcion = txtDescripcion.Text;
            _zona.Id_Local = Convert.ToInt32(txtLocal.Text);
            _zona.Aforo = Convert.ToInt32(txtAforo.Text);
        }
        public void EliminarZona()
        {
            _lzona.Delete(Convert.ToInt32(txtCodigo.Text));
            ConsultarZona();
        }
        public void ConsultarZona()
        {
            lvZona.DataContext = _lzona.SelectAllById_Local(_idlocal).Tables[0].DefaultView;
        }
        public void LimpiarZona()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtAforo.Text = "";
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
