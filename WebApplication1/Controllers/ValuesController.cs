using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    public class ValuesController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public ValuesController(ApplicationContext context)
        {
            _context = context;
        }

       [HttpGet]

       public IActionResult Get()
        {
            var students = _context.Students.Where(s => s.Age > 25).ToList();
            return Ok(students);
        }
    }
}
