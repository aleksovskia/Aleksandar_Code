﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi_Aleksandar_Aleksovski.Data;

namespace WebApi_Aleksandar_Aleksovski.Migrations
{
    [DbContext(typeof(FootballTeamDataContext))]
    partial class FootballTeamDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi_Aleksandar_Aleksovski.Entities.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojNaMedalji")
                        .HasColumnType("int");

                    b.Property<int>("FootBallTeamId")
                        .HasColumnType("int");

                    b.Property<string>("ImeNaKlubot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FootBallTeamId");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("WebApi_Aleksandar_Aleksovski.Entities.FootBallTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Dostignuvanje")
                        .HasColumnType("float");

                    b.Property<int>("Golovi")
                        .HasColumnType("int");

                    b.Property<string>("ImeTrener")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrezimeTrener")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FootBallTeam");
                });

            modelBuilder.Entity("WebApi_Aleksandar_Aleksovski.Entities.NatoinalTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Drzava")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FootBallTeamId")
                        .HasColumnType("int");

                    b.Property<int>("MegunarodniNastapi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FootBallTeamId");

                    b.ToTable("NatoinalTeam");
                });

            modelBuilder.Entity("WebApi_Aleksandar_Aleksovski.Entities.Club", b =>
                {
                    b.HasOne("WebApi_Aleksandar_Aleksovski.Entities.FootBallTeam", "FootBallTeam")
                        .WithMany("Clubs")
                        .HasForeignKey("FootBallTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FootBallTeam");
                });

            modelBuilder.Entity("WebApi_Aleksandar_Aleksovski.Entities.NatoinalTeam", b =>
                {
                    b.HasOne("WebApi_Aleksandar_Aleksovski.Entities.FootBallTeam", "FootBallTeam")
                        .WithMany("NatoinalTeams")
                        .HasForeignKey("FootBallTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FootBallTeam");
                });

            modelBuilder.Entity("WebApi_Aleksandar_Aleksovski.Entities.FootBallTeam", b =>
                {
                    b.Navigation("Clubs");

                    b.Navigation("NatoinalTeams");
                });
#pragma warning restore 612, 618
        }
    }
}
