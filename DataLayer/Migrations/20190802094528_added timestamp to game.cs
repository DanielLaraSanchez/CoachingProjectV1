using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class addedtimestamptogame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTimeStamp",
                table: "Games",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTimeStamp",
                table: "Games");
        }
    }
}
