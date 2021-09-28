using Microsoft.EntityFrameworkCore.Migrations;

namespace UPS.Data.Migrations
{
    public partial class entities3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDesleted",
                table: "Courses",
                newName: "IsDeleted");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "security",
                table: "users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Expenses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "security",
                table: "users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Courses",
                newName: "IsDesleted");
        }
    }
}
