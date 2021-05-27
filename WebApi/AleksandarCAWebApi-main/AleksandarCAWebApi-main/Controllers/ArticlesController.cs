using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using CodeAcademyWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace CodeAcademyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IArticleTypeService _articleTypeService;
        private readonly IArticleService _articleService;

        public ArticlesController(IArticleTypeService articleTypeService, IStudentService studentService, IArticleService articleService)
        {
            _studentService = studentService;
            _articleTypeService = articleTypeService;
            _articleService = articleService;
        }

        [HttpPost]
        [Route("{studentId}")]
        public Article AddArticle(int studentId, ArticleModelRequest avm)
        {
            var articleType = _articleTypeService.Get(avm.Type);
            var student = _studentService.Get(studentId);
            var article = new Article()
            {
                PublishYear = avm.PublishYear,
                Title = avm.Title,
                TypeId = articleType.Id,
                FacultyId = student.FacultyId,
                StudentId = studentId,
            };

            var addedArticle = _studentService.AddArticle(studentId, student.StartYear, article);
            return addedArticle;
        }

        [HttpGet]
        [Route("{Id}")]
        public Article Get(int id)
        {
            return _articleService.Get(id);
        }

        [HttpPost]
        [Route("create")]
        public Article Create(Article model)
        {
            return _articleService.Add(model);
        }

        [HttpPatch]
        [Route("update/{id}")]
        public Article Update(Article article)
        {
            return _articleService.Update(article);
        }

        [HttpPost]
        [Route("delete")]
        public bool Delete(int id)
        {
            return _articleService.Delete(id);
        }

        [HttpGet]
        public List<Article> Get()
        {
            return _articleService.Get();
        }
    }
}
