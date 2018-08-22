using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CustomValidation
{
    public class CustomMinLength : MinLengthAttribute
    {
        public CustomMinLength(int length) : base(length)
        {

        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture, $"minlength", name, this.Length);
        }
    }
}
