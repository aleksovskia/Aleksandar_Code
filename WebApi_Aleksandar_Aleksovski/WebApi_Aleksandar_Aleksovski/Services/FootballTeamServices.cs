using WebApi_Aleksandar_Aleksovski.Data;
using WebApi_Aleksandar_Aleksovski.Entities;
using WebApi_Aleksandar_Aleksovski.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WebApi_Aleksandar_Aleksovski.Services
{
    public class FootballTeamServices : IFootballTeamServices
    {
        private readonly IFootballTeamDataContext db;
        public FootballTeamServices(IFootballTeamDataContext db)
        {
            this.db = db;
        }


        public FootBallTeam Add(FootBallTeam ft)
        {
            var foodballlTeam = db.FootBallTeam.Add(ft);
            db.SaveChanges();
            return foodballlTeam.Entity;
        }


        public bool Delete(int id)
        {
            var foodballlTeam = db.FootBallTeam.FirstOrDefault(c => c.Id == id);
            db.FootBallTeam.Remove(foodballlTeam);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public List<FootBallTeam> Get()
        {
            // return db.FootBallTeam.Include(c => c.ImeTrener).Include(b => b.PrezimeTrener).Include(x=> x.Golovi).ToList();
            return db.FootBallTeam.ToList();
        }

        public FootBallTeam Get(int id)
        {
            return db.FootBallTeam.FirstOrDefault(c => c.Id == id);

        }

        public FootBallTeam Update(FootBallTeam footBallTeam)
        {
            var updatedFootballTeam = db.FootBallTeam.Update(footBallTeam);
            db.SaveChanges();
            return updatedFootballTeam.Entity;
        }

        
    }
}
