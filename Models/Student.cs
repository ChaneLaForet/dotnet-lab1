using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1._1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(13)]
        public string Cnp { get; set; }

        public string Course { get; set; }

        [Range(0,10)]
        public int Grade { get; set; }

        public DateTime AddedAt { get; set; }
    }
}
