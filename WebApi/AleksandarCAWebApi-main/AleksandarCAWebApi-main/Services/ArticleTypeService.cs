using CodeAcademyWebApi.Data;
using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using CodeAcademyWebApi.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CodeAcademyWebApi.Services
{
    public class ArticleTypeService : IArticleTypeService
    {
        private readonly ICodeAcademyDataContext db;

        public ArticleTypeService(ICodeAcademyDataContext db)
        {
            this.db = db;
        }       

        public ArticleType Add(ArticleType a)
        {
            var addedArticleType = db.ArticleType.Add(a);
            db.SaveChanges();
            return addedArticleType.Entity;
        }

        public bool Delete(int id)
        {
            var artilceType = db.ArticleType.FirstOrDefault(x => x.Id == id);
            db.ArticleType.Remove(artilceType);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public List<ArticleType> Get()
        {
            return db.ArticleType.ToList();
        }

        public ArticleType Get(string value)
        {
            var articleType = db.ArticleType.FirstOrDefault(at => at.Value == value);
            return articleType;
        }

        public ArticleType Get(int id)
        {
            return db.ArticleType.FirstOrDefault(x => x.Id == id);
        }

        public ArticleType Update(ArticleType a)
        {
            var updatedArticleType = db.ArticleType.Update(a);
            db.SaveChanges();
            return updatedArticleType.Entity;
        }
    }
}
