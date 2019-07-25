using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class changedgames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_CreatorPlayerId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_Player1PlayerId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_Player2PlayerId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_WinnerPlayerId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_CreatorPlayerId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_Player1PlayerId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_Player2PlayerId",
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
                name: "Player2PlayerId",
                table: "Games",
                newName: "WinnerId");

            migrationBuilder.RenameColumn(
                name: "Player1PlayerId",
                table: "Games",
                newName: "Player2Id");

            migrationBuilder.AddColumn<long>(
                name: "CreatorId",
                table: "Games",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Player1Id",
                table: "Games",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Player1Id",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "WinnerId",
                table: "Games",
                newName: "Player2PlayerId");

            migrationBuilder.RenameColumn(
                name: "Player2Id",
                table: "Games",
                newName: "Player1PlayerId");

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
                name: "IX_Games_Player1PlayerId",
                table: "Games",
                column: "Player1PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Player2PlayerId",
                table: "Games",
                column: "Player2PlayerId");

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
                name: "FK_Games_Players_Player1PlayerId",
                table: "Games",
                column: "Player1PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Players_Player2PlayerId",
                table: "Games",
                column: "Player2PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Players_WinnerPlayerId",
                table: "Games",
                column: "WinnerPlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
