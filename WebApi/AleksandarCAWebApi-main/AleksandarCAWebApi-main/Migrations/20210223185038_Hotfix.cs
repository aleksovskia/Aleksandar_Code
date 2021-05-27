using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAcademyWebApi.Migrations
{
    public partial class Hotfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "Ocenka",
                table: "StudentSubjects");

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "StudentSubjects",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "StudentSubjects");

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Subject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ocenka",
                table: "StudentSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
