using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public double Salary { get; set; }
        
        [ForeignKey(nameof(Departement))]
        public int DepartementId { get; set; }
        public Departement Departement { get; set; }


    }
}
