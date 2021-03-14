using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_Aleksandar_Aleksovski.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FootBallTeam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImeTrener = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrezimeTrener = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Golovi = table.Column<int>(type: "int", nullable: false),
                    Dostignuvanje = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootBallTeam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImeNaKlubot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojNaMedalji = table.Column<int>(type: "int", nullable: false),
                    FootBallTeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Club_FootBallTeam_FootBallTeamId",
                        column: x => x.FootBallTeamId,
                        principalTable: "FootBallTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NatoinalTeam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Drzava = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MegunarodniNastapi = table.Column<int>(type: "int", nullable: false),
                    FootBallTeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatoinalTeam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NatoinalTeam_FootBallTeam_FootBallTeamId",
                        column: x => x.FootBallTeamId,
                        principalTable: "FootBallTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Club_FootBallTeamId",
                table: "Club",
                column: "FootBallTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_NatoinalTeam_FootBallTeamId",
                table: "NatoinalTeam",
                column: "FootBallTeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "NatoinalTeam");

            migrationBuilder.DropTable(
                name: "FootBallTeam");
        }
    }
}
