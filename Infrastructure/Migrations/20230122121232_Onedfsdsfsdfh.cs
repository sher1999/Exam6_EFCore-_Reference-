using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Onedfsdsfsdfh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "issues",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_issues_StudentId",
                table: "issues",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_issues_students_StudentId",
                table: "issues",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_issues_students_StudentId",
                table: "issues");

            migrationBuilder.DropIndex(
                name: "IX_issues_StudentId",
                table: "issues");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "issues");
        }
    }
}
