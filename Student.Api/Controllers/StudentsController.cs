using Microsoft.AspNetCore.Mvc;
using Student.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public StudentsController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult GetAllStudents()
        {

            var students = db.Students.ToList();
            return Ok(students);
        }

    }
}
