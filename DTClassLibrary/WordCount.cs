using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTClassLibrary
{
    public class WordCountAttribute :ValidationAttribute
    {
        Int32 maxWords, minWords = 0;
        public WordCountAttribute(Int32 maxWords)
        {
            ErrorMessage = "{0} cannot be more than {1} words";
            this.maxWords = maxWords;
        }

        public WordCountAttribute(Int32 maxWords, Int32 minWords)
        {
            ErrorMessage = "{0} must be between {2} and {1} words, inclusive ";
            this.maxWords = maxWords;
            this.minWords = minWords;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || value.ToString() == "")
                return ValidationResult.Success;

            var words = value.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > maxWords || words.Length < minWords)
                return new ValidationResult(
                    string.Format(ErrorMessage, validationContext.DisplayName,
                    maxWords, minWords));
            else
                return ValidationResult.Success;
        }

    }
}
