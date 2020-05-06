using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Microsoft.Windows.Controls.Ribbon;
using SISAR.Desktop.Administracion;
using SISAR.Desktop.Atencion;
using SISAR.Desktop.Ayuda;
using SISAR.Desktop.Consultas;
using SISAR.Desktop.Seguridad;
using SISAR.Desktop.Ventas;

namespace SISAR.Desktop
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class WinPrincipal : RibbonWindow
    {
        private System.Windows.Threading.DispatcherTimer _Clock;

        #region Variables
        DependencyObject obj;
        AdministrarCategorias _AdministrarCategorias;
        AdministrarProducto _AdministrarProducto;
        AdministrarCliente _AdminitrarClientes;
        ConfirmarPedidos _ConfirmarPedidos;
        ConsultarStock _ConsultarStock;
        Manual _manual;
        RegistrarConsumo _RegistrarConsumo;
        AdministrarMenu _AdministrarMenu;
        AdministrarPerfil _AdministrarPerfil;
        AdministrarEmpleados _AdministrarEmpleados;
        AbrirCaja _AbrirCaja;
        CerrarCaja _CerrarCaja;
        DistribucionMesas _DistribucionMesas;
        AdministrarLocal _AdministrarLocal;
        AdministrarZona _AdministrarZona;
        int _idLocal = 1;
        #endregion
        
        public WinPrincipal()
        {
            try
            {
                #region SplashScreen
                SplashScreen sp = new SplashScreen("Imagenes//PortadaSISAR.png");
                sp.Show(true); 
                #endregion
                InitializeComponent();
                this._idLocal = 1;
            }
            catch { }
            #region Eventos
            this.Closing += new System.ComponentModel.CancelEventHandler(WinPrincipal_Closing);
            this.Closed += new EventHandler(WinPrincipal_Closed);
            this.Loaded += new RoutedEventHandler(WinPrincipal_Loaded);            
            #endregion            
        }

        void WinPrincipal_Closed(object sender, EventArgs e)
        {
        }

        #region Metodos del Form Principal
        void WinPrincipal_Loaded(object sender, RoutedEventArgs e)
        {

            BackgroundWorker _bWorker = new BackgroundWorker();
            _bWorker.WorkerSupportsCancellation = false;
            _bWorker.DoWork += (s3, e3) =>
            {
                while (true)
                {
                    Dispatcher.Invoke(DispatcherPriority.Background, (Action)delegate
                    {
                        hora.Content = DateTime.Now.ToLongTimeString();
                        fecha.Content = DateTime.Now.ToLongDateString();
                        sesion.Content = "Administrador General";
                    });
                }
            };
            _bWorker.RunWorkerAsync(100);
            //horas = new Thread(new ThreadStart(VerHora));
            //horas.IsBackground = true;
            //horas.Start();
            
        }
        void WinPrincipal_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes, MessageBoxOptions.DefaultDesktopOnly) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            //else
            //{
            //    horas.Abort();
            //}
        }
        //private string Cerrar()
        //{
        //    for (int i = 5; i <= 1; i--)
        //    {
        //        return "Su protrama se cerrará en " + i + " segundos";
        //    }
        //    return "Cerrandose";
        //}
        
        //public void VerHora()
        //{
        //    string horaActual = "";
        //    while (_inicioThread == true)
        //    {
        //        Thread.Sleep(5000);
        //        horaActual= DateTime.Now.ToLongTimeString();
        //        //horas.Join();
        //        this.hora.Text = horaActual;
        //        //MessageBox.Show(DateTime.Now.ToLongTimeString()); 
        //    }
            
        //    //do
        //    //{
        //    //    Thread.Sleep(5000);
        //    //    MessageBox.Show("Hola");
        //    //}
        //    //while (_inicioThread == true);
            
        //        //hora.Content = DateTime.Now.ToLongTimeString();
            
        //}
        //void _Clock_Tick(object sender, EventArgs e)
        //{
        //    hora.Content = DateTime.Now.ToLongTimeString();
        //}
        #endregion

        #region Configuracion de Temas
        private void Config_OfficeBlue(object sender, ExecutedRoutedEventArgs e)
        {
            App.Current.Resources.MergedDictionaries.Clear();
            //Resources.MergedDictionaries.Clear();
            App.Current.Resources.MergedDictionaries.Add(Microsoft.Windows.Controls.Ribbon.PopularApplicationSkins.Office2007Blue);
            //this.Resources.MergedDictionaries.Add(System.Windows.Controls.Theming.BureauBlueTheme);
            ResourceDictionary skin = new ResourceDictionary();
            skin.Source = new Uri(@"Temas\BureauBlue.xaml", UriKind.Relative);
            App.Current.Resources.MergedDictionaries.Add(skin);
        }

        private void Config_OfficeSilver(object sender, ExecutedRoutedEventArgs e)
        {
            App.Current.Resources.MergedDictionaries.Clear();
            App.Current.Resources.MergedDictionaries.Add(Microsoft.Windows.Controls.Ribbon.PopularApplicationSkins.Office2007Silver);
            ResourceDictionary skin = new ResourceDictionary();
            skin.Source = new Uri(@"Temas\ExpressionLight.xaml", UriKind.Relative);
            App.Current.Resources.MergedDictionaries.Add(skin);
        }

        private void Config_OfficeBlack(object sender, ExecutedRoutedEventArgs e)
        {
            App.Current.Resources.MergedDictionaries.Clear();
            App.Current.Resources.MergedDictionaries.Add(Microsoft.Windows.Controls.Ribbon.PopularApplicationSkins.Office2007Black);
            ResourceDictionary skin = new ResourceDictionary();
            skin.Source = new Uri(@"Temas\ExpressionDark.xaml", UriKind.Relative);
            App.Current.Resources.MergedDictionaries.Add(skin);
        }
        #endregion

        private void Ayuda_AcercaDe(object sender, ExecutedRoutedEventArgs e)
        {
            AcercaDe _AcercaDe = new AcercaDe();
            _AcercaDe.ShowDialog();
        }

        private void Accion_Cerrar(object sender, ExecutedRoutedEventArgs e)
        {
            HackRibbon();
        }

        private void Ayuda_VerCarta(object sender, ExecutedRoutedEventArgs e)
        {
            HackRibbon();
            Container.Children.Add(new VerCarta(this.ActualWidth));
        }

        #region Ribbon_Methods
        private void HackRibbon()
        {
            Container.Children.Clear();
            Acciones.IsActive = false;
            obj = null;
        }
        private void RibbonHighlightingList_MostRecentFileSelected(object sender, MostRecentFileSelectedEventArgs e)
        {

        }
        #endregion

        #region Paquete Mantenimiento
        private void Mantenimiento_Cargos(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Mantenimiento_Categorias(object sender, ExecutedRoutedEventArgs e)
        {
            _AdministrarCategorias = new AdministrarCategorias();
            obj = nuevoTab(_AdministrarCategorias);
        }

        private void Mantenimiento_Clientes(object sender, ExecutedRoutedEventArgs e)
        {
            _AdminitrarClientes = new AdministrarCliente();
            obj = nuevoTab(_AdminitrarClientes);
        }
        
        private void Mantenimiento_Perfiles(object sender, ExecutedRoutedEventArgs e)
        {
            _AdministrarPerfil = new AdministrarPerfil();
            obj = nuevoTab(_AdministrarPerfil);
        }

        private void Mantenimiento_Distribucion(object sender, ExecutedRoutedEventArgs e)
        {
            _DistribucionMesas = new DistribucionMesas(_idLocal);
            obj = nuevoTab(_DistribucionMesas);
        }

        private void Mantenimiento_Empleados(object sender, ExecutedRoutedEventArgs e)
        {
            _AdministrarEmpleados = new AdministrarEmpleados();
            obj = nuevoTab(_AdministrarEmpleados);
        }

        private void Mantenimiento_Propinas(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Mantenimiento_Productos(object sender, ExecutedRoutedEventArgs e)
        {
            _AdministrarProducto = new AdministrarProducto();
            obj = nuevoTab(_AdministrarProducto);  
        }

        private void Mantenimiento_Zonas(object sender, ExecutedRoutedEventArgs e)
        {
            _AdministrarZona = new AdministrarZona(_idLocal);
            obj = nuevoTab(_AdministrarZona);  
        }

        
        #endregion

        #region Contextual Tabs
        private void TabAdministracion_Selected(object sender, RoutedEventArgs e)
        {
            //Vistas.IsActive = true;
        }
        #endregion

        private void Atencion_AdministrarPedidos(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Atencion_EliminarPedidos(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Atencion_ModificarPedidos(object sender, ExecutedRoutedEventArgs e)
        {

        }

        #region Reporte de Ventas
        private void Reportes_Ventas(object sender, ExecutedRoutedEventArgs e)
        {
            HackRibbon();
            Container.Children.Add(new Reportes.ReporteVentas());
        }
        #endregion

        #region Consultar Stock
        private void Consultas_ConsultarStock(object sender, ExecutedRoutedEventArgs e)
        {
            HackRibbon();
            Container.Children.Add(new ConsultarStock());
            DependencyObject obj = VisualTreeHelper.GetChild(Container, 0);
            if (obj is ConsultarStock)
            {
                _ConsultarStock = obj as ConsultarStock;
            }
        }
        #endregion

        #region Confirmar Pedidos
        private void Atencion_ConfirmarPedidos(object sender, ExecutedRoutedEventArgs e)
        {
            HackRibbon();
            Container.Children.Add(new ConfirmarPedidos(_idLocal));
            DependencyObject obj = VisualTreeHelper.GetChild(Container, 0);
            if (obj is ConfirmarPedidos)
            {
                _ConfirmarPedidos = obj as ConfirmarPedidos;
            }

        }
        
        #endregion
        
        private void Seguridad_CambioPassword(object sender, ExecutedRoutedEventArgs e)
        {
            HackRibbon();
            Container.Children.Add(new CambioPassword());
            Acciones.IsActive = true;
            TabAcciones.IsSelected = true;
        }

        private void Acciones_Guardar(object sender, ExecutedRoutedEventArgs e)
        {
            if (obj != null)
            {
                if (obj is AdministrarCliente)
                {
                    _AdminitrarClientes.RegistroCliente();
                }
                else if (obj is AdministrarPerfil)
                {
                    _AdministrarPerfil.RegistroPerfil();
                }
                else if (obj is AdministrarCategorias)
                {
                    _AdministrarCategorias.RegistroCategoria();
                }
                else if (obj is AdministrarProducto)
                {
                    _AdministrarProducto.RegistroProducto();
                }
                else if (obj is CerrarCaja)
                {
                    _CerrarCaja.RegistroCaja();
                }
                else if (obj is AbrirCaja)
                {
                    _AbrirCaja.RegistroCaja();
                }
                else if (obj is AdministrarMenu)
                {
                    _AdministrarMenu.RegistroMenu();
                }
                else if (obj is AdministrarEmpleados)
                {
                    _AdministrarEmpleados.RegistroCliente();
                }
                else if (obj is DistribucionMesas)
                {
                    _DistribucionMesas.RegistroDistribucionMesas();
                }
                else if (obj is AdministrarLocal)
                {
                    _AdministrarLocal.RegistroLocal();
                }
                else if (obj is AdministrarZona)
                {
                    _AdministrarZona.RegistroZona();
                }
            }
        }

        private void Acciones_Limpiar(object sender, ExecutedRoutedEventArgs e)
        {
            if (obj != null)
            {
                if (obj is AdministrarCliente)
                {
                    _AdminitrarClientes.LimpiarCliente();
                }
                else if (obj is AdministrarPerfil)
                {
                    _AdministrarPerfil.LimpiarPerfil();
                }
                else if (obj is AdministrarCategorias)
                {
                    _AdministrarCategorias.LimpiarCategoria();
                }
                else if (obj is AdministrarProducto)
                {
                    _AdministrarProducto.LimpiarProducto();
                }
                else if (obj is CerrarCaja)
                {
                    _CerrarCaja.LimpiarCaja();
                }
                else if (obj is AbrirCaja)
                {
                    _AbrirCaja.LimpiarCaja();
                }
                else if (obj is AdministrarMenu)
                {
                    _AdministrarMenu.LimpiarMenu();
                }
                else if (obj is AdministrarEmpleados)
                {
                    _AdministrarEmpleados.LimpiarCliente();
                }
                else if (obj is DistribucionMesas)
                {
                    _DistribucionMesas.LimpiarDistribucionMesas();
                }
                else if (obj is AdministrarLocal)
                {
                    _AdministrarLocal.LimpiarLocal();
                }
                else if (obj is AdministrarZona)
                {
                    _AdministrarZona.LimpiarZona();
                }
            }
        }
        
        private void Acciones_Eliminar(object sender, ExecutedRoutedEventArgs e)
        {
            if (MessageBox.Show("Sera seguro que sera eliminar un registro", "Confirmació", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                return;
            if (obj != null)
            {
                if (obj is AdministrarCliente)
                {
                    _AdminitrarClientes.EliminarCliente();
                }
                else if (obj is AdministrarPerfil)
                {
                    _AdministrarPerfil.EliminarPerfil();
                }
                else if (obj is AdministrarCategorias)
                {
                    _AdministrarCategorias.EliminarCategoria();
                }
                else if (obj is AdministrarProducto)
                {
                    _AdministrarProducto.EliminarProducto();
                }
                else if (obj is AdministrarMenu)
                {
                    _AdministrarMenu.EliminarMenu();
                }
                else if (obj is AdministrarEmpleados)
                {
                    _AdministrarEmpleados.EliminarEmpleado();
                }
                else if (obj is DistribucionMesas)
                {
                    _DistribucionMesas.EliminarDistribucionMesas();
                }
                else if (obj is AdministrarLocal)
                {
                    _AdministrarLocal.EliminarLocal();
                }
                else if (obj is AdministrarZona)
                {
                    _AdministrarZona.EliminarZona();
                }
            }
        }

        private void Mantenimiento_Reservas(object sender, ExecutedRoutedEventArgs e)
        {
            HackRibbon();
            Container.Children.Add(new AdministrarReservas());
            Acciones.IsActive = true;
            TabAcciones.IsSelected = true;
            btnImprimir.Visibility = Visibility.Collapsed;
        }
        
        private void Consultas_LibroVisitas(object sender, ExecutedRoutedEventArgs e)
        {
            Container.Children.Clear();
            Container.Children.Add(new LibroVisitas());
        }

        private void Ayuda_VerManual(object sender, ExecutedRoutedEventArgs e)
        {
            Container.Children.Clear();
            Container.Children.Add(new Manual());
            Acciones.IsActive = true;
            TabAcciones.IsSelected = true;
            DependencyObject obj = VisualTreeHelper.GetChild(Container, 0);
            if (obj is Manual)
            {
                _manual = obj as Manual;
            }
            btnImprimir.Visibility = Visibility.Visible;
        }

        private void Accion_Imprimir(object sender, ExecutedRoutedEventArgs e)
        {
            if (_manual != null)
            {
                _manual.ImprimirDocumento();
            }
        }

        private void Command_Salir(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void Venta_RegistrarMovimientoCaja(object sender, ExecutedRoutedEventArgs e)
        {
            _RegistrarConsumo = new RegistrarConsumo(_idLocal);
            HackRibbon();
            Consumo.IsActive = true;
            TabConsumo.IsSelected = true;
            Container.Children.Clear();
            Container.Children.Add(_RegistrarConsumo);
            obj = VisualTreeHelper.GetChild(Container, 0);
        }

        private void Mantenimiento_Menu(object sender, ExecutedRoutedEventArgs e)
        {
            _AdministrarMenu = new AdministrarMenu();
            obj = nuevoTab(_AdministrarMenu); 
        }

        private void Venta_AbrirCaja(object sender, ExecutedRoutedEventArgs e)
        {
            _AbrirCaja = new AbrirCaja();
            obj = nuevoTab(_AbrirCaja);
        }

        private void Venta_CerrarCaja(object sender, ExecutedRoutedEventArgs e)
        {
            _CerrarCaja = new CerrarCaja();
            obj = nuevoTab(_CerrarCaja);
        }

        private DependencyObject nuevoTab(UIElement _uielement)
        {
            HackRibbon();
            Acciones.IsActive = true;
            TabAcciones.IsSelected = true;
            Container.Children.Clear();
            Container.Children.Add(_uielement);
            return VisualTreeHelper.GetChild(Container, 0);
        }

        private void Acciones_Pagar(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Mantenimiento_Local(object sender, ExecutedRoutedEventArgs e)
        {
            _AdministrarLocal = new AdministrarLocal();
            obj = nuevoTab(_AdministrarLocal);
        }


        
    }
}
