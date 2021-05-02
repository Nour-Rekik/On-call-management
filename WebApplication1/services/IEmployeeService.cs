using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.services
{
    public interface IEmployeeService
    {
        List<EmployeeDto> GetEmployeeDtos();
        EmployeeDto GetEmployee(int id);
        EmployeeDto AddAmployee(EmployeeForAddDto emp);
        void EditEmployee(EmployeeForEditDto empdto);
        void DeleteEmployee(int id);

    }
}
