using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;
using WebApplication1.profiles.convertors;

namespace WebApplication1.profiles
{
    public class MappingProfiles :Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest =>
            dest.FullName,
            opt => opt.MapFrom(src => src.FirstName+""+src.LastName));

            CreateMap<EmployeeForAddDto, Employee>();
            CreateMap<List<EmployeeForAddDto>, List<Employee>>();
            CreateMap<EmployeeForEditDto, Employee>();
            CreateMap<Departement, DepartementDto>().ConvertUsing<DepartementToDepartementDtoConverter>();
            CreateMap<DepartementForAddDto, Departement>();





        }

    }
}
