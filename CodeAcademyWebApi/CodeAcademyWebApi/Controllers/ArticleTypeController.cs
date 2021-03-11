using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyWebApi.Controllers
{
    public class ArticleTypeController : Controller
    {
        private readonly IArticleTypeService _articleTypeService;

        public ArticleTypeController(IArticleTypeService articleTypeService)
        {
            _articleTypeService = articleTypeService;
        }
        [HttpGet]
        public List<ArticleType> Get()
        {
            return _articleTypeService.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public ArticleType Get(int id)
        {
            return _articleTypeService.Get(id);
        }

        [HttpPost]
        [Route("create")]
        public ArticleType Create(ArticleType model)
        {
            return _articleTypeService.Add(model);
        }

        [HttpPatch]
        [Route("update")]
        public ArticleType Update(ArticleType Subject)
        {
            return _articleTypeService.Update(Subject);
        }
    }
}
