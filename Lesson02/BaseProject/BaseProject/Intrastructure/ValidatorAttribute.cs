using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using BaseProject.Models;

namespace BaseProject.Intrastructure
{                   

    public class ValidatorAttribute : ValidationAttribute
    {

        public ValidatorAttribute()
        {

        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

        var name = (Name)value;

        if (name.FirstName == name.LastName)
        {
            return new ValidationResult("name cant be name");


        }

        return ValidationResult.Success;

        }
    }
}

