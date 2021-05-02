using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
     public interface IDepartementRepository
    {
        Departement GetDepartementsById(int id, bool includeEmployees);
        List<Departement> GetAllDepartements();
        void AddDepartement(Departement dep);
        void SaveChanges();
        void EditDepartement(DepartementDto emp);
        void DeleteDepartement(int id);
    }
}
