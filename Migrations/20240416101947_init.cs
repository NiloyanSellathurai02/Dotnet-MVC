using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Sport_1A2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    playersCount = table.Column<int>(type: "int", nullable: false),
                    playedGames = table.Column<int>(type: "int", nullable: false),
                    won = table.Column<int>(type: "int", nullable: false),
                    currentRank = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teamid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.id);
                    table.ForeignKey(
                        name: "FK_Player_Team_Teamid",
                        column: x => x.Teamid,
                        principalTable: "Team",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_Teamid",
                table: "Player",
                column: "Teamid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
