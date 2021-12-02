using Microsoft.EntityFrameworkCore.Migrations;

namespace Dirarys_Final_Project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guilds",
                columns: table => new
                {
                    GuildID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    MoralAlignment = table.Column<string>(maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guilds", x => x.GuildID);
                });

            migrationBuilder.CreateTable(
                name: "LandOfOrigins",
                columns: table => new
                {
                    LandOfOriginID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Climate = table.Column<string>(maxLength: 15, nullable: false),
                    GoverningType = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandOfOrigins", x => x.LandOfOriginID);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Race = table.Column<string>(maxLength: 20, nullable: false),
                    Specialization = table.Column<string>(maxLength: 20, nullable: false),
                    LandID = table.Column<int>(nullable: false),
                    GuildID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterID);
                    table.ForeignKey(
                        name: "FK_Characters_Guilds_GuildID",
                        column: x => x.GuildID,
                        principalTable: "Guilds",
                        principalColumn: "GuildID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_LandOfOrigins_LandID",
                        column: x => x.LandID,
                        principalTable: "LandOfOrigins",
                        principalColumn: "LandOfOriginID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_GuildID",
                table: "Characters",
                column: "GuildID");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_LandID",
                table: "Characters",
                column: "LandID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Guilds");

            migrationBuilder.DropTable(
                name: "LandOfOrigins");
        }
    }
}
