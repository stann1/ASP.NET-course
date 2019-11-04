using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings =false)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings =false)]
        public int Age { get; set; }
    }
}
