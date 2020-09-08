using Microsoft.EntityFrameworkCore.Migrations;

namespace Twisun.Web.Migrations
{
    public partial class AddIndexInPlaqueOnCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Cars_Plaque",
                table: "Cars",
                column: "Plaque",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cars_Plaque",
                table: "Cars");
        }
    }
}
