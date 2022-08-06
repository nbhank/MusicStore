using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTClassLibrary
{
    public class DateNotInFuture : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;
            DateTime workingDate = Convert.ToDateTime(value);

            if (workingDate > DateTime.Now)
                return new ValidationResult(
                    $"{validationContext.DisplayName} cannot be in the future");
            else
                return ValidationResult.Success;
        }
    }
}
