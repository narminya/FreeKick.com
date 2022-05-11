using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class start13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Groups_GroupId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_GroupId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Games");

            migrationBuilder.AddColumn<string>(
                name: "AwayTeamRes",
                table: "GamesTeam",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeTeamRes",
                table: "GamesTeam",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwayTeamRes",
                table: "GamesTeam");

            migrationBuilder.DropColumn(
                name: "HomeTeamRes",
                table: "GamesTeam");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_GroupId",
                table: "Games",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Groups_GroupId",
                table: "Games",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
