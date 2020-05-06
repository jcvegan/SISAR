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
using SLMitsuControls;

namespace SISAR.WebAnimation
{
    public partial class MenuDeHoy : ChildWindow,IDataProvider
    {
        List<UserControl> lista;
        public MenuDeHoy()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MenuDeHoy_Loaded);
        }

        void MenuDeHoy_Loaded(object sender, RoutedEventArgs e)
        {
            lista = new List<UserControl>();
            lista.Add(new MenuPortada());
            MenuBook.SetData(this);
        }


        #region Miembros de IDataProvider

        public int GetCount()
        {
            return lista.Count;
        }

        public object GetItem(int index)
        {
            return lista[index];
        }

        #endregion
    }
}

