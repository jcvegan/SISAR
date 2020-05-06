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
using System.ComponentModel;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

namespace SISAR.Desktop.Atencion
{
    /// <summary>
    /// Lógica de interacción para ConfirmarPedidos.xaml
    /// </summary>
    public partial class ConfirmarPedidos : UserControl
    {
        #region Variables
        L_Detalle_Pedido _LdetallePedido;
        T_Detalle_Pedido _detellePedido;
        int _idLocal;
        #endregion 

        public ConfirmarPedidos(int _idLocal)
        {
            InitializeComponent();
            _LdetallePedido = new L_Detalle_Pedido();
            _detellePedido = new T_Detalle_Pedido();
            this._idLocal = _idLocal;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ConsultarPedidos();
        }
        private void Listo_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row =ListaPedidos.SelectedItem as DataRowView;
            _detellePedido.Id_Detalle_Pedido = Convert.ToInt32(row[0].ToString());
            _detellePedido.Estado = T_Detalle_Pedido.PREPARADO;
            _LdetallePedido.UpdateEstado(_detellePedido);
            ConsultarPedidos();
        }
        private void ConsultarPedidos()
        {
            ListaPedidos.DataContext = _LdetallePedido.SelectAllById_Local(_idLocal).Tables[0].DefaultView;
        }
    }
}
