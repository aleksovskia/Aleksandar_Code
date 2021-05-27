using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyWebApi.Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> Get();
        Student Get(int id);
        Student Add(Student s);
        Student Update(Student s);
        bool Delete(int id);

        List<Student> GetByFacultyId(int facultyId);
    }
}
