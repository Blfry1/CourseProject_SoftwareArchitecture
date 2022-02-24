using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject_SoftwareArchitecture.Migrations
{
    public partial class M10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Lessons_LessonId",
                table: "Enrollments");

            migrationBuilder.AlterColumn<int>(
                name: "LessonId",
                table: "Enrollments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Lessons_LessonId",
                table: "Enrollments",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "LessonId",
                onDelete: ReferentialAction.Restrict);
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
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Lessons_LessonId",
                table: "Enrollments",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "LessonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
