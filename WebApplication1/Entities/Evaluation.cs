using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Evaluation
    {
        [Column("EvaluationId")]
        public int  Id { get; set; }
        [Required]
        public int Grade { get; set; }
        public string AdditionalExplanation { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
