using Microsoft.EntityFrameworkCore.Migrations;

namespace Survivor.Migrations
{
    public partial class UpdatedNamesAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeasonPlayers_Players_PlayerId",
                table: "SeasonPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_SeasonPlayers_Seasons_SeasonId",
                table: "SeasonPlayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeasonPlayers",
                table: "SeasonPlayers");

            migrationBuilder.RenameTable(
                name: "SeasonPlayers",
                newName: "Appearances");

            migrationBuilder.RenameIndex(
                name: "IX_SeasonPlayers_SeasonId",
                table: "Appearances",
                newName: "IX_Appearances_SeasonId");

            migrationBuilder.RenameIndex(
                name: "IX_SeasonPlayers_PlayerId",
                table: "Appearances",
                newName: "IX_Appearances_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appearances",
                table: "Appearances",
                column: "AppearanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appearances_Players_PlayerId",
                table: "Appearances",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appearances_Seasons_SeasonId",
                table: "Appearances",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appearances_Players_PlayerId",
                table: "Appearances");

            migrationBuilder.DropForeignKey(
                name: "FK_Appearances_Seasons_SeasonId",
                table: "Appearances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appearances",
                table: "Appearances");

            migrationBuilder.RenameTable(
                name: "Appearances",
                newName: "SeasonPlayers");

            migrationBuilder.RenameIndex(
                name: "IX_Appearances_SeasonId",
                table: "SeasonPlayers",
                newName: "IX_SeasonPlayers_SeasonId");

            migrationBuilder.RenameIndex(
                name: "IX_Appearances_PlayerId",
                table: "SeasonPlayers",
                newName: "IX_SeasonPlayers_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeasonPlayers",
                table: "SeasonPlayers",
                column: "AppearanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonPlayers_Players_PlayerId",
                table: "SeasonPlayers",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonPlayers_Seasons_SeasonId",
                table: "SeasonPlayers",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
