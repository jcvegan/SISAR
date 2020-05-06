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

namespace SISAR.Desktop.Administracion
{
    /// <summary>
    /// Lógica de interacción para AdministrarPerfil.xaml
    /// </summary>
    public partial class AdministrarPerfil : UserControl
    {
        #region Variables
        L_Perfil _perfil;
        L_Permiso _permiso;
        L_PerfilxPermiso _perfilxPermiso;
        #endregion   
        
        #region Constructos
        public AdministrarPerfil()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(AdministrarPerfil_Loaded);

        }
        #endregion

        void AdministrarPerfil_Loaded(object sender, RoutedEventArgs e)
        {
            ConsultarPerfil();
            _permiso = new L_Permiso();
            DataSet ds = _permiso.SelectAll();
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                CheckBox chb = new CheckBox();
                chb.Content = r["Permiso"].ToString();
                wpPermiso.Children.Add(chb);
            }
            _perfilxPermiso = new L_PerfilxPermiso();

        }
        private void lvPerfil_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvPrefiles.SelectedItem != null)
            {
                foreach (CheckBox element in wpPermiso.Children)
                    element.IsChecked = false;
                DataRowView view = lvPrefiles.SelectedItem as DataRowView;
                txtID_Perfil.Text = view["Id_Perfil"].ToString();
                txtNombre.Text = view["Nombre"].ToString();
                txtDescripcion.Text = view["Descripcion"].ToString();
                DataSet set = _perfilxPermiso.SelectAllById_Perfil(Convert.ToInt32(txtID_Perfil.Text));
                foreach(CheckBox element in wpPermiso.Children)
                    foreach (DataRow row in set.Tables[0].Rows)
                        if (element.Content.ToString() == row["Permiso"].ToString())
                            element.IsChecked = true;
            }
        }


        #region Metodos de Enlace
        public void RegistroPerfil()
        {
            try
            {
                if (lvPrefiles.SelectedItem == null)
                {
                    NuevoPerfil();
                    ConsultarPerfil();
                }
                else
                {
                    ActualizarPerfil();
                    ConsultarPerfil();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);            
            }
        }
        private void NuevoPerfil()
        {            
            _perfil = new L_Perfil();
            T_Perfil _perfilNuevo = new T_Perfil();
            LeerDatos(_perfilNuevo);
            MessageBox.Show(_perfil.Insert(_perfilNuevo));
        }
        private void ActualizarPerfil()
        {
            _perfil = new L_Perfil();
            T_Perfil _perfilActualizado = new T_Perfil();
            LeerDatos(_perfilActualizado);
            MessageBox.Show(_perfil.Update(_perfilActualizado));
        }
        private void LeerDatos(T_Perfil _perfil)
        {
            _perfil.Id_Perfil = Convert.ToInt32(0+txtID_Perfil.Text);
            _perfil.Nombre = txtNombre.Text;
            _perfil.Descripcion = txtDescripcion.Text;
        }
        public void EliminarPerfil()
        {
            _perfil = new L_Perfil();
            _perfil.Delete(Convert.ToInt32(txtID_Perfil.Text));
            ConsultarPerfil();
        }
        public void ConsultarPerfil()
        {
            _perfil = new L_Perfil();
            lvPrefiles.DataContext = _perfil.SelectAll().Tables[0].DefaultView;
        }
        #endregion

        internal void LimpiarPerfil()
        {
            txtID_Perfil.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            foreach (CheckBox element in wpPermiso.Children)
                element.IsChecked = false;
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
