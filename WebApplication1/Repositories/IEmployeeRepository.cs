using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IEmployeeRepository
    {

        Employee GetEmployeesById(int id);
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee emp);
        void SaveChanges();
        void EditEmployee(EmployeeForEditDto emp);
        void DeleteEmployee(int id);



    }
}
