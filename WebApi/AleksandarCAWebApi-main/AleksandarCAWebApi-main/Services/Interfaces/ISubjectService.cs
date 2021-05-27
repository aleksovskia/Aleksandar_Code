using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyWebApi.Services.Interfaces
{
    public interface ISubjectService
    {
        List<Subject> Get();
        Subject Get(int id);
        Subject Add(Subject s);
        Subject Update(Subject s);
        bool Delete(int id);
    }
}
