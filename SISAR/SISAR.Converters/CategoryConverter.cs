using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using SISAR.Logica;

namespace SISAR.Converters
{
    public class CategoryConverter:IValueConverter
    {

        #region Miembros de IValueConverter

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                L_Categoria _categoria = new L_Categoria();
                return _categoria.Select(System.Convert.ToInt32(value)).Nombre;//.Nombre;
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
