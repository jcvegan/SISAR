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
using SISAR.GragAndGrop;

namespace SISAR.Desktop.Administracion
{
    /// <summary>
    /// Lógica de interacción para MesaItem.xaml
    /// </summary>
    public partial class MesaItem : UserControl
    {
        public MesaItem()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            #region C A N V A S
            // Data Providers/Consumers

            CanvasDataProvider<Canvas, Image> canvasImageDataProvider = new CanvasDataProvider<Canvas, Image>("CanvasImageObject");

            CanvasDataConsumer<Canvas, Image> canvasImageDataConsumer = new CanvasDataConsumer<Canvas, Image>(new string[] { "CanvasImageObject" });

            // Drag Managers
            DragManager dragHelperCanvas0 = new DragManager(this.canvas, canvasImageDataProvider);

            // Drop Managers
            DropManager dropHelperCanvas0 = new DropManager(this.canvas, canvasImageDataConsumer);
           
            #endregion
            double a  = imagen.Margin.Left;
            imagen.Name =  "id" +a;
        }
    }
}
