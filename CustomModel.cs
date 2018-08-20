using CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class CustomModel : IValidatableObject
{

    [CustomRequired]
    [CustomStringLength(10)]
    public string Text { get; set; }

    [CustomRange(0,100)]
    public int Number { get; set; }

    /// <summary>
    /// -> https://stackoverflow.com/questions/3400542/how-do-i-use-ivalidatableobject
    /// </summary>
    /// <param name="validationContext"></param>
    /// <returns></returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var vResults = new List<ValidationResult>();

        var vc = new ValidationContext(
            instance: this,
            serviceProvider: null,
            items: null);

        var isValid = Validator.TryValidateObject(
            instance: vc.ObjectInstance,
            validationContext: vc,
            validationResults: vResults,
            validateAllProperties: true);

        if (!isValid)
        {
            foreach (var validationResult in vResults)
            {
                yield return validationResult;
            }
        }

        yield break;
    }
}