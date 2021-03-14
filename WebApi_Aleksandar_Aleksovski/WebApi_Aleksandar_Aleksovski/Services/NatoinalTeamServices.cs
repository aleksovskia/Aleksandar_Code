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

        public double Achievement(List<NatoinalTeam> natoinalTeams)
        {
            
            
            var nastapi = 0.0;
            var koefivient = 0.0;
            var golovi = 0.0;
            foreach (var achievement in natoinalTeams)
            {
               nastapi += achievement.MegunarodniNastapi;
               golovi += achievement.FootBallTeam.Golovi;
               koefivient = +achievement.FootBallTeam.Koeficient;

            }
            return (nastapi * koefivient) + golovi;
            
        }

        public double Achievement(int footballTeamId)
        {
            var natoinalTeam = db.NatoinalTeam.Where(x => x.Id == footballTeamId).FirstOrDefault();
            return Achievement(natoinalTeam.Id);
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

