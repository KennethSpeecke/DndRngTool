using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateCharaterPropsAndSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armors_Characters_CharacterId",
                table: "Armors");

            migrationBuilder.DropIndex(
                name: "IX_Armors_CharacterId",
                table: "Armors");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Armors");

            migrationBuilder.AddColumn<Guid>(
                name: "EquipedArmorId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EquipedMainHandWeaponId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2288818-91b6-4cbb-9001-fe607a4cc8a5", "AQAAAAEAACcQAAAAEJOBJ/NGDO5o2L3U3s6LWaDaI9lc8o0jdrPyXf5BxYB45pbl80Az7NoudUQnL2R85A==", "4009468b-ffba-4c5b-9094-823b6a5e90e5" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("29bcd574-1436-4a71-a750-4484d10cb105"),
                columns: new[] { "EquipedArmorId", "EquipedMainHandWeaponId" },
                values: new object[] { new Guid("a66f53e9-605d-4ede-af78-f6cc985203ef"), new Guid("8ecd50d4-9079-4428-9ec5-f45b5abce6c7") });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_EquipedArmorId",
                table: "Characters",
                column: "EquipedArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_EquipedMainHandWeaponId",
                table: "Characters",
                column: "EquipedMainHandWeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Armors_EquipedArmorId",
                table: "Characters",
                column: "EquipedArmorId",
                principalTable: "Armors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Weapons_EquipedMainHandWeaponId",
                table: "Characters",
                column: "EquipedMainHandWeaponId",
                principalTable: "Weapons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Armors_EquipedArmorId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Weapons_EquipedMainHandWeaponId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_EquipedArmorId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_EquipedMainHandWeaponId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "EquipedArmorId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "EquipedMainHandWeaponId",
                table: "Characters");

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterId",
                table: "Armors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07bf3410-b8c6-4224-8f78-c1941f9a1a14", "AQAAAAEAACcQAAAAEAR7hpIKVKMaAfuLVPiCY3ST7Qm/X6uqdWVM6Hm7hiGcmaYNdSRz6IkSWUu0RDBDNg==", "4436e861-dd2b-496c-8448-90608b099030" });

            migrationBuilder.CreateIndex(
                name: "IX_Armors_CharacterId",
                table: "Armors",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Armors_Characters_CharacterId",
                table: "Armors",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");
        }
    }
}
