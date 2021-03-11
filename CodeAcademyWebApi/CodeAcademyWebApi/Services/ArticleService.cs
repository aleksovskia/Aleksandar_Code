using CodeAcademyWebApi.Data;
using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using CodeAcademyWebApi.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CodeAcademyWebApi.Services
{
    public class ArticleService : IArticleService
    {
        private readonly ICodeAcademyDataContext db;
        public ArticleService(ICodeAcademyDataContext db)
        {
            this.db = db;
        }
        public Article Add(Article a)
        {
            var article = db.Article.Add(a);
            db.SaveChanges();
            return article.Entity;
        }

        public bool Delete(int id)
        {
            var article = db.Article.FirstOrDefault(a => a.Id == id);
            db.Article.Remove(article);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public List<Article> Get()
        {
            return db.Article.ToList();
        }

        public Article Get(int id)
        {
            return db.Article.FirstOrDefault(a => a.Id == id);
        }

        public Article Update(Article a)
        {
            var updatedAtricle = db.Article.Update(a);
            db.SaveChanges();
            return updatedAtricle.Entity;
        }
    }
}
