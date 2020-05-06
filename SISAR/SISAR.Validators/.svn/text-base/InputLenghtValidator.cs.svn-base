using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace SISAR.Validators
{
    public class InputLenghtValidator:ValidationRule
    {
        private int _lenght;

        public int Lenght
        {
            get { return _lenght; }
            set { _lenght = value; }
        }
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if ((value as string).Length > Lenght)
            {
                return new ValidationResult(false, "Ha ingresado mas caracteres del rango establecido: " + Lenght.ToString());
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }
    }
}
