using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Twisun.Web.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Plaque = table.Column<string>(maxLength: 6, nullable: false),
                    Model = table.Column<int>(maxLength: 4, nullable: false),
                    TotalKm = table.Column<float>(nullable: false),
                    SolarKm = table.Column<float>(nullable: false),
                    ChargedBatteries = table.Column<float>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updtaed_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Batteries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Capacity = table.Column<float>(nullable: false),
                    StateOfCharge = table.Column<float>(nullable: false),
                    SolarLevel = table.Column<float>(nullable: false),
                    OutletLevel = table.Column<float>(nullable: false),
                    StateOfHealth = table.Column<float>(nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updtaed_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batteries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Batteries_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ranges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<float>(nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ranges_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolarPanels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Serial = table.Column<string>(nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updtaed_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarPanels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolarPanels_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DailySolarEnergies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<float>(nullable: false),
                    SolarPanelId = table.Column<int>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailySolarEnergies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailySolarEnergies_SolarPanels_SolarPanelId",
                        column: x => x.SolarPanelId,
                        principalTable: "SolarPanels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_CarId",
                table: "Batteries",
                column: "CarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DailySolarEnergies_SolarPanelId",
                table: "DailySolarEnergies",
                column: "SolarPanelId");

            migrationBuilder.CreateIndex(
                name: "IX_Ranges_CarId",
                table: "Ranges",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarPanels_CarId",
                table: "SolarPanels",
                column: "CarId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batteries");

            migrationBuilder.DropTable(
                name: "DailySolarEnergies");

            migrationBuilder.DropTable(
                name: "Ranges");

            migrationBuilder.DropTable(
                name: "SolarPanels");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
