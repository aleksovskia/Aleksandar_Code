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
        private readonly IFootballTeamDataContext db;
      

        public NatoinalTeamServices(IFootballTeamDataContext db)
        {
            this.db = db;
        }

        public double Achievement(NatoinalTeam natoinalTeams)
        {
            return (natoinalTeams.FootBallTeam.Golovi * natoinalTeams.FootBallTeam.Koeficient) + natoinalTeams.MegunarodniNastapi;  
        }

        public double Achievement(int natoinalTeamId)
        {
         //   var natoinalTeam = db.NatoinalTeam.Where(x => x.Id == natoinalTeamId).FirstOrDefault();
        //    return Achievement(natoinalTeam.Id);
            var natoinalTeam = db.NatoinalTeam.FirstOrDefault(x => x.Id == natoinalTeamId);
            natoinalTeam.FootBallTeam = db.FootBallTeam.FirstOrDefault(x => x.Id == natoinalTeam.FootBallTeamId);
            return Achievement(natoinalTeam);
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
            // return db.NatoinalTeam.Include(c => c.Drzava).Include(b => b.MegunarodniNastapi).ToList();
            return db.NatoinalTeam.ToList();
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

