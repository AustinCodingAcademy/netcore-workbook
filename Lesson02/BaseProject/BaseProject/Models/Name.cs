using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BaseProject.Models
{
    public class Name : IValidatableObject
    {
        [Required]
        [MinLength(3)]

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var name = (Name)validationContext.ObjectInstance;

            if(name.FirstName == name.LastName)
            {
                yield return new ValidationResult("name cant be name");


            }
        }
    }
}
