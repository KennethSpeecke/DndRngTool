using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateInventoryProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaxCoinStack",
                table: "Inventories",
                newName: "SilverPieces");

            migrationBuilder.AddColumn<int>(
                name: "CopperPieces",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElectrumPieces",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoldPieces",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlatinumPieces",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "208e7e08-aefb-4344-82a5-1cb649f8f0bb", "AQAAAAEAACcQAAAAEGLlclu1/JQrASNVZzcbxqhqTV7xxWDAIVFzEqJU/BmrjMFDkLF4+lw5mHBfYEhChw==", "30788a30-cee5-4bd7-b4b4-eb0d46d37a58" });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("82b556d3-ecef-40d6-aaae-12bcf93592d2"),
                columns: new[] { "GoldPieces", "SilverPieces" },
                values: new object[] { 15, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CopperPieces",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "ElectrumPieces",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "GoldPieces",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "PlatinumPieces",
                table: "Inventories");

            migrationBuilder.RenameColumn(
                name: "SilverPieces",
                table: "Inventories",
                newName: "MaxCoinStack");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36712751-8e38-4f4a-a40f-3564c2193800", "AQAAAAEAACcQAAAAEIgc3P+4imE+3Uh6X+uWrZ5KAeSne7NXXwHxHJyvcoArn+YOIu4igLd1l4vEFUMbYg==", "c9c33eb3-d2a6-41eb-b251-0d810ecf3a53" });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("82b556d3-ecef-40d6-aaae-12bcf93592d2"),
                column: "MaxCoinStack",
                value: 100);
        }
    }
}
