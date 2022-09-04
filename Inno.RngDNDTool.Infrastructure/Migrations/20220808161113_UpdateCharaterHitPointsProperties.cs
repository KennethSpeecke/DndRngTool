using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateCharaterHitPointsProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentHitPoints",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxHitPoints",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TemporaryHitpoints",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbade729-8f0c-45cd-9275-b3f26adfa44e", "AQAAAAEAACcQAAAAEMoJXpiLY6bkuwBTlsP28ivaFvr5Kh9/IvEFK3xxwjNdDqAaw9CLoBRBQmFcXfuMsQ==", "a9a899fa-2668-429a-a56c-f7de30c68289" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("29bcd574-1436-4a71-a750-4484d10cb105"),
                columns: new[] { "CurrentHitPoints", "MaxHitPoints" },
                values: new object[] { 10, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentHitPoints",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "MaxHitPoints",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "TemporaryHitpoints",
                table: "Characters");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "208e7e08-aefb-4344-82a5-1cb649f8f0bb", "AQAAAAEAACcQAAAAEGLlclu1/JQrASNVZzcbxqhqTV7xxWDAIVFzEqJU/BmrjMFDkLF4+lw5mHBfYEhChw==", "30788a30-cee5-4bd7-b4b4-eb0d46d37a58" });
        }
    }
}
