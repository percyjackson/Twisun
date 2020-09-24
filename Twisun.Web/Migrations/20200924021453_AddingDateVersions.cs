using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Twisun.Web.Migrations
{
    public partial class AddingDateVersions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "SolarPanels");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "UsedCoupons",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "SolarPanels",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Ranges",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Points",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Partners",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Owners",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "DailySolarEnergies",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Coupons",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Cars",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Batteries",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "AspNetUsers",
                newName: "UpdateAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "SolarPanels",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Partners",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Owners",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Coupons",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Cars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Batteries",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "SolarPanels");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Batteries");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "UsedCoupons",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "SolarPanels",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Ranges",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Points",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Partners",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Owners",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "DailySolarEnergies",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Coupons",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Cars",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "Batteries",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "AspNetUsers",
                newName: "Date");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "SolarPanels",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Partners",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Owners",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Coupons",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Cars",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Batteries",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "AspNetUsers",
                rowVersion: true,
                nullable: true);
        }
    }
}
