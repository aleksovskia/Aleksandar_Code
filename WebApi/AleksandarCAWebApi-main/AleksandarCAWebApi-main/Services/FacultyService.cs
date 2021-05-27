using CodeAcademyWebApi.Data;
using CodeAcademyWebApi.Entities;
using CodeAcademyWebApi.Models;
using CodeAcademyWebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CodeAcademyWebApi.Services
{
    public class FacultyService : IFacultyService
    {
        private readonly ICodeAcademyDataContext db;
        public FacultyService(ICodeAcademyDataContext db)
        {
            this.db = db;
        }

        public List<Faculty> Get()
        {
            //return db.Faculty.ToList(); - tuka vrakjame samo Id i Name od entitetot Fakultet. Ostanatite propertinja se null!
            //return db.Faculty.Include(f => f.Students).ToList(); - tuka vrakjame Fakulteti zaedno so lista od studenti!
            return db.Faculty.Include(f => f.Subjects).Include(f => f.Students).ThenInclude(s => s.Articles).ToList();
        }

        public Faculty Get(int id)
        {
            return db.Faculty.FirstOrDefault(f => f.Id == id);
        }

        public Faculty Add(Faculty faculty)
        {
            var f = db.Faculty.Add(faculty);
            db.SaveChanges();
            return f.Entity;
        }

        public Faculty Update(Faculty faculty)
        {
            var updatedFaculty = db.Faculty.Update(faculty);
            db.SaveChanges();
            return updatedFaculty.Entity;
        }

        public bool Delete(int id)
        {
            var faculty = db.Faculty.FirstOrDefault(f => f.Id == id);
            db.Faculty.Remove(faculty);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        //newFaculty - e objektot so osvezeni informacii na primer PMF sega e PRAVEN fakultet
        public Faculty SafeUpdate(int id, Faculty newFaculty)
        {
            var oldFaculty = db.Faculty.FirstOrDefault(f => f.Id == id); // bil PMF
            oldFaculty.Name = newFaculty.Name; // go menuvam imeto PMF so Praven
            var faculty = db.Faculty.Update(oldFaculty); // Ja updejtiram bazata
            // vrakja int, kolku promeni bile izvrseni. 
            //Vo ovoj slucaj toj broj treba da bide 1
            var count = db.SaveChanges();
            return faculty.Entity;
        }
    }
}
