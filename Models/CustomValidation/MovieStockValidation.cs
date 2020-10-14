using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models.CustomValidation
{
    public class MovieStockValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;
           
            if (movie.Stock == 0)
                return new ValidationResult("Number must be between 1 and 20");
            return ValidationResult.Success;
        }
    }
}