using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_Course_App.Models
{
    public class MinOneMovieInStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.NumberInStock > 0 && movie.NumberInStock < 21)
                return ValidationResult.Success;

            return new ValidationResult("The field Number in Stock must be bewteen 1 and 20.");
        }
    }
}