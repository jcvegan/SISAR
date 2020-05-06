using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.IO;
using System.Windows.Media.Imaging;
using System.Threading;
using System.Windows.Media;
using System.Drawing;

namespace SISAR.Converters
{
    public class ByteToImage:IValueConverter
    {

        #region Miembros de IValueConverter

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            if (targetType != typeof(ImageSource))
                throw new InvalidOperationException("The target must be ImageSource or derived types");

            if (value != null && value is byte[])
            {
                byte[] bytes = value as byte[];

                MemoryStream strm = new MemoryStream();

                strm.Write(bytes, 0, bytes.Length);
                strm.Position = 0;
                
                Image img = Image.FromStream(strm);
                BitmapImage bi = new BitmapImage();

                bi.BeginInit();
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ms.Seek(0, SeekOrigin.Begin);
                bi.StreamSource = ms;
                bi.EndInit();

                return bi;
            }
            return null;
        }


        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }

        #endregion
    }
}
