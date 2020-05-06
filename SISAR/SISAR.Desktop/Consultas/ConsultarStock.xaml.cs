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

namespace SISAR.Desktop.Consultas
{
    /// <summary>
    /// Lógica de interacción para ConsultarStock.xaml
    /// </summary>
    public partial class ConsultarStock : UserControl
    {
        public ConsultarStock()
        {
            InitializeComponent();
        }
        public void VerIdProducto(bool? _vista)
        {
            if (_vista == false)
            {
                ID_ProductoEntrada.Visibility = Visibility.Collapsed;
                IdProductoBebidas.Visibility = Visibility.Collapsed;
                IdProductoPostres.Visibility = Visibility.Collapsed;
                IdProductoSegundos.Visibility = Visibility.Collapsed;
                IdProductoSopa.Visibility = Visibility.Collapsed;
            }
            else
            {
                ID_ProductoEntrada.Visibility = Visibility.Visible;
                IdProductoBebidas.Visibility = Visibility.Visible;
                IdProductoPostres.Visibility = Visibility.Visible;
                IdProductoSegundos.Visibility = Visibility.Visible;
                IdProductoSopa.Visibility = Visibility.Visible;
            }
        }
        public void VerNombreProducto(bool? _vista)
        {
            if (_vista == false)
            {
                NombreBebidas.Visibility = Visibility.Collapsed;
                NombreEntrada.Visibility = Visibility.Collapsed;
                NombrePostres.Visibility = Visibility.Collapsed;
                NombreSegundos.Visibility = Visibility.Collapsed;
                NombreSopa.Visibility = Visibility.Collapsed;
            }
            else
            {
                NombreBebidas.Visibility = Visibility.Visible;
                NombreEntrada.Visibility = Visibility.Visible;
                NombrePostres.Visibility = Visibility.Visible;
                NombreSegundos.Visibility = Visibility.Visible;
                NombreSopa.Visibility = Visibility.Visible;
            }
        }
        public void VerDescripcionProducto(bool? _vista)
        {
            if (_vista == false)
            {
                DescripcionBebidas.Visibility = Visibility.Collapsed;
                DescripcionEntrada.Visibility = Visibility.Collapsed;
                DescripcionPostres.Visibility = Visibility.Collapsed;
                DescripcionSegundos.Visibility = Visibility.Collapsed;
                DescripcionSopa.Visibility = Visibility.Collapsed;
            }
            else
            {
                DescripcionBebidas.Visibility = Visibility.Visible;
                DescripcionEntrada.Visibility = Visibility.Visible;
                DescripcionPostres.Visibility = Visibility.Visible;
                DescripcionSegundos.Visibility = Visibility.Visible;
                DescripcionSopa.Visibility = Visibility.Visible;
            }
        }
        public void VerCantidadTotal(bool? _vista)
        {
            if (_vista == false)
            {
                CantTotalBebidas.Visibility = Visibility.Collapsed;
                CantTotalEntrada.Visibility = Visibility.Collapsed;
                CantTotalPostres.Visibility = Visibility.Collapsed;
                CantTotalSegundos.Visibility = Visibility.Collapsed;
                CantTotalSopa.Visibility = Visibility.Collapsed;
            }
            else
            {
                CantTotalBebidas.Visibility = Visibility.Visible;
                CantTotalEntrada.Visibility = Visibility.Visible;
                CantTotalPostres.Visibility = Visibility.Visible;
                CantTotalSegundos.Visibility = Visibility.Visible;
                CantTotalSopa.Visibility = Visibility.Visible;
            }
        }
        public void VerCantidadActual(bool? _vista)
        {
            if (_vista == false)
            {
                CantActualBebidas.Visibility = Visibility.Collapsed;
                CantActualEntrada.Visibility = Visibility.Collapsed;
                CantActualPostres.Visibility = Visibility.Collapsed;
                CantActualSegundos.Visibility = Visibility.Collapsed;
                CantActualSopa.Visibility = Visibility.Collapsed;
            }
            else
            {
                CantActualBebidas.Visibility = Visibility.Visible;
                CantActualEntrada.Visibility = Visibility.Visible;
                CantActualPostres.Visibility = Visibility.Visible;
                CantActualSegundos.Visibility = Visibility.Visible;
                CantActualSopa.Visibility = Visibility.Visible;
            }
        }
    }
}
