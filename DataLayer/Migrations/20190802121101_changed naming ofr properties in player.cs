using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class changednamingofrpropertiesinplayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "Players",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Players",
                newName: "PlayerId");
        }
    }
}
