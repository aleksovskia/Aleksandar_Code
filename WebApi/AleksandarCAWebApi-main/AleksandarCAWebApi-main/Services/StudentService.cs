using CodeAcademyWebApi.Data;
using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using CodeAcademyWebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeAcademyWebApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly ICodeAcademyDataContext db;
        private readonly IStudentSubjectService _studentSubjectService;
        private readonly IArticleService _articleService;

        public StudentService(ICodeAcademyDataContext db, IStudentSubjectService studentSubjectService, IArticleService articleService)
        {
            this.db = db;
            _studentSubjectService = studentSubjectService;
            _articleService = articleService;
        }

        public List<Student> Get()
        {
            return db.Student.ToList();
        }

        public Student Get(int id)
        {
            return db.Student.FirstOrDefault(x => x.Id == id);
        }

        public Student Add(Student s)
        {
            var student = db.Student.Add(s);
            db.SaveChanges();
            return student.Entity;
        }

        public Student Update(Student s)
        {
            var updatedStudent = db.Student.Update(s);
            db.SaveChanges();
            return updatedStudent.Entity;
        }

        public bool Delete(int id)
        {
            var student = db.Student.FirstOrDefault(x => x.Id == id);
            db.Student.Remove(student);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public List<Student> GetByFacultyId(int facultyId)
        {
            var students = db.Student.Where(x => x.FacultyId == facultyId).ToList();
            return students;
        }

        public (int ConferenceCount, int JournalCount) CountArticlesTypeByStudentId(int studentId)
        {
            var articles = _articleService.GetByStudentId(studentId);
            return _articleService.CountArticlesByType(articles);
        }

        public double Rang(int studentId)
        {
            var student = db.Student.Where(x => x.Id == studentId).FirstOrDefault();
            return Rang(student);
        }

        public double Rang(Student student)
        {
            var isPhd = student.IsPHD;
            var studentSubject = db.StudentSubjects.Where(ss => ss.StudentId == student.Id).ToList();
            var rang = _studentSubjectService.Rang(studentSubject);

            if (isPhd)
            {
                var articles = db.Article.Include(x => x.Type).Where(article => article.StudentId == student.Id).ToList();
                return rang + _articleService.PHDArticleRang(articles);
            }

            return rang;
        }

        public Article AddArticle(Student s, Article a)
        {
            var addedArticle = AddArticle(s.Id, s.StartYear, a);
            return addedArticle;
        }

        public Article AddArticle(int studentId, int startYear, Article a)
        {
            if (a.PublishYear < startYear)
                throw new Exception("Article publish year is older then the student start year.");

            a.StudentId = studentId;
            var addedArticle = _articleService.Add(a);
            return addedArticle;
        }
    }
}
