using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class neddfddsskff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subjects_classrooms_ClassroomId",
                table: "subjects");

            migrationBuilder.DropIndex(
                name: "IX_subjects_ClassroomId",
                table: "subjects");

            migrationBuilder.DropColumn(
                name: "ClassroomId",
                table: "subjects");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassroomId",
                table: "subjects",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_subjects_ClassroomId",
                table: "subjects",
                column: "ClassroomId");

            migrationBuilder.AddForeignKey(
                name: "FK_subjects_classrooms_ClassroomId",
                table: "subjects",
                column: "ClassroomId",
                principalTable: "classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
