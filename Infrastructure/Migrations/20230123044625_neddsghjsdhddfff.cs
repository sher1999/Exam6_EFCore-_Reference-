using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class neddsghjsdhddfff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_subjects_ClassroomId",
                table: "subjects");

            migrationBuilder.CreateIndex(
                name: "IX_subjects_ClassroomId",
                table: "subjects",
                column: "ClassroomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_subjects_ClassroomId",
                table: "subjects");

            migrationBuilder.CreateIndex(
                name: "IX_subjects_ClassroomId",
                table: "subjects",
                column: "ClassroomId",
                unique: true);
        }
    }
}
