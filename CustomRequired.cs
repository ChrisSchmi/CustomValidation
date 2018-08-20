using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;


namespace CustomValidation
{

    // https://msdn.microsoft.com/en-us/library/cc668224.aspx

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class CustomRequired : RequiredAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture, "required", name);
        }
    }
}