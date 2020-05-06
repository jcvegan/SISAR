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
    /// Lógica de interacción para AdministrarMenu.xaml
    /// </summary>
    public partial class AdministrarMenu : UserControl
    {
        #region Variables
        L_Menu _menu;
        L_Detalle_Menu _detalleMenu;
        #endregion 
        public AdministrarMenu()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(AdministrarMenu_Loaded);
            _menu = new L_Menu();
            _detalleMenu = new L_Detalle_Menu();
        }

        void AdministrarMenu_Loaded(object sender, RoutedEventArgs e)
        {
            L_Producto _producto = new L_Producto();
            cmbProducto.DataContext = _producto.SelectAllMenu().Tables[0].DefaultView;
            L_Menu _menu = new L_Menu();
            lvMenu.DataContext = _menu.SelectAll().Tables[0].DefaultView;
        }

        private void lvMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvMenu.SelectedItem != null)
            {
                DataRowView view = lvMenu.SelectedItem as DataRowView;
                txtID_Menu.Text = view["Id_Menu"].ToString();
                txtNombre.Text = view["Nombre"].ToString();
                txtDescripcion.Text = view["Descripcion"].ToString();
                txtObservacion.Text = view["Observacion"].ToString();
                txtPrecio.Text = view["Preciounitario"].ToString();
                foreach(TreeViewItem tree in tvMenu.Items)
                    tree.Items.Clear();
                DataSet set = _detalleMenu.SelectAllById_Menu(Convert.ToInt32(txtID_Menu.Text));
                foreach (DataRow row in set.Tables[0].Rows)
                    foreach (var item in cmbProducto.Items)
                        if (row["Id_Producto"].ToString() == (item as DataRowView)["Id_Producto"].ToString())
                            InsertItem((item as DataRowView));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataRowView view = cmbProducto.SelectedItem as DataRowView;
            InsertItem(view);
        }

        private void InsertItem(DataRowView row)
        {
            TreeViewItem newChild = new TreeViewItem();
            Label productoId = new Label();
            productoId.Content = Convert.ToString(row["Id_Producto"]);
            productoId.Visibility = Visibility.Collapsed;
            Label nombre = new Label();
            nombre.Content = Convert.ToString(row["Nombre"]);
            StackPanel spanel = new StackPanel();
            spanel.Children.Add(productoId);
            spanel.Children.Add(nombre);
            newChild.Header = spanel;
            L_Categoria _categoria = new L_Categoria();
            switch(_categoria.Select(Convert.ToInt32(row["Id_Categoria"])).Nombre)
            {
                case "ENTRADAS":
                    AuxInsertItem(newChild, 0);
                    break;
                case "PLATOS DE FONDO":
                    AuxInsertItem(newChild, 1);
                    break;
                case "POSTRES":
                    AuxInsertItem(newChild, 2);
                    break;
            }
        }

        private void AuxInsertItem(TreeViewItem newChild, int n)
        {
            TreeViewItem treeViewItem = tvMenu.Items[n] as TreeViewItem;
            if (treeViewItem.HasItems)
                foreach (TreeViewItem item in treeViewItem.Items)
                    if (((item.Header as StackPanel).Children[1] as Label).Content.ToString() == ((newChild.Header as StackPanel).Children[1] as Label).Content.ToString())
                        return;
            treeViewItem.Items.Add(newChild);
        }

        #region Metodos de Enlace
        public void RegistroMenu()
        {
            try
            {
                if (string.IsNullOrEmpty(txtID_Menu.Text))
                {
                    NuevoMenu();
                    ConsultarMenu();
                }
                else
                {
                    ActualizarMenu();
                    ConsultarMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void NuevoMenu()
        {
            T_Menu _menuNuevo = new T_Menu();
            List<int> menu = new List<int>();
            LeerDatos(_menuNuevo, menu);
            MessageBox.Show(_menu.Insert(_menuNuevo));
            foreach (int i in menu)
                _detalleMenu.Insert(new T_Detalle_Menu { Id_Menu = _menuNuevo.Id_Menu, Id_Producto = i });
        }
        private void ActualizarMenu()
        {
            T_Menu _menuActualizado = new T_Menu();
            List<int> menu = new List<int>();
            LeerDatos(_menuActualizado, menu);
            _detalleMenu.DeleteAllById_Menu(_menuActualizado.Id_Menu);
            foreach (int i in menu)
                _detalleMenu.Insert(new T_Detalle_Menu { Id_Menu = _menuActualizado.Id_Menu, Id_Producto = i });
            MessageBox.Show(_menu.Update(_menuActualizado));
        }

        private void LeerDatos(T_Menu _menuNuevo, List<int> menu)
        {
            _menuNuevo.Id_Menu = Convert.ToInt32(0+txtID_Menu.Text);
            _menuNuevo.Nombre = txtNombre.Text;
            _menuNuevo.Descripcion = txtDescripcion.Text;
            _menuNuevo.Observacion = txtObservacion.Text;
            _menuNuevo.PrecioUnitario = Convert.ToDecimal(txtPrecio.Text);
            foreach(TreeViewItem _categoria in tvMenu.Items)
                foreach (TreeViewItem _producto in _categoria.Items)
                    menu.Add(Convert.ToInt32(((_producto.Header as StackPanel).Children[0] as Label).Content.ToString()));
        }
        public void EliminarMenu()
        {
            _detalleMenu.DeleteAllById_Menu(Convert.ToInt32(txtID_Menu.Text));
            _menu.Delete(Convert.ToInt32(txtID_Menu.Text));
            ConsultarMenu();
        }
        public void ConsultarMenu()
        {
            lvMenu.DataContext = _menu.SelectAll().Tables[0].DefaultView;
        }
        #endregion

        internal void LimpiarMenu()
        {
            txtID_Menu.Text="";
            txtNombre.Text="";
            txtDescripcion.Text="";
            txtObservacion.Text="";
            txtPrecio.Text="";
            foreach (TreeViewItem tree in tvMenu.Items)
                tree.Items.Clear();
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
