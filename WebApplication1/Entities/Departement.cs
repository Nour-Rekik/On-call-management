using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Departement
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; }


    }
}
