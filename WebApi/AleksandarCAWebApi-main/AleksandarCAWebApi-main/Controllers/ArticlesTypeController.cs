using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademyWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesTypeController : ControllerBase
    {
        private readonly IArticleTypeService _articleTypeService;

        public ArticlesTypeController(IArticleTypeService articleTypeService)
        {
            _articleTypeService = articleTypeService;
        }

        [HttpGet]
        [Route("{id}")]
        public ArticleType Get(int id)
        {
            return _articleTypeService.Get(id);
        }

        [HttpGet]
        [Route("{value}")]
        public ArticleType Get(string value)
        {
            return _articleTypeService.Get(value);
        }

        [HttpPost]
        [Route("create")]
        public ArticleType Create(ArticleType model)
        {
            return _articleTypeService.Add(model);
        }

        [HttpPatch]
        [Route("update")]
        public ArticleType Update(ArticleType articleType)
        {
            return _articleTypeService.Update(articleType);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Delete(int id)
        {
            return _articleTypeService.Delete(id);
        }
    }
}
