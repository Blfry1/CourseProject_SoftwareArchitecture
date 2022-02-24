using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject_SoftwareArchitecture.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateofBirth",
                table: "Swimmers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Swimmers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Swimmers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateofBirth",
                table: "Swimmers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Swimmers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Swimmers");
        }
    }
}
