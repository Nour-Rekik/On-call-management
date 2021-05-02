using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.profiles.convertors
{
    public class DepartementToDepartementDtoConverter : ITypeConverter<Departement, DepartementDto>
    {
        private readonly IMapper mapper;

        public DepartementToDepartementDtoConverter(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public DepartementDto Convert(Departement source, DepartementDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return destination;
            }
            if (destination == null)
            {
                destination = new DepartementDto();
            }
            destination.Id = source.Id;
            destination.name = source.name;
            destination.Description = source.Description;
            if (source.Employees != null)
            {
                destination.EmployeeDtos = source.Employees.Select(e => this.mapper.Map<EmployeeDto>(e)).ToList();
                destination.MasseSalariale = destination.EmployeeDtos.Sum(e => e.Salary);

            }
            return destination;

        }
    }
}
