using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateCharaterRaceAndClassSeeding1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07bf3410-b8c6-4224-8f78-c1941f9a1a14", "AQAAAAEAACcQAAAAEAR7hpIKVKMaAfuLVPiCY3ST7Qm/X6uqdWVM6Hm7hiGcmaYNdSRz6IkSWUu0RDBDNg==", "4436e861-dd2b-496c-8448-90608b099030" });

            migrationBuilder.InsertData(
                table: "CharacterRaces",
                columns: new[] { "CharacterId", "RaceId" },
                values: new object[] { new Guid("29bcd574-1436-4a71-a750-4484d10cb105"), new Guid("97398aed-9dd3-48b3-9689-9dd455db396f") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterRaces",
                keyColumns: new[] { "CharacterId", "RaceId" },
                keyValues: new object[] { new Guid("29bcd574-1436-4a71-a750-4484d10cb105"), new Guid("97398aed-9dd3-48b3-9689-9dd455db396f") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67e88e54-6495-4ad8-88a1-2117a5eccac3", "AQAAAAEAACcQAAAAEG4pbGbB5hkz55RHZFlawKDqhI//u8IkbvIiQJo7T/u3+XKz/BiwQ01Po1pc4QnbDQ==", "f6057741-eb7b-404a-8a4d-95bd89aaad62" });
        }
    }
}
