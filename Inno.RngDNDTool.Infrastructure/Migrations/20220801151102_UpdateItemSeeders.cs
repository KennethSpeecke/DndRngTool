using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateItemSeeders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9fce503-2993-411e-9871-5f1d548a6a7b", "AQAAAAEAACcQAAAAEFuY2cNXAw1TKwcctlhJBQEp3PYJWp5o8Y48HyvPNbCEeR675CQkq/DSfbATJC4iOA==", "7d5547cd-6ac3-4f48-9cb3-c4c2b89d688d" });

            migrationBuilder.InsertData(
                table: "InventoryPotions",
                columns: new[] { "InventoryId", "PotionId" },
                values: new object[] { new Guid("82b556d3-ecef-40d6-aaae-12bcf93592d2"), new Guid("b9f5c577-d2f8-4c39-ade1-ba5f33684dca") });

            migrationBuilder.InsertData(
                table: "InventoryWeapons",
                columns: new[] { "InventoryId", "WeaponId" },
                values: new object[] { new Guid("82b556d3-ecef-40d6-aaae-12bcf93592d2"), new Guid("8ecd50d4-9079-4428-9ec5-f45b5abce6c7") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InventoryPotions",
                keyColumns: new[] { "InventoryId", "PotionId" },
                keyValues: new object[] { new Guid("82b556d3-ecef-40d6-aaae-12bcf93592d2"), new Guid("b9f5c577-d2f8-4c39-ade1-ba5f33684dca") });

            migrationBuilder.DeleteData(
                table: "InventoryWeapons",
                keyColumns: new[] { "InventoryId", "WeaponId" },
                keyValues: new object[] { new Guid("82b556d3-ecef-40d6-aaae-12bcf93592d2"), new Guid("8ecd50d4-9079-4428-9ec5-f45b5abce6c7") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d788d99-191e-493a-a980-99e9dd5c4b52", "AQAAAAEAACcQAAAAEFh20fzJOilppVQm4ukC0CGWRdODDKQax3dTRD9Wme4SDYPnzcCXlq31bENyx6768w==", "107dd7f0-f4b3-44ea-a1fe-3bca4583f398" });
        }
    }
}
