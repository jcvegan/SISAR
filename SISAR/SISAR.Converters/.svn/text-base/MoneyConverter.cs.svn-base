using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using SISAR.Logica;

namespace SISAR.Converters
{
    public class MoneyConverter:IValueConverter
    {
        #region Miembros de IValueConverter

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                L_Moneda _moneda = new L_Moneda();

                return _moneda.Select(System.Convert.ToInt32(value)).Nombre;//.Nombre;
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
