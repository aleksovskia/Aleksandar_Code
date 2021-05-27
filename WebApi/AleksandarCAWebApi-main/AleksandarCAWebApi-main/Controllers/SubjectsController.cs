using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CodeAcademyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectService _subjectService;

        public SubjectsController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpGet]
        public List<Subject> Get()
        {
            return _subjectService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Subject Get(int id)
        {
            return _subjectService.Get(id);
        }

        [HttpPost]
        [Route("create")]
        public Subject Create(Subject model)
        {
            return _subjectService.Add(model);
        }

        [HttpPatch]
        [Route("update")]
        public Subject Update(Subject faculty)
        {
            return _subjectService.Update(faculty);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            return _subjectService.Delete(id);
        }
    }
}
