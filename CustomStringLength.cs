using System;
using System.Collections.Generic;
using System.Text;

// by CSC
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CustomValidation
{
    public class CustomStringLength : StringLengthAttribute
    {
        public CustomStringLength(int maximumLength) : base(maximumLength)
        {

        }
        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture, $"stringlength", name, this.MinimumLength, this.MaximumLength);
        }
    }
}
