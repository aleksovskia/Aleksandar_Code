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
    public class FacultiesController : ControllerBase
    {
        private readonly IFacultyService _facultiesService;

        public FacultiesController(IFacultyService facultiesService)
        {
            _facultiesService = facultiesService;
        }

        //localhost:4200/Faculties
        [HttpGet]
        public List<Faculty> Get()
        {
            return _facultiesService.Get();
        }

        //localhost:4200/Faculties/1
        [HttpGet]
        [Route("{id}")]
        public Faculty Get(int id)
        {
            return _facultiesService.Get(id);
        }

        [HttpPost]
        [Route("create")]
        public Faculty Create(Faculty model)
        {
            return _facultiesService.Add(model);
        }

        //localhost:4200/Faculties/1
        [HttpPatch]
        [Route("update")]
        public Faculty Update(Faculty faculty)
        {
            return _facultiesService.Update(faculty);
        }
    }
}
