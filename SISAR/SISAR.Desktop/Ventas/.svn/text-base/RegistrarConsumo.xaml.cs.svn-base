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

namespace SISAR.Desktop.Ventas
{
    /// <summary>
    /// Lógica de interacción para RegistrarConsumo.xaml
    /// </summary>
    public partial class RegistrarConsumo : UserControl
    {
        L_Zona _zona;
        L_Distribucion _distribucion;
        L_DistribucionxMesa _distribucionxMesa;
        L_Detalle_Pedido _detalle_Pedido;
        int _idLocal;
        int _idZona = 0;
        public RegistrarConsumo(int _idLocal)
        {
            InitializeComponent();
            _zona = new L_Zona();
            _distribucion = new L_Distribucion();
            _distribucionxMesa = new L_DistribucionxMesa();
            _detalle_Pedido = new L_Detalle_Pedido();
            this._idLocal = _idLocal; 
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

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
                Zonas.Items.Add(_tabItem);
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
                _idZona = Convert.ToInt32(_label.Content.ToString());
                DataRowView _dataRowView= _distribucion.SelectAllById_Zona(_idZona).Tables[0].DefaultView[0];
                DataTable dt = _distribucionxMesa.SelectAllById_Distribucion(Convert.ToInt32(_dataRowView["Id_Distribucion"].ToString())).Tables[0];
                Canvas _zona = ((Zonas.SelectedItem as TabItem).Content as Grid).Children[0] as Canvas;
                _zona.Children.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    Image imagen = new Image();
                    imagen.Source = (this.Resources["Mesa" + row["Id_Mesa"].ToString()] as Image).Source.Clone();
                    Label _label1 = new Label();
                    _label1.Content = row["Numero_Mesa"].ToString();
                    _label1.HorizontalContentAlignment =HorizontalAlignment.Center;
                    _label1.VerticalContentAlignment = VerticalAlignment.Center;
                    _label1.FontSize = 15;
                    Grid _grid = new Grid();
                    _grid.Height = Convert.ToDouble(row["Height"].ToString());
                    _grid.Width = Convert.ToDouble(row["Width"].ToString());
                    _grid.Children.Add(imagen);
                    _grid.Children.Add(_label1);
                    _grid.MouseDown += new MouseButtonEventHandler(Mesa_MouseDown);
                    _zona.Children.Add(_grid);
                    Canvas.SetLeft(_grid, Convert.ToDouble(row["Posicion_X"].ToString()));
                    Canvas.SetTop(_grid, Convert.ToDouble(row["Posicion_Y"].ToString()));
                    imagen.Name = "id" + row["Id_Mesa"].ToString();
                }
            }
            catch
            {
            }
        }

        private void Mesa_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Grid mesa = sender as Grid;
            int id_mesa = Convert.ToInt32((mesa.Children[1] as Label).Content.ToString());
            DataTable _dataTable  = _detalle_Pedido.SelectAllById_ZonaAndNumero_Mesa(_idZona, id_mesa).Tables[0];
            lvDetallePedido.DataContext = _dataTable.DefaultView;
            decimal total = 0;
            foreach (DataRow _dataRow in _dataTable.Rows)
            {
                total += Convert.ToDecimal( 0+_dataRow["PrecioUnitario"].ToString());
            }
            txtIGV.Text = Math.Round(total * Convert.ToDecimal(0.19),2) + "";
            txtSubTotal.Text = Math.Round(total * Convert.ToDecimal(0.81),2) + "";
            txtTotal.Text = total + "";
        }
    }
}
