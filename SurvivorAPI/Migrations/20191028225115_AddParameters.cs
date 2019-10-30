using Microsoft.EntityFrameworkCore.Migrations;

namespace Survivor.Migrations
{
    public partial class AddParameters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Seasons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Seasons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentAge",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameAge",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Winner",
                table: "Players",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Appearances",
                keyColumn: "AppearanceId",
                keyValue: 1,
                column: "SeasonId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1,
                columns: new[] { "CurrentAge", "Gender" },
                values: new object[] { -1974, "Male" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2,
                columns: new[] { "CurrentAge", "Gender" },
                values: new object[] { -1955, "Male" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3,
                columns: new[] { "CurrentAge", "Gender" },
                values: new object[] { -1951, "Female" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 4,
                columns: new[] { "CurrentAge", "Gender" },
                values: new object[] { -1967, "Male" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 5,
                columns: new[] { "CurrentAge", "Gender" },
                values: new object[] { -1976, "Female" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 6,
                columns: new[] { "CurrentAge", "Gender" },
                values: new object[] { -1977, "Male" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "CurrentAge",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "GameAge",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Winner",
                table: "Players");

            migrationBuilder.UpdateData(
                table: "Appearances",
                keyColumn: "AppearanceId",
                keyValue: 1,
                column: "SeasonId",
                value: 1);
        }
    }
}
