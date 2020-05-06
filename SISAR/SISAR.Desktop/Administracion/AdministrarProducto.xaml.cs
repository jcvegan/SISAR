using System;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using SISAR.Entidades;
using SISAR.Logica;

namespace SISAR.Desktop.Administracion
{
    /// <summary>
    /// Lógica de interacción para AdministrarProducto.xaml
    /// </summary>
    public partial class AdministrarProducto : System.Windows.Controls.UserControl
    {
        #region Variables
        L_Producto _producto;
        #endregion 
        string _fotoURL = string.Empty;
        byte[] _byteImagenBD = null;

        public AdministrarProducto()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(AdministrarProducto_Loaded);
        }

        void AdministrarProducto_Loaded(object sender, RoutedEventArgs e)
        {
            L_Categoria _categoria = new L_Categoria();
            cmbCategoria.DataContext = _categoria.SelectAll().Tables[0].DefaultView;
            cmbCategoria.SelectedIndex = 0;
            L_Moneda _moneda = new L_Moneda();
            cmbMoneda.DataContext = _moneda.SelectAll().Tables[0].DefaultView;
            cmbMoneda.SelectedIndex = 0;
            ConsultarProducto();
        }

        private void btnSeleccionarFoto_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.Filter = "Archivos de Imagen | *.jpg";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgFotoProducto.Source = new BitmapImage(new Uri(ofd.FileName));
                _fotoURL = ofd.FileName;
            }
        }

        private byte[] Image2byte(Image _img)
        {
            FileStream fs = new FileStream(_fotoURL, FileMode.Open, FileAccess.Read); 
            byte[] _data = new byte[fs.Length]; 
            fs.Read(_data, 0, System.Convert.ToInt32(fs.Length)); 
            fs.Close();
            return _data;
        }

        public void RegistrarProducto()
        {
            try
            {
                T_Producto _producto = new T_Producto(int.Parse(txtIdProducto.Text), txtNombre.Text, txtDescripcion.Text, decimal.Parse(txtPrecioUnitario.Text.ToString()), Image2byte(imgFotoProducto), txtObservaciones.Text,int.Parse(cmbCategoria.SelectedValue.ToString()),int.Parse(cmbMoneda.SelectedValue.ToString()));
                L_Producto _prod= new L_Producto();
                System.Windows.MessageBox.Show(_prod.Insert(_producto));
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void lvProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvProductos.SelectedItem != null)
            {
                DataRowView view = lvProductos.SelectedItem as DataRowView;
                txtIdProducto.Text = view["Id_Producto"].ToString();
                txtNombre.Text = view["Nombre"].ToString();
                txtDescripcion.Text = view["Descripcion"].ToString();
                txtObservaciones.Text = view["Observacion"].ToString();
                cmbCategoria.SelectedValue = view["Id_Categoria"].ToString();
                txtPrecioUnitario.Text = view["PrecioUnitario"].ToString();
                cmbMoneda.SelectedValue = view["Id_Moneda"].ToString();
                _byteImagenBD = (byte[])view["Imagen"];
            }
        }
        #region Metodos de Enlace
        public void RegistroProducto()
        {
            try
            {
                if (lvProductos.SelectedItem == null)
                {
                    NuevoProducto();
                    ConsultarProducto();
                }
                else
                {
                    ActualizarProducto();
                    ConsultarProducto();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void NuevoProducto()
        {
            _producto = new L_Producto();
            T_Producto _ProductoNuevo = new T_Producto();
            LeerDatos(_ProductoNuevo);

            _ProductoNuevo.Imagen = Image2byte(imgFotoProducto as Image);

            System.Windows.MessageBox.Show(_producto.Insert(_ProductoNuevo));
        }
        private void ActualizarProducto()
        {
            _producto = new L_Producto();
            T_Producto _ProductoActualizado = new T_Producto();
            LeerDatos(_ProductoActualizado);

            _ProductoActualizado.Imagen = _byteImagenBD;

            System.Windows.MessageBox.Show(_producto.Update(_ProductoActualizado));
        }
        private void LeerDatos(T_Producto _Producto)
        {
            _Producto.Id_Producto = Convert.ToInt32(0 + txtIdProducto.Text);
            _Producto.Nombre = txtNombre.Text;
            _Producto.Descripcion = txtDescripcion.Text;
            _Producto.Observacion = txtObservaciones.Text;
            _Producto.Id_Categoria = Convert.ToInt32(cmbCategoria.SelectedValue); //Convert.ToInt32((cmbCategoria.SelectedValue as DataRowView)["Id_Categoria"]);
            _Producto.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
            _Producto.Id_Moneda = Convert.ToInt32(cmbMoneda.SelectedValue);//Convert.ToInt32((cmbMoneda.SelectedValue as DataRowView)["Id_Moneda"]);
        }
        public void EliminarProducto()
        {
            _producto = new L_Producto();
            _producto.Delete(Convert.ToInt32(txtIdProducto.Text));
            ConsultarProducto();
        }
        public void ConsultarProducto()
        {
            _producto = new L_Producto();
            lvProductos.DataContext = _producto.SelectAll().Tables[0].DefaultView;
        }
        #endregion


        internal void LimpiarProducto()
        {
            txtIdProducto.Text="";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtObservaciones.Text="";
            cmbCategoria.SelectedIndex =0;
            txtPrecioUnitario.Text = "";
            cmbMoneda.SelectedIndex = 0;
            _byteImagenBD = new byte[255];
        }

        private void txtPrecioUnitario_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (txtPrecioUnitario.Text.Length < 12)
            {
                if (e.Key.ToString().Contains("Num") || e.Key == Key.Decimal)
                    if (!txtPrecioUnitario.Text.Contains("."))
                        return;
                    else
                        e.Handled = true;
                if (e.Key.ToString().Length != 2)
                    e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
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
