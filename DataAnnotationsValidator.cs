using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

/// https://odetocode.com/blogs/scott/archive/2011/06/29/manual-validation-with-data-annotations.aspx
public class DataAnnotationsValidator
{
    public bool TryValidate(object @object, out List<ValidationResult> results)
    {
        var context = new ValidationContext(@object, serviceProvider: null, items: null);
        results = new List<ValidationResult>();
        return Validator.TryValidateObject(
            @object, context, results, 
            validateAllProperties: true
        );
    }
}