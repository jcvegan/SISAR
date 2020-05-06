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

namespace SISAR.Desktop.Ayuda
{
    /// <summary>
    /// Lógica de interacción para Manual.xaml
    /// </summary>
    public partial class Manual : UserControl
    {
        public Manual()
        {
            InitializeComponent();
            
        }

        public void ImprimirDocumento()
        {
            PrintDialog _print = new PrintDialog();
            if (_print.ShowDialog() == true)
            {
                DocumentPaginator aPag;
                aPag = ((IDocumentPaginatorSource)Documento).DocumentPaginator;
                _print.PrintDocument(aPag, "Manual de Usuario");
            }
        }
    }
}
