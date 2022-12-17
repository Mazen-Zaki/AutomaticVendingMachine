using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomaticVendingMachine.Data.Migrations
{
    public partial class addProfilePictureToUserColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                schema: "security",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                schema: "security",
                table: "Users");
        }
    }
}
