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
    public partial class ConsultarStock : Form
    {
        public ConsultarStock()
        {
            InitializeComponent();
        }

        SW_Categoria.SW_Categoria _swCategoria = new SISAR.Mobile.SW_Categoria.SW_Categoria();
        SW_Producto.SW_Producto _swProducto = new SISAR.Mobile.SW_Producto.SW_Producto();
        
        private void ConsultarStock_Load(object sender, EventArgs e)
        {
            DataSet _dsCategoria = new DataSet();
            _dsCategoria = _swCategoria.SelectAll();

            cmbCategoria.DataSource = _dsCategoria.Tables[0];
            cmbCategoria.ValueMember = "Id_Categoria";
            cmbCategoria.DisplayMember = "Nombre";

            DataSet _dsProductos = new DataSet();
            int codigoCategoria = (int)_dsCategoria.Tables[0].Rows[0][0];
            _dsProductos = _swProducto.SelectByCategoryPersonalizado(codigoCategoria, 1);//Poner local
            dgvProductos.DataSource = _dsProductos.Tables[0];

            cmbCategoria.SelectedIndexChanged += new EventHandler(cmbCategoria_SelectedIndexChanged);
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue != null)
            {
                int codigoCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                DataSet _dsProductos = new DataSet();
                _dsProductos = _swProducto.SelectByCategoryPersonalizado(codigoCategoria, 1);//Poner local
                dgvProductos.DataSource = _dsProductos.Tables[0];
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}