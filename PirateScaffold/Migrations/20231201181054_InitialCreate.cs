using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PirateScaffold.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pirates",
                columns: table => new
                {
                    PirateID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Epithet = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Bounty = table.Column<long>(type: "INTEGER", nullable: false),
                    DevilFruit = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pirates", x => x.PirateID);
                });

            migrationBuilder.CreateTable(
                name: "PirateCrews",
                columns: table => new
                {
                    PirateCrewID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CrewName = table.Column<string>(type: "TEXT", nullable: false),
                    Ship = table.Column<string>(type: "TEXT", nullable: false),
                    PirateID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PirateCrews", x => x.PirateCrewID);
                    table.ForeignKey(
                        name: "FK_PirateCrews_Pirates_PirateID",
                        column: x => x.PirateID,
                        principalTable: "Pirates",
                        principalColumn: "PirateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PirateCrews_PirateID",
                table: "PirateCrews",
                column: "PirateID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PirateCrews");

            migrationBuilder.DropTable(
                name: "Pirates");
        }
    }
}
