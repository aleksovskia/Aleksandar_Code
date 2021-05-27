using CodeAcademyWebApi.Data;
using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeAcademyWebApi.Services
{
    public class StudentSubjectService : IStudentSubjectService
    {
        private readonly ICodeAcademyDataContext db;
        public StudentSubjectService(ICodeAcademyDataContext db)
        {
            this.db = db;
        }

        public List<StudentSubject> Get()
        {
            return db.StudentSubjects.ToList();
        }

        public StudentSubject Get(int id)
        {
            return db.StudentSubjects.FirstOrDefault(f => f.Id == id);
        }

        public StudentSubject Add(StudentSubject ss)
        {
            if (ss.Grade > 10)
                throw new Exception("The value is greater then 10.");
            var studentSubject = db.StudentSubjects.Add(ss);
            db.SaveChanges();
            return studentSubject.Entity;
        }

        public StudentSubject Update(StudentSubject ss)
        {
            var updatedStudentSubject = db.StudentSubjects.Update(ss);
            db.SaveChanges();
            return updatedStudentSubject.Entity;
        }

        public bool Delete(int id)
        {
            var studentSubject = db.StudentSubjects.FirstOrDefault(f => f.Id == id);
            db.StudentSubjects.Remove(studentSubject);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public double Rang(List<StudentSubject> studentSubject)
        {
            var rang = 0.0;

            foreach (var subject in studentSubject)
            {
                rang += subject.Grade;
            }

            return rang / studentSubject.Count;
        }
    }
}
