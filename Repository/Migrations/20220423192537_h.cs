using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GamesTeam_GameId",
                table: "GamesTeam");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Minute = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameComments_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameComments_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GamesTeam_GameId",
                table: "GamesTeam",
                column: "GameId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GameComments_CommentId",
                table: "GameComments",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_GameComments_GameId",
                table: "GameComments",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameComments");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_GamesTeam_GameId",
                table: "GamesTeam");

            migrationBuilder.CreateIndex(
                name: "IX_GamesTeam_GameId",
                table: "GamesTeam",
                column: "GameId");
        }
    }
}
