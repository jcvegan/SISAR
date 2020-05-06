using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace SISAR.Desktop.Administracion
{
    /// <summary>
    /// Lógica de interacción para AdministrarReservas.xaml
    /// </summary>
    public partial class AdministrarReservas : UserControl
    {
        public AdministrarReservas()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(AdministrarReservas_Loaded);
        }

        void AdministrarReservas_Loaded(object sender, RoutedEventArgs e)
        {
            //ObservableCollection<DateTime> intervalo = new ObservableCollection<DateTime>();
            //intervalo.Add(DateTime.Today);
            //CalendarioReservas.DisplayedDates=intervalo;
            dpInicio.SelectedDate = DateTime.Now;            
        }

        private void Digito_KeyDown(object sender, KeyEventArgs e)
        {
            Validators validators = new Validators();
            if (!validators.IsDigit(e.Key))
                e.Handled = true;
        }
        private void Letra_KeyDown(object sender, KeyEventArgs e)
        {
            Validators validators = new Validators();
            if (!validators.IsLetter(e.Key))
                e.Handled = true;
        }
        private void LetraODigito_KeyDown(object sender, KeyEventArgs e)
        {
            Validators validators = new Validators();
            if (!validators.IsLetterOrDigit(e.Key))
                e.Handled = true;
        }
    }
}
