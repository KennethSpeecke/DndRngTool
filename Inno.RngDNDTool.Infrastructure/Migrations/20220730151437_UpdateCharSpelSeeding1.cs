using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateCharSpelSeeding1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a584716b-2465-4841-9120-5d8dd492aa8e", "AQAAAAEAACcQAAAAENc8giMREVb4YTu3D3JZyAbT6BQTrtMLpHWBjR1m90z6NDrQdtNS1Fh8sl/XYC1nQQ==", "34416f9d-0785-4e7c-822e-da68193cdb93" });

            migrationBuilder.InsertData(
                table: "CharacterSpells",
                columns: new[] { "CharacterId", "SpellId" },
                values: new object[,]
                {
                    { new Guid("29bcd574-1436-4a71-a750-4484d10cb105"), new Guid("6e42ce23-9081-4b91-b38d-a77f1436baff") },
                    { new Guid("29bcd574-1436-4a71-a750-4484d10cb105"), new Guid("9fcd8482-df14-4e47-8433-ffae30e74735") },
                    { new Guid("29bcd574-1436-4a71-a750-4484d10cb105"), new Guid("c16a9a18-a96d-47fe-a49e-0ee0088e7e2d") },
                    { new Guid("29bcd574-1436-4a71-a750-4484d10cb105"), new Guid("d12be89a-e0df-441f-b1c2-4f91557b4d1c") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterSpells",
                keyColumns: new[] { "CharacterId", "SpellId" },
                keyValues: new object[] { new Guid("29bcd574-1436-4a71-a750-4484d10cb105"), new Guid("6e42ce23-9081-4b91-b38d-a77f1436baff") });

            migrationBuilder.DeleteData(
                table: "CharacterSpells",
                keyColumns: new[] { "CharacterId", "SpellId" },
                keyValues: new object[] { new Guid("29bcd574-1436-4a71-a750-4484d10cb105"), new Guid("9fcd8482-df14-4e47-8433-ffae30e74735") });

            migrationBuilder.DeleteData(
                table: "CharacterSpells",
                keyColumns: new[] { "CharacterId", "SpellId" },
                keyValues: new object[] { new Guid("29bcd574-1436-4a71-a750-4484d10cb105"), new Guid("c16a9a18-a96d-47fe-a49e-0ee0088e7e2d") });

            migrationBuilder.DeleteData(
                table: "CharacterSpells",
                keyColumns: new[] { "CharacterId", "SpellId" },
                keyValues: new object[] { new Guid("29bcd574-1436-4a71-a750-4484d10cb105"), new Guid("d12be89a-e0df-441f-b1c2-4f91557b4d1c") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e071247d-ca71-4567-a548-0163fd82f45b", "AQAAAAEAACcQAAAAEAns7GUHwOt6TcSI8DU+GWgp8ZgYn9HSoVQArjkWQ/luCpCu5taObgt67mdOA1UhyQ==", "b4cd5e8a-09c0-4fac-8e91-3c4a078322d7" });
        }
    }
}
