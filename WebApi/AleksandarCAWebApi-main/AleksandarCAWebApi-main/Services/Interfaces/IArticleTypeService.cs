using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
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
        ArticleType Get(string value);
        ArticleType Add(ArticleType a);
        ArticleType Update(ArticleType a);
        bool Delete(int id);
    }
}
