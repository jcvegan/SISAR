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
using SISAR.Web.UsuarioService;

namespace SISAR.Web
{
    public partial class MainPage : UserControl
    {
        Login _login;
        ModifyUser _userUpdate;
        int _userID;
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            lstSeleccion.Items.Remove(lstItemReservas);
            lstSeleccion.Items.Remove(lstItemModifica);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems != null)
            {
                if ((lstSeleccion.SelectedItem as ListBoxItem) == lstItemArea)
                {
                    _login = new Login();
                    _login.ButtonLogin.Click += new RoutedEventHandler(ButtonLogin_Click);
                    _login.Show();
                }
                if ((lstSeleccion.SelectedItem as ListBoxItem) == lstItemModifica)
                {
                    _userUpdate = new ModifyUser();
                    _userUpdate.DataContext = this.DataContext;
                    _userUpdate.btnConfirmar.Click += new RoutedEventHandler(btnConfirmar_Click);
                    _userUpdate.Show();
                }
                if ((lstSeleccion.SelectedItem as ListBoxItem) == lstItemQuienesSomos)
                {
                    QuienesSomos _quien = new QuienesSomos();
                    _quien.Show();
                }
                if ((lstSeleccion.SelectedItem as ListBoxItem) == lstItemReservas)
                {
                    Reservas _reservas = new Reservas();
                    _reservas.Show();
                }
                if ((lstSeleccion.SelectedItem as ListBoxItem) == lstItemUbicanos)
                {
                    Ubicanos _ubicanos = new Ubicanos();
                    _ubicanos.Show();
                }
            }
        }

        void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            if(_userUpdate.txtPassword.Password=="" || (_userUpdate.txtPassword.Password==_userUpdate.txtConfPassword.Password))
            {
                T_Usuario _us = _userUpdate.DataContext as T_Usuario;
                _us.contraseñaField = _userUpdate.txtPassword.Password;
                var _UserProxy = new SISAR.Web.UsuarioService.UsuarioServiceClient();
                _UserProxy.UpdateAsync(_us);
                _UserProxy.UpdateCompleted += new EventHandler<UpdateCompletedEventArgs>(_UserProxy_UpdateCompleted);
            }
            else
            {
                MessageBox.Show("La contraseña ingresada no es la misma");
            }
        }

        void _UserProxy_UpdateCompleted(object sender, UpdateCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
        }

        void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (_login.txtUsuario.Text == "" || _login.txtContraseña.Password == "")
            {
                MessageBox.Show("Por favor ingrese su usuario y su contraseña. Sino registrece como usuario", "Error", MessageBoxButton.OK);
            }
            else
            {
                _userID=int.Parse(_login.txtUsuario.Text);
                var _UserProxy = new SISAR.Web.UsuarioService.UsuarioServiceClient();
                _UserProxy.AuthenticateAsync(_userID, _login.txtContraseña.Password);
                _UserProxy.AuthenticateCompleted += new EventHandler<SISAR.Web.UsuarioService.AuthenticateCompletedEventArgs>(_UserProxy_AuthenticateCompleted);
            }
        }

        void _UserProxy_AuthenticateCompleted(object sender, SISAR.Web.UsuarioService.AuthenticateCompletedEventArgs e)
        {
            //try
            //{
                T_Usuario _user= new T_Usuario();
                _user = e.Result;
                _user.id_UsuarioField = _userID;
                this.DataContext = _user;
                this.GroupEndSession.Visibility = Visibility.Visible;
                this.GroupLogin.Visibility = Visibility.Collapsed;
                _login.DataContext = this.DataContext; ;
                _login.DialogResult = true;
                lstSeleccion.Items.Remove(lstItemArea);
                lstSeleccion.Items.Add(lstItemReservas);
                lstSeleccion.Items.Add(lstItemModifica);
            //}
            //catch
            //{
            //    _login.DialogResult = false;
            //}
        }

        private void btnEndSession_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = null;
        }
    }
}
