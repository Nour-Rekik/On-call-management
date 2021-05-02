using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class DepartementRepository : IDepartementRepository
    {

        private readonly ApplicationContext context;
        public DepartementRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public List<Departement> GetAllDepartements()
        {
            return this.context.Departements.Include(d=> d.Employees).ToList();
        }

        public Departement GetDepartementsById(int id, bool includeEmployees)
        {
            if (includeEmployees==false)
            {
                return this.context.Departements
                .Where(d => d.Id == id).FirstOrDefault();
            }
            return this.context.Departements.Include(d=>d.Employees)
                .Where(d => d.Id == id).FirstOrDefault();
        }
        public void AddDepartement(Departement dep)
        {
            this.context.Departements.Add(dep);
        }
        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
        public void EditDepartement(DepartementDto depdto)
        {
            Departement dep = this.context.Departements
                .Include(e=>e.Employees)
                .FirstOrDefault(e => e.Id == depdto.Id);
            if (dep != null)
            {
                dep.Description = depdto.Description;
                dep.name = depdto.name;
                
            }
        }
        public void DeleteDepartement(int id)
        {
            Departement dep = this.context.Departements
                .Include(e=>e.Employees)
                .FirstOrDefault(e => e.Id == id);
            if (dep != null)
            {
                this.context.Departements.Remove(dep);

            }
        }
    }
}
