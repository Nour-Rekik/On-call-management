using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationContext _context ;
        public EmployeeRepository(ApplicationContext context)
        {
            _context = context;
        }
        public List<Employee> GetAllEmployees ()
        {
            return this._context.Employees.ToList();
        }

        public Employee GetEmployeesById(int id)
        {
            return this._context.Employees.Where(e=>e.Id==id).FirstOrDefault();
        }
        public void AddEmployee(Employee emp)
        {
            this._context.Employees.Add(emp);
        }
        public void SaveChanges ()
        {
            this._context.SaveChanges();
        }
        public void EditEmployee (EmployeeForEditDto emp)
        {
            Employee employee = this._context.Employees.FirstOrDefault(e => e.Id == emp.Id);
            if (employee!=null)
            {
                employee.LastName = emp.LastName;
                employee.FirstName = emp.FirstName;
                employee.Salary = emp.Salary;
                employee.DepartementId = emp.DepartementId;
            }
        }
        public void DeleteEmployee (int id)
        {
            Employee employee = this._context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee!= null)
            {
                this._context.Employees.Remove(employee);

            }
        }
    }
}
