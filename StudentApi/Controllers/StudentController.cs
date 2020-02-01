using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentApi.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentApi.Models.StudentInfo _context;
        public StudentController(StudentApi.Models.StudentInfo context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("values")]
        public ActionResult GetAll()
        {
            return new JsonResult(_context.StudentDetails.ToList());
        }
    }
}