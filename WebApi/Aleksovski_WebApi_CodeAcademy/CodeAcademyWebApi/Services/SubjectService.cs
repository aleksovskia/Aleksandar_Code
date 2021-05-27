using CodeAcademyWebApi.Data;
using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using CodeAcademyWebApi.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CodeAcademyWebApi.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ICodeAcademyDataContext db;
        public SubjectService(ICodeAcademyDataContext db)
        {
            this.db = db;
        }

        public List<Subject> Get()
        {
            return db.Subject.ToList();
        }

        public Subject Get(int id)
        {
            return db.Subject.FirstOrDefault(f => f.Id == id);
        }

        public Subject Add(Subject s)
        {
            var subject = db.Subject.Add(s);
            db.SaveChanges();
            return subject.Entity;
        }

        public Subject Update(Subject s)
        {
            var updatedSubject = db.Subject.Update(s);
            db.SaveChanges();
            return updatedSubject.Entity;
        }

        public bool Delete(int id)
        {
            var subject = db.Subject.FirstOrDefault(f => f.Id == id);
            db.Subject.Remove(subject);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }
    }
}
