using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Subject
    {
        [Column("SubjectId")]
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }

    }
}
