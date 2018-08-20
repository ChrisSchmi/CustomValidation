using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new CustomModel();
            model.Text = "abcdefghijklmnopqrstuvwxyz";
            model.Number = -5;


            var validator = new DataAnnotationsValidator();

            var results = new List<ValidationResult>();

            //var context = new ValidationContext(model, serviceProvider: null, items: null);
            //var isValid = Validator.TryValidateObject(model, context, results, true);

            var isValid = validator.TryValidate(model, out results);

            if (!isValid)
            {
                foreach (var r in results)
                {
                    Console.WriteLine($"member: {r.MemberNames.ToList()[0]} error: {r.ErrorMessage}");
                }
            }

            Console.ReadKey();
        }
    }
}
