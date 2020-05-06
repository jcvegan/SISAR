using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace SISAR.Validators
{
    public class InputCurrencyValidator:ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if ((value as double?) < 0)
            {
                return new ValidationResult(false, "Ingrese número mayor o igual a 0");
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }
    }
}
