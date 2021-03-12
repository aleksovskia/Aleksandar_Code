using WebApi_Aleksandar_Aleksovski.Data;
using WebApi_Aleksandar_Aleksovski.Entities;
using WebApi_Aleksandar_Aleksovski.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WebApi_Aleksandar_Aleksovski.Services
{
    public class FoodballTeam : IFoodballTeamServices
    {
        private readonly IFoodballTeamDataContext db;
        public FoodballTeam(IFoodballTeamDataContext db)
        {
            this.db = db;
        }

        public FoodBallTeam Add(FoodBallTeam ft)
        {
            var foodballlTeam = db.FoodBallTeam.Add(ft);
            db.SaveChanges();
            return foodballlTeam.Entity;
        }

        public bool Delete(int id)
        {
            var foodballlTeam = db.FoodBallTeam.FirstOrDefault(c => c.Id == id);
            db.FoodBallTeam.Remove(foodballlTeam);
            var changesCount = db.SaveChanges();
            return changesCount == 1;
        }

        public List<FoodBallTeam> Get()
        {
            return db.FoodBallTeam.Include(c => c.ImeTrener).Include(b => b.PrezimeTrener).ToList();
        }

        public FoodBallTeam Get(int id)
        {
            return db.FoodBallTeam.FirstOrDefault(c => c.Id == id);

        }

        public FoodBallTeam Update(FoodBallTeam foodBallTeam)
        {
            var updatedFoodballTeam = db.FoodBallTeam.Update(foodBallTeam);
            db.SaveChanges();
            return updatedFoodballTeam.Entity;
        }
    }
}
