using Microsoft.EntityFrameworkCore.Migrations;

namespace Survivor.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "PlayerName", "TotalDays" },
                values: new object[,]
                {
                    { 2, "Peter Harkey", 0 },
                    { 3, "Patricia Jackson", 0 },
                    { 4, "Hunter Ellis", 0 },
                    { 5, "Sarah Jones", 0 },
                    { 6, "Gabriel Cade", 0 }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "SeasonId", "SeasonName" },
                values: new object[] { 4, "Marquesas" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "SeasonId",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "SeasonId", "SeasonName" },
                values: new object[] { 1, "Marquesas" });
        }
    }
}
