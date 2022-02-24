using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject_SoftwareArchitecture.Migrations
{
    public partial class M9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Lessons_LessonId",
                table: "Enrollments");

            migrationBuilder.AlterColumn<int>(
                name: "LessonId",
                table: "Enrollments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Lessons_LessonId",
                table: "Enrollments",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "LessonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Lessons_LessonId",
                table: "Enrollments");

            migrationBuilder.AlterColumn<int>(
                name: "LessonId",
                table: "Enrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Lessons_LessonId",
                table: "Enrollments",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "LessonId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
