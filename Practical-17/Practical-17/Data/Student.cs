﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_17.Data
{
    public class Student
    {
              [Key]
            public int Id { get; set; }
           [Required]
            public string Name { get; set; }
            [Required]
            public int Age { get; set; }

    }
}
