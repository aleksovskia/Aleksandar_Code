using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using CodeAcademyWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public List<Student> Get()
        {
            return _studentService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Student Get(int id)
        {
            return _studentService.Get(id);
        }

        //localhost:4200/Students/Faculty/1
        [HttpGet]
        [Route("Faculty/{id}")]
        public List<Student> GetStudentsByFacultyId(int id)
        {
            return _studentService.GetByFacultyId(id);
        }

        [HttpPost]
        [Route("create")]
        public Student Create(Student model)
        {
            return _studentService.Add(model);
        }

        [HttpPatch]
        [Route("update")]
        public Student Update(Student faculty)
        {
            return _studentService.Update(faculty);
        }
    }
}
