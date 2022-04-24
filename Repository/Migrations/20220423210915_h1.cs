using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class h1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_League_LeagueId",
                table: "Games");

            migrationBuilder.AlterColumn<int>(
                name: "LeagueId",
                table: "Games",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OuterLeague",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OuterLeague", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Letter = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    OuterLeagueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_OuterLeague_OuterLeagueId",
                        column: x => x.OuterLeagueId,
                        principalTable: "OuterLeague",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GroupId",
                table: "Games",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_OuterLeagueId",
                table: "Group",
                column: "OuterLeagueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Group_GroupId",
                table: "Games",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_League_LeagueId",
                table: "Games",
                column: "LeagueId",
                principalTable: "League",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Group_GroupId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_League_LeagueId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "OuterLeague");

            migrationBuilder.DropIndex(
                name: "IX_Games_GroupId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Games");

            migrationBuilder.AlterColumn<int>(
                name: "LeagueId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_League_LeagueId",
                table: "Games",
                column: "LeagueId",
                principalTable: "League",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
