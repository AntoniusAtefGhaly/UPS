using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UPS.Data.Migrations
{
    public partial class profilePic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                schema: "security",
                table: "users",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                schema: "security",
                table: "users");
        }
    }
}
