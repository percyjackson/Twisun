using Microsoft.EntityFrameworkCore.Migrations;

namespace Twisun.Web.Migrations
{
    public partial class DeleteReferenceOnDailySolarEnergy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailySolarEnergies_SolarPanels_SolarPanelId",
                table: "DailySolarEnergies");

            migrationBuilder.AlterColumn<int>(
                name: "SolarPanelId",
                table: "DailySolarEnergies",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_DailySolarEnergies_SolarPanels_SolarPanelId",
                table: "DailySolarEnergies",
                column: "SolarPanelId",
                principalTable: "SolarPanels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailySolarEnergies_SolarPanels_SolarPanelId",
                table: "DailySolarEnergies");

            migrationBuilder.AlterColumn<int>(
                name: "SolarPanelId",
                table: "DailySolarEnergies",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DailySolarEnergies_SolarPanels_SolarPanelId",
                table: "DailySolarEnergies",
                column: "SolarPanelId",
                principalTable: "SolarPanels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
