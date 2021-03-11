using CodeAcademyWebApi.Data;
using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyWebApi.Services
{
    public class ArticleTypeService : IArticleTypeService
    {
        private readonly ICodeAcademyDataContext db;
        public ArticleTypeService(ICodeAcademyDataContext db)
        {
            this.db = db;
        }

        public ArticleType Add(ArticleType at)
        {
            var articleType = db.ArticleType.Add(at);
            db.SaveChanges();
            return articleType.Entity;
        }

        public bool Delete(int id)
        {
            var articleType = db.ArticleType.FirstOrDefault(at => at.Id == id);
            db.ArticleType.Remove(articleType);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public List<ArticleType> Get()
        {
            return db.ArticleType.ToList();
        }

        public ArticleType Get(int id)
        {
            return db.ArticleType.FirstOrDefault(at => at.Id == id);
        }

        public ArticleType Update(ArticleType at)
        {
            var updatedAtricleType = db.ArticleType.Update(at);
            db.SaveChanges();
            return updatedAtricleType.Entity;
        }
    }
}
