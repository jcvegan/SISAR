using System;
using System.Collections.Generic;
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
using System.IO;

namespace SISAR.Desktop.Ventas
{
    /// <summary>
    /// Lógica de interacción para AbiriCaja.xaml
    /// </summary>
    public partial class AbrirCaja : UserControl
    {
        public AbrirCaja()
        {
            InitializeComponent();
        }
        public void RegistroCaja()
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("AbrirCaja-" + DateTime.Now.ToLongDateString() + ".ac");
                sw.WriteLine("Soles");
                foreach (UIElement element in Soles.Children)
                    if (element is TextBox)
                    {
                        TextBox _label = element as TextBox;
                        sw.WriteLine(_label.Name + " " + _label.Text);
                    }                
                sw.WriteLine("Dolares");
                foreach (UIElement element in Dolares.Children)
                    if (element is TextBox)
                    {
                        TextBox _label = element as TextBox;
                        sw.WriteLine(_label.Name + " " + _label.Text);
                    }
                    else if (element is StackPanel)
                    {
                        TextBox _label = (element as StackPanel).Children[1] as TextBox;
                        sw.WriteLine(_label.Name + " " + _label.Text);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                sw.Close();
            }
        }

        internal void LimpiarCaja()
        {
            foreach (UIElement element in Soles.Children)
                if (element is TextBox)
                {
                    TextBox _label = element as TextBox;
                    _label.Text = "";
                }
            foreach (UIElement element in Dolares.Children)
                if (element is TextBox)
                {
                    TextBox _label = element as TextBox;
                    _label.Text = "";
                } 
        }

        private void Total_TextChanged(object sender, TextChangedEventArgs e)
        {
            int[] soles ={Convert.ToInt32(0+txt10centimos.Text),
                                  Convert.ToInt32(0+txt20centimos.Text), 
                                  Convert.ToInt32(0+txt50centimos.Text), 
                                  Convert.ToInt32(0+txt1Sol.Text),
                                  Convert.ToInt32(0+txt2Soles.Text),
                                  Convert.ToInt32(0+txt5Soles.Text),
                                  Convert.ToInt32(0+txt10Soles.Text),
                                  Convert.ToInt32(0+txt20Soles.Text),
                                  Convert.ToInt32(0+txt50Soles.Text),
                                  Convert.ToInt32(0+txt100Soles.Text),
                                  Convert.ToInt32(0+txt200Soles.Text)};
            decimal[] valor = { 0.10m, 0.20m, 0.50m, 1.00m, 2.00m, 5.00m, 10.00m, 20.00m, 50.00m, 100.00m, 200.00m };
            decimal total = 0;
            for (int i = 0; i < soles.Count(); i++)
                for (int j = 0; j < soles[i]; j++)
                    total += valor[i];
            txtTotal.Text = total + "";
        }

        private void TotalDolar_TextChanged(object sender, TextChangedEventArgs e)
        {
            int[] dolares ={Convert.ToInt32(0+txt1dolar.Text),
                                  Convert.ToInt32(0+txt2dolar.Text), 
                                  Convert.ToInt32(0+txt5dolar.Text), 
                                  Convert.ToInt32(0+txt10dolar.Text),
                                  Convert.ToInt32(0+txt20dolar.Text),
                                  Convert.ToInt32(0+txt50dolar.Text),
                                  Convert.ToInt32(0+txt100dolar.Text)};
            decimal[] valor = { 1.00m, 2.00m, 5.00m, 10.00m, 20.00m, 50.00m, 100.00m };
            decimal total = 0;
            for (int i = 0; i < dolares.Count(); i++)
                for (int j = 0; j < dolares[i]; j++)
                    total += valor[i];
            txtTotalDolar.Text = total + "";
        }
        
        private void Digito_KeyDown(object sender, KeyEventArgs e)
        {
            Validators validators = new Validators();
            if (!validators.IsDigit(e.Key))
                e.Handled = true;
        }
    }
}
