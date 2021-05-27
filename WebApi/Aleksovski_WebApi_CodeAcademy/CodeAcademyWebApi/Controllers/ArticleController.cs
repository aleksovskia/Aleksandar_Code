using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyWebApi.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpGet]
        public List<Article> Get()
        {
            return _articleService.Get();
        }

        [HttpGet]
        [Route("{id}")]
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
        [Route("update")]
        public Article Update(Article Subject)
        {
            return _articleService.Update(Subject);
        }
    }
}
