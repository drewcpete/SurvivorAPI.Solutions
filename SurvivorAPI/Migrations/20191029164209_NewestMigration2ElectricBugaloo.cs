using Microsoft.EntityFrameworkCore.Migrations;

namespace Survivor.Migrations
{
    public partial class NewestMigration2ElectricBugaloo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appearances",
                keyColumn: "AppearanceId",
                keyValue: 1,
                columns: new[] { "DaysPerSeason", "GameAge" },
                values: new object[] { 11, 25 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appearances",
                keyColumn: "AppearanceId",
                keyValue: 1,
                columns: new[] { "DaysPerSeason", "GameAge" },
                values: new object[] { 0, 0 });
        }
    }
}
