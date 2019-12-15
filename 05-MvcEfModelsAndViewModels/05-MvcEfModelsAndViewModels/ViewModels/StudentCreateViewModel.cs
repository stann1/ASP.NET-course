using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class StudentCreateViewModel
    {
        [RegularExpression(pattern: @"[A-Z]{1}\w+", ErrorMessage = "Names should be alpha-numeric and begin with capital letter")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [RegularExpression(pattern: @"[A-Z]{1}\w+", ErrorMessage = "Names should be alpha-numeric begin with capital letter")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Range(1,100)]
        public int Age { get; set; }
        public string Address { get; set; }

        public Student MapToDbModel()
        {
            return new Student()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Age = this.Age,
                Address = this.Address
            };
        }
    }
}
