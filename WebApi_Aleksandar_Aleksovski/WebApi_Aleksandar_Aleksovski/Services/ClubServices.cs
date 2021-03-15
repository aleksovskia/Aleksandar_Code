using WebApi_Aleksandar_Aleksovski.Data;
using WebApi_Aleksandar_Aleksovski.Entities;
using WebApi_Aleksandar_Aleksovski.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WebApi_Aleksandar_Aleksovski.Services
{
    public class ClubServices : IClubServices
    {
        private readonly IFootballTeamDataContext db;
        private readonly IFootballTeamServices _ft;
        

        public ClubServices(IFootballTeamDataContext db,IFootballTeamServices ft)
        {
            this.db = db;
            _ft = ft;
        }
        public Club Add(Club c)
        {
            var club = db.Club.Add(c);
            db.SaveChanges();
            return club.Entity;
        }
        public bool Delete(int id)
        {
            var club = db.Club.FirstOrDefault(c => c.Id == id);
            db.Club.Remove(club);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }
        public List<Club> Get()
        {
            return db.Club.Include(c => c.ImeNaKlubot).Include(b => b.BrojNaMedalji).ToList();
        }
        public Club Get(int id)
        {
            return db.Club.FirstOrDefault(c => c.Id == id);
        }
        public Club Update(Club club)
        {
            var updatedClub = db.Club.Update(club);
            db.SaveChanges();
            return updatedClub.Entity;
        }


        public double Achievement(Club club)
        {

            return (club.BrojNaMedalji * club.FootBallTeam.Koeficient) + club.FootBallTeam.Golovi;
        }

        public double Achievement(int clubId)
        {
            // var club = db.Club.Where(x => x.Id == clubId).FirstOrDefault();
            // return Achievement(clubId);
            var club = db.Club.FirstOrDefault(x => x.Id == clubId);
            club.FootBallTeam = db.FootBallTeam.FirstOrDefault(x => x.Id == club.FootBallTeamId);
            return Achievement(club);
        }
    }
}
