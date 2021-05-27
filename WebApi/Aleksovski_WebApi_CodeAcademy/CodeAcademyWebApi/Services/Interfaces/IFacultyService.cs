using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyWebApi.Services.Interfaces
{
    public interface IFacultyService
    {
        List<Faculty> Get();
        Faculty Get(int id);
        Faculty Add(Faculty fmr);
        Faculty Update(Faculty faculty);
        Faculty SafeUpdate(int id, Faculty newFaculty);
        bool Delete(int id);
    }
}
