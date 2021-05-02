using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.services
{
    public interface IDepartementService
    {
        DepartementDto GetDepartement(int id, bool includeEmployees);
        List<DepartementDto> GetDepartementDtos();
        DepartementDto AddDepartement(DepartementForAddDto dep);
        void EditDepartement(DepartementDto dep);
        void DeleteDepartement(int id);


    }
}
