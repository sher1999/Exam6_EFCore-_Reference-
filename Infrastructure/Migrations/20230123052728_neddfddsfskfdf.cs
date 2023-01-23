using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class neddfddsfskfdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubjectID",
                table: "subjects",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "ClassroomID",
                table: "classrooms",
                newName: "ClassroomId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subjects_classrooms_ClassroomId",
                table: "subjects");

            migrationBuilder.DropIndex(
                name: "IX_subjects_ClassroomId",
                table: "subjects");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "subjects",
                newName: "SubjectID");

            migrationBuilder.RenameColumn(
                name: "ClassroomId",
                table: "classrooms",
                newName: "ClassroomID");
        }
    }
}
