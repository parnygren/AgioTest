using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;

namespace AgioTest.ViewModels
{
    public class PersonalNumber : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string RegExForValidation = @"^(?<date>\d{6}|\d{8})[-\s]?\d{4}$";
            string date = Regex.Match((string)value, RegExForValidation).Groups["date"].Value;
            DateTime dateTime;

            if (DateTime.TryParseExact(date,
                new[] {"yyMMdd", "yyyyMMdd"},
                new CultureInfo("sv-SE"),
                DateTimeStyles.None,
                out dateTime))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Incorrect personal number format");
        }
    }
}