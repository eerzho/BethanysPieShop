using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;

namespace BethanysPieShop.CustomValidation
{
    public class Min10ShortDesc : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var pie = (Pie)validationContext.ObjectInstance;

            if (pie.ShortDescription == null)
                return new ValidationResult("Short desc is required.");


            return (pie.ShortDescription.Length >= 10)
                ? ValidationResult.Success
                : new ValidationResult("Short desc must be more than 10 letters.");
        }
    }
}
