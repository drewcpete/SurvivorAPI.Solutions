using Microsoft.EntityFrameworkCore.Migrations;

namespace Survivor.Migrations
{
    public partial class AddDaysPerSeason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayerDays",
                table: "Players",
                newName: "TotalDays");

            migrationBuilder.AddColumn<int>(
                name: "DaysPerSeason",
                table: "SeasonPlayers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysPerSeason",
                table: "SeasonPlayers");

            migrationBuilder.RenameColumn(
                name: "TotalDays",
                table: "Players",
                newName: "PlayerDays");
        }
    }
}
