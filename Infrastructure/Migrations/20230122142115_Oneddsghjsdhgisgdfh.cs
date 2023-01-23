using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Oneddsghjsdhgisgdfh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_results_StudentId",
                table: "results",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_results_SubjectId",
                table: "results",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceTeachers_TeacherId",
                table: "AttendanceTeachers",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceStudents_StudentId",
                table: "AttendanceStudents",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceStudents_students_StudentId",
                table: "AttendanceStudents",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceTeachers_teachers_TeacherId",
                table: "AttendanceTeachers",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_results_students_StudentId",
                table: "results",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_results_subjects_SubjectId",
                table: "results",
                column: "SubjectId",
                principalTable: "subjects",
                principalColumn: "SubjectID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceStudents_students_StudentId",
                table: "AttendanceStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceTeachers_teachers_TeacherId",
                table: "AttendanceTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_results_students_StudentId",
                table: "results");

            migrationBuilder.DropForeignKey(
                name: "FK_results_subjects_SubjectId",
                table: "results");

            migrationBuilder.DropIndex(
                name: "IX_results_StudentId",
                table: "results");

            migrationBuilder.DropIndex(
                name: "IX_results_SubjectId",
                table: "results");

            migrationBuilder.DropIndex(
                name: "IX_AttendanceTeachers_TeacherId",
                table: "AttendanceTeachers");

            migrationBuilder.DropIndex(
                name: "IX_AttendanceStudents_StudentId",
                table: "AttendanceStudents");
        }
    }
}
