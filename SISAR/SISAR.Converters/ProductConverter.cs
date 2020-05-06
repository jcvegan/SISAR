using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Logica;
using SISAR.Entidades;
using System.Windows.Data;

namespace SISAR.Converters
{
    public class ProductConverter : IValueConverter
    {
        #region Miembros de IValueConverter

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                L_Producto _producto = new L_Producto();
                return _producto.Select(System.Convert.ToInt32(value)).Nombre;
            }
            catch
            {
                return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
