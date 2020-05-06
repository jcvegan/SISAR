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
    public partial class MainPage : UserControl
    {
        ListBoxItem lstCerrarSesion;
        public MainPage()
        {
            InitializeComponent();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            Login _login = new Login();
            _login.Show();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems != null)
            {
                if ((lstSeleccion.SelectedItem as ListBoxItem) == lstItemArea)
                {
                    Login _login = new Login();
                    
                    _login.Show();
                    if (_login.DialogResult == true)
                    {
                        lstCerrarSesion = new ListBoxItem();
                        lstCerrarSesion.Content = "Cerrar Sesión";
                        lstSeleccion.Items.Add(lstCerrarSesion);
                        lstSeleccion.Items.Remove(lstItemArea);
                    }
                    
                    //lstItemArea.Visibility = Visibility.Collapsed;
                }
                if ((lstSeleccion.SelectedItem as ListBoxItem) == lstItemQuienesSomos)
                {
                    About _about = new About();
                    _about.Show();
                }
                if ((lstSeleccion.SelectedItem as ListBoxItem) == lstItemUbicanos)
                {
                    Ubicanos _ubicanos = new Ubicanos();
                    _ubicanos.Show();
                }
                if ((lstSeleccion.SelectedItem as ListBoxItem) == lstItemMenu)
                {
                    MenuDeHoy _menu = new MenuDeHoy();
                    _menu.Show();
                }
            }
        }
    }
}
