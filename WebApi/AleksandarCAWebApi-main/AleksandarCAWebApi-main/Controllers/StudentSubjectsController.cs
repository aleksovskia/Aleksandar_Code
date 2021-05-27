using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CodeAcademyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentSubjectsController : ControllerBase
    {
        private readonly IStudentSubjectService _studentSubjectService;

        public StudentSubjectsController(IStudentSubjectService studentSubjectService)
        {
            _studentSubjectService = studentSubjectService;
        }

        [HttpGet]
        public List<StudentSubject> Get()
        {
            return _studentSubjectService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public StudentSubject Get(int id)
        {
            return _studentSubjectService.Get(id);
        }

        [HttpPost]
        [Route("create")]
        public StudentSubject Create(StudentSubject model)
        {
            return _studentSubjectService.Add(model);
        }

        [HttpPatch]
        [Route("update")]
        public StudentSubject Update(StudentSubject faculty)
        {
            return _studentSubjectService.Update(faculty);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            return _studentSubjectService.Delete(id);
        }
    }
}
