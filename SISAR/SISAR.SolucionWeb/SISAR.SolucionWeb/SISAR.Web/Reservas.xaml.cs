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

namespace SISAR.Web
{
    public partial class Reservas : ChildWindow
    {
        public Reservas()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Reservas_Loaded);
        }

        void Reservas_Loaded(object sender, RoutedEventArgs e)
        {
            this.dtReservacion.BlackoutDates.AddDatesInPast();
            
        }
    }
}

