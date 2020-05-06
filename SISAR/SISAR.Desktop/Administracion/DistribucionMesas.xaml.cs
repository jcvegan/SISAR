using System.Data;
using System.Windows;
using System.Windows.Controls;
using SISAR.GragAndGrop;
using SISAR.Logica;
using System.Windows.Media;
using System;
using SISAR.Entidades;
using System.Windows.Media.Imaging;
using System.Windows.Input;

namespace SISAR.Desktop.Administracion
{
    /// <summary>
    /// Lógica de interacción para DistribucionMesas.xaml
    /// </summary>
    public partial class DistribucionMesas : UserControl
    {
        L_Mesa _mesa;
        L_Zona _zona;
        L_Distribucion _distribucion;
        L_DistribucionxMesa _distribucionxMesa;
        int _idLocal;
        public DistribucionMesas(int _idLocal)
        {
            InitializeComponent();
            _mesa = new L_Mesa();
            _zona = new L_Zona();
            _distribucion = new L_Distribucion();
            _distribucionxMesa = new L_DistribucionxMesa();
            this._idLocal = _idLocal; 
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            #region C A N V A S

            CanvasDataProvider<Canvas, Image> canvasImageDataProvider = new CanvasDataProvider<Canvas, Image>("CanvasImageObject");
            CanvasDataConsumer<Canvas, Image> canvasImageDataConsumer = new CanvasDataConsumer<Canvas, Image>(new string[] { "CanvasImageObject" });

            DragManager dragHelpertrash = new DragManager(this.trash, canvasImageDataProvider);
            DropManager dropHelpertrash = new DropManager(this.trash, canvasImageDataConsumer);

            #endregion

            list.ItemsSource = _mesa.SelectAll().Tables[0].DefaultView;
            list.ItemTemplate = this.Resources["TemplateItem"] as DataTemplate;

            DataTable dt = _zona.SelectAllById_Local(_idLocal).Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                TabItem _tabItem = new TabItem();
                StackPanel _stackpanel = new StackPanel();
                _stackpanel.Orientation = Orientation.Horizontal;
                Label id = new Label();
                id.Content = row["Id_Zona"].ToString();
                id.Visibility = Visibility.Collapsed;
                Label nombre = new Label();
                nombre.Content = row["Nombre"].ToString();
                _stackpanel.Children.Add(id);
                _stackpanel.Children.Add(nombre);
                _tabItem.Header = _stackpanel;
                Grid _grid = new Grid();
                Canvas _canvas = new Canvas();
                _canvas.Background = Brushes.Transparent;
                _grid.Children.Add(_canvas);
                _tabItem.Content = _grid;
                DragManager dragHelperCanvas0 = new DragManager(_canvas, canvasImageDataProvider);
                DropManager dropHelperCanvas0 = new DropManager(_canvas, canvasImageDataConsumer);

                Zonas.Items.Add(_tabItem);
            }
        }

