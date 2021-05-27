using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAcademyWebApi.Migrations
{
    public partial class Domasna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Student_StudentId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_StudentId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Subject");

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "Subject",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "Article",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StudentSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocenka = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_FacultyId",
                table: "Subject",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_FacultyId",
                table: "Article",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_StudentId",
                table: "StudentSubjects",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_SubjectId",
                table: "StudentSubjects",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Faculty_FacultyId",
                table: "Article",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Faculty_FacultyId",
                table: "Subject",
                column: "FacultyId",
                principalTable: "Faculty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Faculty_FacultyId",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Faculty_FacultyId",
                table: "Subject");

            migrationBuilder.DropTable(
                name: "StudentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_Subject_FacultyId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Article_FacultyId",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "Article");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Subject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_StudentId",
                table: "Subject",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Student_StudentId",
                table: "Subject",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
