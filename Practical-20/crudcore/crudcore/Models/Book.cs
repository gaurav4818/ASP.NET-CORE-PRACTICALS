using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace crudcore.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [StringLength(50)]
        public string BookName { get; set; }
        [Required]
        public int BookPage { get; set; }
        [Required]
        public decimal BookPrice { get; set; }
        [Required]
        [StringLength(50)]
        public string BookAuthor { get; set;}
    }
}
