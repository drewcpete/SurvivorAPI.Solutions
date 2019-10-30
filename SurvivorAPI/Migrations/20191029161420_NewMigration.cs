using Microsoft.EntityFrameworkCore.Migrations;

namespace Survivor.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentAge",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "GameAge",
                table: "Players",
                newName: "BirthYear");

            migrationBuilder.AddColumn<int>(
                name: "GameAge",
                table: "Appearances",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1,
                column: "BirthYear",
                value: 1975);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2,
                column: "BirthYear",
                value: 1956);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3,
                column: "BirthYear",
                value: 1952);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 4,
                column: "BirthYear",
                value: 1968);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 5,
                column: "BirthYear",
                value: 1977);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 6,
                column: "BirthYear",
                value: 1978);

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "BirthYear", "Gender", "PlayerName", "TotalDays", "Winner" },
                values: new object[] { 7, 1965, "Female", "Vecepia Towery", 0, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "GameAge",
                table: "Appearances");

            migrationBuilder.RenameColumn(
                name: "BirthYear",
                table: "Players",
                newName: "GameAge");

            migrationBuilder.AddColumn<int>(
                name: "CurrentAge",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 1,
                columns: new[] { "CurrentAge", "GameAge" },
                values: new object[] { 44, 0 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 2,
                columns: new[] { "CurrentAge", "GameAge" },
                values: new object[] { 63, 0 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 3,
                columns: new[] { "CurrentAge", "GameAge" },
                values: new object[] { 67, 0 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 4,
                columns: new[] { "CurrentAge", "GameAge" },
                values: new object[] { 51, 0 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 5,
                columns: new[] { "CurrentAge", "GameAge" },
                values: new object[] { 42, 0 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "PlayerId",
                keyValue: 6,
                columns: new[] { "CurrentAge", "GameAge" },
                values: new object[] { 41, 0 });
        }
    }
}
