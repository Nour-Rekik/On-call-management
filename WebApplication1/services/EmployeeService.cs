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

    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }
        public EmployeeDto GetEmployee(int id)
        {
            Employee e = this.employeeRepository.GetEmployeesById(id);
            return mapper.Map<EmployeeDto>(e);
        }
        public List<EmployeeDto> GetEmployeeDtos()
        {
            List<EmployeeDto> employeedto = new List<EmployeeDto>();
            List<Employee> employees = this.employeeRepository.GetAllEmployees();
            foreach (Employee employee in employees)
            {
                employeedto.Add(mapper.Map<EmployeeDto>(employee));
            }
            return employeedto;
        }
        public EmployeeDto AddAmployee(EmployeeForAddDto emp)
        {
            Employee e = mapper.Map<Employee>(emp);
            this.employeeRepository.AddEmployee(e);
            this.employeeRepository.SaveChanges();
            EmployeeDto empdto = mapper.Map<EmployeeDto>(e);
            return empdto;
        }

        public void EditEmployee(EmployeeForEditDto emp)
        {
            this.employeeRepository.EditEmployee(emp);
            this.employeeRepository.SaveChanges();
        }
        public void DeleteEmployee(int id)
        {
            this.employeeRepository.DeleteEmployee(id);
            this.employeeRepository.SaveChanges();
        }
    }
}
