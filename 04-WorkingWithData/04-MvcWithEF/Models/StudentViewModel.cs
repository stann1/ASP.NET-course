using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings =false)]
        [RegularExpression(@"\w+")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings =false)]
        [Range(1,150)]
        public int Age { get; set; }
    }
}
