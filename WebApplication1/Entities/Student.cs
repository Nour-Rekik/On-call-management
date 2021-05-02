using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [Column("Id")]
        public int StudentId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        public string Name { get; set; }
        public int? Age { get; set; }
        public bool IsRegularStudent { get; set; }
        public StudentDetails StudentDetails { get; set; }
        public ICollection<Evaluation> Evaluations { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }



    }
}