        private void lvDistribucion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvDistribucion.SelectedItem != null)
            {
                DataRowView view = lvDistribucion.SelectedItem as DataRowView;
                txtID_Distribucion.Text = view["Id_Distribucion"].ToString();
                txtNombre.Text = view["Nombre"].ToString();
                txtDescripcion.Text = view["Descripcion"].ToString();
                chbEstado.IsChecked = Convert.ToBoolean(view["Estado"].ToString());
                DataTable dt = _distribucionxMesa.SelectAllById_Distribucion(Convert.ToInt32(view["Id_Distribucion"].ToString())).Tables[0];
                Canvas _zona = ((Zonas.SelectedItem as TabItem).Content as Grid).Children[0] as Canvas;
                _zona.Children.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    Image imagen = new Image();
                    imagen.Height = Convert.ToDouble(row["Height"].ToString());
                    imagen.Width = Convert.ToDouble(row["Width"].ToString());
                    imagen.Source = (this.Resources["Mesa" + row["Id_Mesa"].ToString()] as Image).Source.Clone();
                    _zona.Children.Add(imagen);
                    Canvas.SetLeft(imagen,Convert.ToDouble(row["Posicion_X"].ToString()));
                    Canvas.SetTop(imagen,Convert.ToDouble(row["Posicion_Y"].ToString()));
                    imagen.Name = "id"+row["Id_Mesa"].ToString();
                }
            }
        }

        private void Zonas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                TabControl _tabControl = sender as TabControl;
                TabItem _tabItem = _tabControl.SelectedItem as TabItem;
                StackPanel _stackPanel = _tabItem.Header as StackPanel;
                Label _label = _stackPanel.Children[0] as Label;
                int _idZona = Convert.ToInt32(_label.Content.ToString());
                lvDistribucion.DataContext = _distribucion.SelectAllById_Zona(_idZona).Tables[0].DefaultView;
                lvDistribucion.SelectedIndex = 0;
            }
            catch
            { 
            }
        }
        #region Metodos de Enlace
        public void RegistroDistribucionMesas()
        {
            try
            {
                if (string.IsNullOrEmpty(txtID_Distribucion.Text))
                {
                    NuevoDistribucionMesas();
                    ConsultarDistribucionMesas();
                }
                else
                {
                    ActualizarDistribucionMesas();
                    ConsultarDistribucionMesas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void NuevoDistribucionMesas()
        {
            T_Distribucion _distribucionNuevo = new T_Distribucion();
            T_DistribucionxMesa _distribucionxMesaNueva = new T_DistribucionxMesa();
            LeerDatos(_distribucionNuevo);
            MessageBox.Show(_distribucion.Insert(_distribucionNuevo));
            Canvas _zona = ((Zonas.SelectedItem as TabItem).Content as Grid).Children[0] as Canvas;
            int i =0;
            foreach (UIElement mesa in _zona.Children)
                if (mesa is Image)
                {
                    _distribucionxMesaNueva.Id_Distribucion = _distribucionNuevo.Id_Distribucion;
                    _distribucionxMesaNueva.Posicion_X = Convert.ToDecimal(Canvas.GetLeft(mesa));
                    _distribucionxMesaNueva.Posicion_Y = Convert.ToDecimal(Canvas.GetTop(mesa));
                    _distribucionxMesaNueva.Estado = "Webin";
                    _distribucionxMesaNueva.Numero_Mesa = ++i;
                    _distribucionxMesaNueva.Id_Mesa = Convert.ToInt32((mesa as Image).Name.Remove(0, 2));
                    _distribucionxMesa.Insert(_distribucionxMesaNueva);
                }
        }
        private void ActualizarDistribucionMesas()
        {
            T_Distribucion _distribucionActualizado = new T_Distribucion();
            LeerDatos(_distribucionActualizado);
            MessageBox.Show(_distribucion.Update(_distribucionActualizado));
            _distribucionxMesa.DeleteAllById_Distribucion(_distribucionActualizado.Id_Distribucion);
            Canvas _zona = ((Zonas.SelectedItem as TabItem).Content as Grid).Children[0] as Canvas;
            int i = 0;
            foreach (UIElement mesa in _zona.Children)
                if (mesa is Image)
                    _distribucionxMesa.Insert(new T_DistribucionxMesa
                    {
                        Id_Distribucion = _distribucionActualizado.Id_Distribucion,
                        Posicion_X = Convert.ToDecimal(Canvas.GetLeft(mesa)),
                        Posicion_Y = Convert.ToDecimal(Canvas.GetTop(mesa)),
                        Estado = "Webin",
                        Numero_Mesa = ++i,
                        Id_Mesa = Convert.ToInt32((mesa as Image).Name.Remove(0, 2))
                    });
        }
        private void LeerDatos(T_Distribucion _distribucion)
        {
            _distribucion.Id_Distribucion = Convert.ToInt32(0+txtID_Distribucion.Text);
            _distribucion.Descripcion = txtDescripcion.Text;
            _distribucion.Nombre = txtNombre.Text;
            _distribucion.Estado =Convert.ToBoolean(chbEstado.IsChecked);
            _distribucion.Id_Zona = Convert.ToInt32((((Zonas.SelectedItem as TabItem).Header as StackPanel).Children[0] as Label).Content.ToString());
        }
        public void EliminarDistribucionMesas()
        {
            _distribucion.Delete(Convert.ToInt32(txtID_Distribucion.Text));
            ConsultarDistribucionMesas();
        }
        public void ConsultarDistribucionMesas()
        {
            int _idZona = Convert.ToInt32((((Zonas.SelectedItem as TabItem).Header as StackPanel).Children[0] as Label).Content.ToString());
            lvDistribucion.DataContext = _distribucion.SelectAllById_Zona(_idZona).Tables[0].DefaultView;
        }
        public void LimpiarDistribucionMesas()
        {
            txtID_Distribucion.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chbEstado.IsChecked= false;
            Canvas _zona = ((Zonas.SelectedItem as TabItem).Content as Grid).Children[0] as Canvas;
            _zona.Children.Clear();
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
