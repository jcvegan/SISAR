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
using System.Text;
using SISAR.Web.ReservaService;

namespace SISAR.Web
{
    public partial class MainPage : UserControl
    {
        Login _login;
        ModifyUser _userUpdate;
        Ubicanos _ubicanos;
        RegistrarCliente _register;
        String mAlfabeto = "1234567890qazwsxedcrfvtgbyhnujmikolpQAZWSXEDCRFVTGBYHNUJMIKOLP";
        StringBuilder _clave;
        T_Usuario _user;
        T_Reserva _reserva;
        Reservas _reservas;
        UsuarioService.UsuarioServiceClient _UserProxy;
        MailService.MailServiceClient _MailProxy;
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
                    LoginUser();
                    
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
                    _reservas = new Reservas();
                    _reservas.btnReservar.Click += new RoutedEventHandler(btnReservar_Click);
                    _reservas.Show();
                }
                if ((lstSeleccion.SelectedItem as ListBoxItem) == lstItemUbicanos)
                {
                    _ubicanos = new Ubicanos();
                    LocalService.LocalServiceClient _proxyLocal = new SISAR.Web.LocalService.LocalServiceClient();
                    _proxyLocal.SelectAllAsync();
                    _proxyLocal.SelectAllCompleted += new EventHandler<SISAR.Web.LocalService.SelectAllCompletedEventArgs>(_proxyLocal_SelectAllCompleted);
                }
                if ((lstSeleccion.SelectedItem as ListBoxItem) == lstItemRegistro)
                {
                    _register = new RegistrarCliente();
                    _register.btnRegistrar.Click += new RoutedEventHandler(btnRegistrar_Click);
                    _register.Show();

                }
            }
        }

        private void LoginUser()
        {
            _login = new Login();
            _login.ButtonLogin.Click += new RoutedEventHandler(ButtonLogin_Click);
            _login.Show();
        }

        void btnReservar_Click(object sender, RoutedEventArgs e)
        {
            _reserva = new T_Reserva();
            _reserva.fecha_ReservaField = (DateTime)_reservas.dtReservacion.SelectedDate;
            _reserva.id_UsuarioField = _userID;
            ReservaService.ReservaServiceClient _reserve = new ReservaServiceClient();
            _reserve.RegistrarReservaAsync(_reserva);
            _reserve.RegistrarReservaCompleted += new EventHandler<RegistrarReservaCompletedEventArgs>(_reserve_RegistrarReservaCompleted);
        }

        void _reserve_RegistrarReservaCompleted(object sender, RegistrarReservaCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
        }

        void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {

            _clave = new StringBuilder(6, 6);
            Random _rd = new Random();
            for (int i = 0; i <= 5; i++)
            {
                int posAleatorio = _rd.Next(0, mAlfabeto.Length - 1);
                _clave.Append(mAlfabeto[posAleatorio]);
            }
            _user = new T_Usuario();
            _user.fecha_RegistroField = DateTime.Now;
            _user.contraseñaField = _clave.ToString();
            _user.apellidosField = _register.txtApellido.Text;
            _user.nombresField = _register.txtNombre.Text;
            _user.direccionField = _register.txtDireccion.Text;
            _user.fecha_NacimientoField = (DateTime)_register.dtFechNac.SelectedDate;
            _user.emailField = _register.txtCorreo.Text;
            _user.telefonoField = _register.txtTelefono.Text;
            _user.id_PerfilField = 6;
            _user.estadoField = "ACTIVO";
            _user.id_UsuarioField = int.Parse(_register.txtNroDoc.Text);
            _UserProxy = new UsuarioServiceClient();
            _UserProxy.RegisterAsync(_user);
            _UserProxy.RegisterCompleted += new EventHandler<RegisterCompletedEventArgs>(_UserProxy_RegisterCompleted);
            
            
        }

        void _UserProxy_RegisterCompleted(object sender, RegisterCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
            _MailProxy = new SISAR.Web.MailService.MailServiceClient();
            _MailProxy.SendMailAsync(_user.id_UsuarioField, _user.contraseñaField, _user.emailField);
            _MailProxy.SendMailCompleted += new EventHandler<SISAR.Web.MailService.SendMailCompletedEventArgs>(_MailProxy_SendMailCompleted);
            
        }

        void _MailProxy_SendMailCompleted(object sender, SISAR.Web.MailService.SendMailCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
        }

        void _proxyLocal_SelectAllCompleted(object sender, SISAR.Web.LocalService.SelectAllCompletedEventArgs e)
        {
            _ubicanos.lstLocales.ItemsSource = e.Result.Nodes;
            _ubicanos.Show();
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
                try
                {
                    _userID = int.Parse(_login.txtUsuario.Text);
                    var _UserProxy = new SISAR.Web.UsuarioService.UsuarioServiceClient();
                    _UserProxy.AuthenticateAsync(_userID, _login.txtContraseña.Password);
                    _UserProxy.AuthenticateCompleted += new EventHandler<SISAR.Web.UsuarioService.AuthenticateCompletedEventArgs>(_UserProxy_AuthenticateCompleted);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void _UserProxy_AuthenticateCompleted(object sender, SISAR.Web.UsuarioService.AuthenticateCompletedEventArgs e)
        {
            try
            {
                T_Usuario _user= new T_Usuario();
                _user = e.Result;
                _user.id_UsuarioField = _userID;
                this.DataContext = _user;
                this.GroupEndSession.Visibility = Visibility.Visible;
                this.GroupLogin.Visibility = Visibility.Collapsed;
                _login.DataContext = this.DataContext; ;
                _login.DialogResult = true;
                lstSeleccion.Items.Remove(lstItemArea);
                lstSeleccion.Items.Remove(lstItemRegistro);
                lstSeleccion.Items.Add(lstItemReservas);
                lstSeleccion.Items.Add(lstItemModifica);
            }
            catch
            {
                _login.DialogResult = false;
            }
        }

        private void btnEndSession_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = null;
            lstSeleccion.Items.Remove(lstItemReservas);
            lstSeleccion.Items.Remove(lstItemModifica);
            lstSeleccion.Items.Add(lstItemArea);
            lstSeleccion.Items.Add(lstItemRegistro);
            GroupLogin.Visibility = Visibility.Visible;
            GroupEndSession.Visibility = Visibility.Collapsed;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginUser();
        }
    }
}
