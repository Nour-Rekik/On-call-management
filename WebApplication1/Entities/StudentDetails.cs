using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class StudentDetails
    {
        [Column("StudentDetailsId")]
        public int  Id { get; set; }
        public string Address { get; set; }
        public string AdditionalInformation { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
