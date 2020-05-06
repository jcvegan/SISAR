using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace SISAR.Desktop
{
    public class Validators
    {
        public bool IsDigit(Key k)
        {
            return char.IsDigit(KeyToChar(k));
        }
        private char KeyToChar(Key k)
        {
            if (k >= Key.D0 && k <= Key.D9)
                return '0';
            if (k >= Key.OemPeriod)
                return '0';
            if (k >= Key.A && k <= Key.Z)
                return 'a';
            if (k >= Key.NumPad0 && k <= Key.NumPad9)
                return '0';
            return '-';
        }

        public bool IsLetter(Key key)
        {
            return char.IsLetter(KeyToChar(key));
        }
        public bool IsLetterOrDigit(Key key)
        {
            return char.IsLetterOrDigit(KeyToChar(key));
        }
    }
}
