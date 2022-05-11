using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class start1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OuterId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_OuterId",
                table: "Games",
                column: "OuterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_OuterLeagues_OuterId",
                table: "Games",
                column: "OuterId",
                principalTable: "OuterLeagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_OuterLeagues_OuterId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_OuterId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "OuterId",
                table: "Games");
        }
    }
}
