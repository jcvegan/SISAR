using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Media;


namespace SISAR.Desktop
{
    class ByteToImageConverter:IValueConverter
    {
        #region Miembros de IValueConverter

        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }
            else
            {
                byte[] _picByte = (byte[])value;
                BitmapImage _bi = new BitmapImage();
                _bi.BeginInit();
                Stream _imageStream = new MemoryStream(_picByte);
                _bi.StreamSource = _imageStream;
                _bi.EndInit();
                return _bi;
            }
        } 
        #endregion

        #region Miembros de IValueConverter


        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }

        #endregion
    }
}
