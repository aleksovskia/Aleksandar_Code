using CodeAcademyWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyWebApi.Services.Interfaces
{
    public interface IArticleTypeService
    {
        List<ArticleType> Get();
        ArticleType Get(int id);
        ArticleType Add(ArticleType at);
        ArticleType Update(ArticleType at);
        bool Delete(int id);
    }
}
