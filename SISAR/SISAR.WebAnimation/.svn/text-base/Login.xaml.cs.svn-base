using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SISAR.WebAnimation
{
    public partial class Login : ChildWindow
    {
        int id_usuario;
        string password;
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            id_usuario = int.Parse(txtUsuario.Text);
            password = txtPassword.Password;

            DialogResult = false;
            if (this.DialogResult == false)
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButton.OK);
            }
        }
    }
}
