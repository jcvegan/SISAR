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
    public partial class Login : Form
    {
        SW_Usuario.SW_Usuario _swUsuario = new SISAR.Mobile.SW_Usuario.SW_Usuario();


        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CargarDatos()
        {
            DataSet _dsCategoria = new DataSet();
            _dsCategoria = _swUsuario.SelectUsuarioByLocalxPerfil(1, 4);

            cmbMesero.DataSource = _dsCategoria.Tables[0];
            cmbMesero.ValueMember = "Id_Usuario";
            cmbMesero.DisplayMember = "Nombres";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}