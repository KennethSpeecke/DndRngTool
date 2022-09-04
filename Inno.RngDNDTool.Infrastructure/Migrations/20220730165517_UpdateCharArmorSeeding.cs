using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateCharArmorSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee71f39f-99d4-4396-9659-81a4e43ca562", "AQAAAAEAACcQAAAAEEWUVFV4aJDNUWMnRH1AlQoEahbB0+j00rGxTT3SBp4rBSXVbNq/nKOZzA7Zej/USg==", "4c35343a-4033-4e05-aa34-0b0fe50eef1d" });

            migrationBuilder.InsertData(
                table: "InventoryArmors",
                columns: new[] { "ArmorId", "InventoryId" },
                values: new object[] { new Guid("a66f53e9-605d-4ede-af78-f6cc985203ef"), new Guid("82b556d3-ecef-40d6-aaae-12bcf93592d2") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InventoryArmors",
                keyColumns: new[] { "ArmorId", "InventoryId" },
                keyValues: new object[] { new Guid("a66f53e9-605d-4ede-af78-f6cc985203ef"), new Guid("82b556d3-ecef-40d6-aaae-12bcf93592d2") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a584716b-2465-4841-9120-5d8dd492aa8e", "AQAAAAEAACcQAAAAENc8giMREVb4YTu3D3JZyAbT6BQTrtMLpHWBjR1m90z6NDrQdtNS1Fh8sl/XYC1nQQ==", "34416f9d-0785-4e7c-822e-da68193cdb93" });
        }
    }
}
