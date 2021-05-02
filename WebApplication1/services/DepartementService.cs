using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.services
{
    public class DepartementService : IDepartementService
    {
        private readonly IDepartementRepository departementRepository;
        private readonly IMapper mapper;

        public DepartementService(IMapper mapper, IDepartementRepository departementRepository)
        {
            this.mapper = mapper;
            this.departementRepository = departementRepository;
        }

        public DepartementDto GetDepartement(int id, bool includeEmployees)
        {
            Departement  e = this.departementRepository.GetDepartementsById(id, includeEmployees);
            return mapper.Map<DepartementDto>(e);
        }
        public List<DepartementDto> GetDepartementDtos()
        {
            List<DepartementDto> departementdto = new List<DepartementDto>();
            List<Departement> departments = this.departementRepository.GetAllDepartements();
            foreach (Departement departement in departments)
            {
                departementdto.Add(mapper.Map<DepartementDto>(departement));
            }
            return departementdto;
        }
        public DepartementDto AddDepartement(DepartementForAddDto dep)
        {
            Departement e = mapper.Map<Departement>(dep);
            this.departementRepository.AddDepartement(e);
            this.departementRepository.SaveChanges();
            DepartementDto depdto = mapper.Map<DepartementDto>(e);
            return depdto;
        }

        public void EditDepartement(DepartementDto dep)
        {
            this.departementRepository.EditDepartement(dep);
            this.departementRepository.SaveChanges();
        }
        public void DeleteDepartement(int id)
        {
            this.departementRepository.DeleteDepartement(id);
            this.departementRepository.SaveChanges();
        }
    }
}
