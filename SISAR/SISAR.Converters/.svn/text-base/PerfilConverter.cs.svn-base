using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using SISAR.Logica;

namespace SISAR.Converters
{
    public class PerfilConverter:IValueConverter
    {

        #region Miembros de IValueConverter

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                L_Perfil _perfil = new L_Perfil();
                return _perfil.Select(System.Convert.ToInt32(value)).Nombre;//.Nombre;
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
