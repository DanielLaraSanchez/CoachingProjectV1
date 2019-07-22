using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class correctData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Playery1Won",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "EmailAdress",
                table: "Players",
                newName: "EmailAddress");

            migrationBuilder.AddColumn<long>(
                name: "CreatorPlayerId",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "WinnerPlayerId",
                table: "Games",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_CreatorPlayerId",
                table: "Games",
                column: "CreatorPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_WinnerPlayerId",
                table: "Games",
                column: "WinnerPlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Players_CreatorPlayerId",
                table: "Games",
                column: "CreatorPlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Players_WinnerPlayerId",
                table: "Games",
                column: "WinnerPlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_CreatorPlayerId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_WinnerPlayerId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_CreatorPlayerId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_WinnerPlayerId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CreatorPlayerId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "WinnerPlayerId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Players",
                newName: "EmailAdress");

            migrationBuilder.AddColumn<bool>(
                name: "Playery1Won",
                table: "Games",
                nullable: true);
        }
    }
}
