using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyWebApi.Services.Interfaces
{
    public interface IStudentSubjectService
    {
        List<StudentSubject> Get();
        StudentSubject Get(int id);
        StudentSubject Add(StudentSubject ss);
        StudentSubject Update(StudentSubject ss);
        bool Delete(int id);
        double Rang(List<StudentSubject> studentSubject);
    }
}
