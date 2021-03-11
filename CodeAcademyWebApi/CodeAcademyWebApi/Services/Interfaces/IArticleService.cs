using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyWebApi.Services.Interfaces
{
    public interface IArticleService
    {
        List<Article> Get();
        Article Get(int id);
        Article Add(Article a);
        Article Update(Article a);
        bool Delete(int id);
    }
}