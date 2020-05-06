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
    /// Lógica de interacción para AdministrarCategorias.xaml
    /// </summary>
    public partial class AdministrarCategorias : UserControl
    {
        #region Variables
        L_Categoria _categoria;
        #endregion 

        #region Constructos
        public AdministrarCategorias()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(AdministrarCategoria_Loaded);

        }
        #endregion

        void AdministrarCategoria_Loaded(object sender, RoutedEventArgs e)
        {
            ConsultarCategorias();
        }      
        private void lvCategorias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _categoria = new L_Categoria();
            if (lvCategorias.SelectedItem != null)
            {
                DataRowView view = lvCategorias.SelectedItem as DataRowView;
                txtID_Categoria.Text = view["Id_Categoria"].ToString();
                txtNombre.Text = view["Nombre"].ToString();
                txtDescripcion.Text = view["Descripcion"].ToString();
                lvSubCategorias.DataContext = _categoria.SelectAllByCategoria_Padre(Convert.ToInt32(txtID_Categoria.Text)).Tables[0].DefaultView;
                chbPadre.IsChecked = false;
            }
        }
        private void lvSubCategorias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _categoria = new L_Categoria();
            if (lvSubCategorias.SelectedItem != null)
            {
                DataRowView view = lvSubCategorias.SelectedItem as DataRowView;
                txtID_Categoria.Text = view["Id_Categoria"].ToString();
                txtNombre.Text = view["Nombre"].ToString();
                txtDescripcion.Text = view["Descripcion"].ToString();
                chbPadre.IsChecked = true;
                cmbCategoriaPadre.SelectedValue = view["Categoria_Padre"].ToString();
            }
        }

        #region Metodos de Enlace
        public void RegistroCategoria()
        {
            try
            {
                if ((lvSubCategorias.SelectedItem == null)&&(lvCategorias.SelectedItem ==null))
                {
                    NuevoCategoria();
                    ConsultarCategorias();
                }
                else
                {
                    ActualizarCategoria();
                    ConsultarCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void NuevoCategoria()
        {
            _categoria = new L_Categoria();
            T_Categoria _categoriaNuevo = new T_Categoria();
            LeerDatos(_categoriaNuevo);
            MessageBox.Show(_categoria.Insert(_categoriaNuevo));
        }
        private void ActualizarCategoria()
        {
            _categoria = new L_Categoria();
            T_Categoria _categoriaActualizado = new T_Categoria();
            LeerDatos(_categoriaActualizado);
            MessageBox.Show(_categoria.Update(_categoriaActualizado));
        }
        private void LeerDatos(T_Categoria _CategoriaNuevo)
        {
            _CategoriaNuevo.Id_Categoria = Convert.ToInt32(0+txtID_Categoria.Text);
            _CategoriaNuevo.Nombre = txtNombre.Text;
            _CategoriaNuevo.Descripcion = txtDescripcion.Text;
            if(cmbCategoriaPadre.Visibility ==Visibility.Visible)
                _CategoriaNuevo.Categoria_Padre =Convert.ToInt32(cmbCategoriaPadre.SelectedValue);
        }
        public void EliminarCategoria()
        {
            _categoria = new L_Categoria();
            _categoria.Delete(Convert.ToInt32(txtID_Categoria.Text));
            ConsultarCategorias();
        }
        public void ConsultarCategorias()
        {
            _categoria = new L_Categoria();
            lvCategorias.DataContext = _categoria.SelectAllCategorias().Tables[0].DefaultView;
            cmbCategoriaPadre.DataContext = _categoria.SelectAllCategorias().Tables[0].DefaultView;
        }
        #endregion

        internal void LimpiarCategoria()
        {
            txtID_Categoria.Text = "";
            txtNombre.Text="";
            txtDescripcion.Text="";
            chbPadre.IsChecked = false;
            cmbCategoriaPadre.SelectedIndex = 0;
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
