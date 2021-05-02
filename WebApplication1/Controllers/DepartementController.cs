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
    public class DepartementController : ControllerBase
    {
        private readonly IDepartementService departementService;

        public DepartementController(IDepartementService departementService)
        {
            this.departementService = departementService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAllDepartements()
        {
            return Ok(this.departementService.GetDepartementDtos());
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetDepartement(int id, bool includeEmployees =false)
        {
            return Ok(this.departementService.GetDepartement(id, includeEmployees));
        }

        [HttpPost]
        [Route("")]
        public IActionResult PostDepartement([FromBody] DepartementForAddDto dep)
        {
            return Created("", this.departementService.AddDepartement(dep));
        }
        [HttpPut]
        public IActionResult EditDepartement([FromBody] DepartementDto depdto)
        {
            this.departementService.EditDepartement(depdto);
            return NoContent();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDepartement(int id)
        {
            this.departementService.DeleteDepartement(id);
            return NoContent();

        }
    }
}
