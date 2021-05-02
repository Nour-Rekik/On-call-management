using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService  = employeeService;
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAllEmployees ()
        {
            return Ok(this.employeeService.GetEmployeeDtos());   
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetEmployee (int id)
        {
            return Ok(this.employeeService.GetEmployee(id));
        }

        [HttpPost]
        [Route("")]
        public IActionResult PostEmployee([FromBody] EmployeeForAddDto employee)
        {
            return Created("",this.employeeService.AddAmployee(employee));
        }
        [HttpPut]
        public IActionResult EditEmployee ([FromBody] EmployeeForEditDto empdto)
        {
            this.employeeService.EditEmployee(empdto);
            return NoContent();
                 
        }
        public IActionResult DeleteEmployee(int id)
        {
            this.employeeService.DeleteEmployee(id);
            return NoContent();

        }
    }
}
