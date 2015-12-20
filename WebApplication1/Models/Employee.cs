using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set;}
        [FirstNameValidation]
        public string FirstName { get; set; }
        [StringLength(5,ErrorMessage ="Last name text should not be more than 5 characters in length")]
        public string LastName { get; set; }
        public int Salary { get; set; }
    }

    public class FirstNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) // Checking for Empty Value
            {
                return new ValidationResult("Please Provide First Name");
            }
            else
            {
                if (value.ToString().Contains("@"))
                {
                    return new ValidationResult("First Name should Not contain @");
                }
            }
            return ValidationResult.Success;
        }
    }

}
