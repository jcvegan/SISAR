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
using FluidKit.Controls;
using System.Windows.Media.Media3D;

namespace SISAR.Desktop.Consultas
{
    /// <summary>
    /// Lógica de interacción para VerCarta.xaml
    /// </summary>
    public partial class VerCarta : UserControl
    {
        L_Producto _producto;
        L_Categoria _categoria;
        double listaGrid;
        public VerCarta(double _width)
        {
            InitializeComponent();
            listaGrid = _width;
            this.Loaded += new RoutedEventHandler(VerCarta_Loaded);
            _producto = new L_Producto();
            _categoria = new L_Categoria();
        }

        void VerCarta_Loaded(object sender, RoutedEventArgs e)
        {
            DataSet set = _categoria.SelectAllCategorias();
            foreach (DataRow row in set.Tables[0].Rows)
            {
                ListBox lst = new ListBox();
                lst.ItemsSource = _producto.SelectByCategory(Convert.ToInt32(row["Id_Categoria"].ToString())).Tables[0].DefaultView;
                Label categoria = new Label();
                categoria.Content = row["Nombre"].ToString();
                categoria.HorizontalAlignment = HorizontalAlignment.Center;
                categoria.VerticalAlignment = VerticalAlignment.Center;
                categoria.FontSize = 20;
                lst.ItemsPanel = this.Resources["TemplateItemsPanel"] as ItemsPanelTemplate;
                lst.Template = this.Resources["TemplateControl"] as ControlTemplate;
                lst.ItemTemplate = this.Resources["TemplateItem"] as DataTemplate;
                Grid grid = new Grid();
                grid.Children.Add(lst);
                Expander ex = new Expander();
                ex.ExpandDirection = ExpandDirection.Right;
                ex.HorizontalAlignment = HorizontalAlignment.Left;
                ex.Header = categoria;
                ex.Content = grid;
                ex.Expanded += new RoutedEventHandler(Expander_Expanded);
               Contenedor.Children.Add(ex);
            }
            listaGrid -= Contenedor.Children.Count* 41;
            foreach (Expander ex in Contenedor.Children)
            {
                Grid grid = ex.Content as Grid;
                ListBox list = grid.Children[0] as ListBox;
                list.Width = listaGrid;
            }
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            foreach (Expander ex in Contenedor.Children)
                if(ex != sender as Expander)
                    ex.IsExpanded = false;
        }
    }
}
