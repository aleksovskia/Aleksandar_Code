using CodeAcademyWebApi.Data;
using CodeAcademyWebApi.Entities;
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

        public List<Article> Get()
        {
            return db.Article.ToList();
        }

        public List<Article> GetByStudentId(int studentId)
        {
            return db.Article.Where(x => x.StudentId == studentId).ToList();
        }

        public Article Get(int id)
        {
            return db.Article.FirstOrDefault(a => a.Id == id);
        }

        public Article Add(Article a)
        {
            var addedArticle = db.Article.Add(a);
            db.SaveChanges();
            return addedArticle.Entity;
        }

        public Article Update(Article a)
        {
            var updatedArticle = db.Article.Update(a);
            db.SaveChanges();
            return updatedArticle.Entity;
        }

        public bool Delete(int id)
        {
            var artilce = db.Article.FirstOrDefault(x => x.Id == id);
            db.Article.Remove(artilce);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public double PHDArticleRang(List<Article> articles)
        {
            var rang = 0;
            foreach (var article in articles)
            {
                if (article.Type.Value.ToLower() == "conference")
                {
                    rang += 1;
                }
                if (article.Type.Value.ToLower() == "journal")
                {
                    rang += 3;
                }
            }
            return rang;
        }

        public (int ConferenceCount, int JournalCount) CountArticlesByType(List<Article> articles)
        {
            var confCount = 0;
            var journalCount = 0;
            foreach (var article in articles)
            {
                if (article.Type.Value.ToLower() == "conference")
                {
                    confCount += 1;
                }
                if (article.Type.Value.ToLower() == "journal")
                {
                    journalCount += 3;
                }
            }
            return (confCount, journalCount);
        }
    }
}
