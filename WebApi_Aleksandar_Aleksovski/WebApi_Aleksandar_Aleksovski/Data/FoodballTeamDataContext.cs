using WebApi_Aleksandar_Aleksovski.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApi_Aleksandar_Aleksovski.Data
{
    public interface IFoodballTeamDataContext
    {
        DbSet<Club> Club { get; set; }
        DbSet<FoodBallTeam> FoodBallTeam { get; set; }
        DbSet<NatoinalTeam> NatoinalTeam { get; set; }

        int SaveChanges();
    }
    public class FoodballTeamDataContext : DbContext, IFoodballTeamDataContext
    {
        public DbSet<Club> Club { get; set; }
        public DbSet<FoodBallTeam> FoodBallTeam { get; set;  }
        public DbSet<NatoinalTeam> NatoinalTeam { get; set; }

        public FoodballTeamDataContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }


}
