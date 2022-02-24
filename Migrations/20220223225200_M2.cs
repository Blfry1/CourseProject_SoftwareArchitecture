using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject_SoftwareArchitecture.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Coaches_CoachId",
                table: "Sessions");

            migrationBuilder.AlterColumn<int>(
                name: "CoachId",
                table: "Sessions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Coaches_CoachId",
                table: "Sessions",
                column: "CoachId",
                principalTable: "Coaches",
                principalColumn: "CoachId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Coaches_CoachId",
                table: "Sessions");

            migrationBuilder.AlterColumn<int>(
                name: "CoachId",
                table: "Sessions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Coaches_CoachId",
                table: "Sessions",
                column: "CoachId",
                principalTable: "Coaches",
                principalColumn: "CoachId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
