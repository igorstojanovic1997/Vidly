using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.CustomValidation
{
    public class MovieReleaseDateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;
          
            if (!movie.ReleaseDate.HasValue)
                return new ValidationResult("Release Date is required");
          
           
            return ValidationResult.Success;
        }
    }
}