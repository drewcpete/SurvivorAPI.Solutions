using Microsoft.EntityFrameworkCore.Migrations;

namespace Survivor.Migrations
{
    public partial class UpdateNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeasonPlayerId",
                table: "SeasonPlayers",
                newName: "AppearanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppearanceId",
                table: "SeasonPlayers",
                newName: "SeasonPlayerId");
        }
    }
}
