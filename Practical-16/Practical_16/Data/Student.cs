using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_16.Data
{
    public class Student
    {
        [Required]
      
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime? DOB { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }

    }
}
