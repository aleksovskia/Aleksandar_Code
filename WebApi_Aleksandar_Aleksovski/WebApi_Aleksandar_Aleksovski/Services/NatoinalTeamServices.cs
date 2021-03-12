using WebApi_Aleksandar_Aleksovski.Data;
using WebApi_Aleksandar_Aleksovski.Entities;
using WebApi_Aleksandar_Aleksovski.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WebApi_Aleksandar_Aleksovski.Services
{
    public class NatoinalTeamServices : INatoinalTeamServices
    {
        private readonly IFoodballTeamDataContext db;
        public NatoinalTeamServices(IFoodballTeamDataContext db)
        {
            this.db = db;
        }
        public NatoinalTeam Add(NatoinalTeam nt)
        {
            var nationalTeam = db.NatoinalTeam.Add(nt);
            db.SaveChanges();
            return nationalTeam.Entity;
        }
        public bool Delete(int id)
        {
            var nationalTeam = db.NatoinalTeam.FirstOrDefault(c => c.Id == id);
            db.NatoinalTeam.Remove(nationalTeam);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }
        public List<NatoinalTeam> Get()
        {
            return db.NatoinalTeam.Include(c => c.Drzava).Include(b => b.MegunarodniNastapi).ToList();
        }
        public NatoinalTeam Get(int id)
        {
            return db.NatoinalTeam.FirstOrDefault(c => c.Id == id);
        }
        public NatoinalTeam Update(NatoinalTeam natoinalTeam)
        {
            var updatedNationalTeam = db.NatoinalTeam.Update(natoinalTeam);
            db.SaveChanges();
            return updatedNationalTeam.Entity;
        }
    }
}

