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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnConsultarStock_Click(object sender, EventArgs e)
        {
            ConsultarStock app = new ConsultarStock();
            app.ShowDialog();
        }

        private void btnTomarOrden_Click(object sender, EventArgs e)
        {
            AdministrarPedido app = new AdministrarPedido();
            app.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //Login app = new Login();

            //if (app.ShowDialog() == DialogResult.OK)
            //{
            //    this.ShowDialog();
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }
    }
}