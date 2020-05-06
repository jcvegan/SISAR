using System.Windows.Controls;
using System.Globalization;
using System;

namespace SISAR.Validators
{
    public class InputNumberValidator:ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (!(value is double))
            {
                return new ValidationResult(false, "Ingrese números");
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }
    }
}
