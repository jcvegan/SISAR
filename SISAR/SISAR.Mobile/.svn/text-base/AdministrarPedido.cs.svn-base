using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SISAR.Mobile
{
    public partial class AdministrarPedido : Form
    {
        SW_Categoria.SW_Categoria _swCategoria = new SISAR.Mobile.SW_Categoria.SW_Categoria();
        SW_Producto.SW_Producto _swProducto = new SISAR.Mobile.SW_Producto.SW_Producto();
        SW_DistribucionxMesa.SW_DistribucionxMesa _swDxM = new SISAR.Mobile.SW_DistribucionxMesa.SW_DistribucionxMesa();

        public AdministrarPedido()
        {
            InitializeComponent();
        }

        private void AdministrarPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //List<T_Producto>
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadDatos()
        {
            //Cargando las Mesas
            DataSet _dsMesa = new DataSet();
            _dsMesa = _swDxM.SelectAll();//Cambiar metodo por uno que discrimine x local y por zona y por cual distribucion esta activa

            cmbMesa.DataSource = _dsMesa;
            cmbMesa.ValueMember = "Id_Codigo_Mesa";
            cmbMesa.DisplayMember = "Numero_Mesa";

            //Cargando las Categorias
            DataSet _dsCategoria = new DataSet();
            _dsCategoria = _swCategoria.SelectAll();

            cmbCategoria.DataSource = _dsCategoria;
            cmbCategoria.ValueMember = "Id_Categoria";
            cmbCategoria.DisplayMember = "Nombre";

            //Cargando los Productos
            DataSet _dsProducto = new DataSet();
            _dsProducto = _swProducto.SelectByCategory((int)_dsCategoria.Tables[0].Rows[0][0]);//Cambiar por uno que discrimine x Local
            cmbProducto.DataSource = _dsProducto;
            cmbProducto.ValueMember = "Id_Producto";
            cmbProducto.DisplayMember = "Nombre";
        }
    }
}