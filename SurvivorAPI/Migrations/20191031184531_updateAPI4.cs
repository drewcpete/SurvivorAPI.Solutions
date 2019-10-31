using Microsoft.EntityFrameworkCore.Migrations;

namespace Survivor.Migrations
{
    public partial class updateAPI4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Users_User1Id",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_Users_User1Id",
                table: "Seasons");

            migrationBuilder.DropIndex(
                name: "IX_Seasons_User1Id",
                table: "Seasons");

            migrationBuilder.DropIndex(
                name: "IX_Players_User1Id",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "User1Id",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "User1Id",
                table: "Players");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "User1Id",
                table: "Seasons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "User1Id",
                table: "Players",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_User1Id",
                table: "Seasons",
                column: "User1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Players_User1Id",
                table: "Players",
                column: "User1Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Users_User1Id",
                table: "Players",
                column: "User1Id",
                principalTable: "Users",
                principalColumn: "User1Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Users_User1Id",
                table: "Seasons",
                column: "User1Id",
                principalTable: "Users",
                principalColumn: "User1Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
