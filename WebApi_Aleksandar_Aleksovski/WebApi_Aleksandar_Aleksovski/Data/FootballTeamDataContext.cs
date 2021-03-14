using WebApi_Aleksandar_Aleksovski.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApi_Aleksandar_Aleksovski.Data
{
    public interface IFootballTeamDataContext
    {
        DbSet<Club> Club { get; set; }
        DbSet<FootBallTeam> FootBallTeam { get; set; }
        DbSet<NatoinalTeam> NatoinalTeam { get; set; }

        int SaveChanges();
    }
    public class FootballTeamDataContext : DbContext, IFootballTeamDataContext
    {
        public DbSet<Club> Club { get; set; }
        public DbSet<FootBallTeam> FootBallTeam { get; set;  }
        public DbSet<NatoinalTeam> NatoinalTeam { get; set; }

        public FootballTeamDataContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FootBallTeam>()
                .HasMany<NatoinalTeam>(nationalTeam => nationalTeam.NatoinalTeams)
                .WithOne(NatoinalTeam => NatoinalTeam.FootBallTeam)
                .HasForeignKey(s => s.FootBallTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FootBallTeam>()
                .HasMany<Club>(club => club.Clubs)
                .WithOne(Club => Club.FootBallTeam)
                .HasForeignKey(s => s.FootBallTeamId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
