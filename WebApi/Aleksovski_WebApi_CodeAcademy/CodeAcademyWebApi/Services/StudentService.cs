using CodeAcademyWebApi.Data;
using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using CodeAcademyWebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CodeAcademyWebApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly ICodeAcademyDataContext db;
        public StudentService(ICodeAcademyDataContext db)
        {
            this.db = db;
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
    }
}
