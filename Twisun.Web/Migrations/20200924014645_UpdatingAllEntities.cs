using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Twisun.Web.Migrations
{
    public partial class UpdatingAllEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_Cars_CarId",
                table: "Batteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Coupons_Partners_PartnerId",
                table: "Coupons");

            migrationBuilder.DropForeignKey(
                name: "FK_Points_Owners_OwnerId",
                table: "Points");

            migrationBuilder.DropForeignKey(
                name: "FK_Ranges_Cars_CarId",
                table: "Ranges");

            migrationBuilder.DropForeignKey(
                name: "FK_SolarPanels_Cars_CarId",
                table: "SolarPanels");

            migrationBuilder.DropForeignKey(
                name: "FK_UsedCoupons_Coupons_CouponId",
                table: "UsedCoupons");

            migrationBuilder.DropForeignKey(
                name: "FK_UsedCoupons_Owners_OwnerId",
                table: "UsedCoupons");

            migrationBuilder.DropIndex(
                name: "IX_SolarPanels_CarId",
                table: "SolarPanels");

            migrationBuilder.DropIndex(
                name: "IX_Points_OwnerId",
                table: "Points");

            migrationBuilder.DropIndex(
                name: "IX_Batteries_CarId",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "SolarPanels");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Batteries");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "UsedCoupons",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CouponId",
                table: "UsedCoupons",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SolarPanels",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "SolarPanels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "SolarPanels",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "Ranges",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Ranges",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Points",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Points",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Partners",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Partners",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Owners",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Owners",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalPoints",
                table: "Owners",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PartnerId",
                table: "Coupons",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Coupons",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Coupons",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "TotalKm",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<float>(
                name: "SolarKm",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<float>(
                name: "ChargedBatteries",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Cars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Cars",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Batteries",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Batteries",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Batteries",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "AspNetUsers",
                rowVersion: true,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Points_OwnerId",
                table: "Points",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_Cars_Id",
                table: "Batteries",
                column: "Id",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Coupons_Partners_PartnerId",
                table: "Coupons",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Points_Owners_OwnerId",
                table: "Points",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ranges_Cars_CarId",
                table: "Ranges",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SolarPanels_Cars_Id",
                table: "SolarPanels",
                column: "Id",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsedCoupons_Coupons_CouponId",
                table: "UsedCoupons",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsedCoupons_Owners_OwnerId",
                table: "UsedCoupons",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batteries_Cars_Id",
                table: "Batteries");

            migrationBuilder.DropForeignKey(
                name: "FK_Coupons_Partners_PartnerId",
                table: "Coupons");

            migrationBuilder.DropForeignKey(
                name: "FK_Points_Owners_OwnerId",
                table: "Points");

            migrationBuilder.DropForeignKey(
                name: "FK_Ranges_Cars_CarId",
                table: "Ranges");

            migrationBuilder.DropForeignKey(
                name: "FK_SolarPanels_Cars_Id",
                table: "SolarPanels");

            migrationBuilder.DropForeignKey(
                name: "FK_UsedCoupons_Coupons_CouponId",
                table: "UsedCoupons");

            migrationBuilder.DropForeignKey(
                name: "FK_UsedCoupons_Owners_OwnerId",
                table: "UsedCoupons");

            migrationBuilder.DropIndex(
                name: "IX_Points_OwnerId",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "SolarPanels");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "SolarPanels");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Ranges");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Points");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "TotalPoints",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "UsedCoupons",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CouponId",
                table: "UsedCoupons",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SolarPanels",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "SolarPanels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "Ranges",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Points",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PartnerId",
                table: "Coupons",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "TotalKm",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "SolarKm",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "ChargedBatteries",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Batteries",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Batteries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SolarPanels_CarId",
                table: "SolarPanels",
                column: "CarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Points_OwnerId",
                table: "Points",
                column: "OwnerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Batteries_CarId",
                table: "Batteries",
                column: "CarId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Batteries_Cars_CarId",
                table: "Batteries",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Coupons_Partners_PartnerId",
                table: "Coupons",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Points_Owners_OwnerId",
                table: "Points",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ranges_Cars_CarId",
                table: "Ranges",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolarPanels_Cars_CarId",
                table: "SolarPanels",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsedCoupons_Coupons_CouponId",
                table: "UsedCoupons",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsedCoupons_Owners_OwnerId",
                table: "UsedCoupons",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
