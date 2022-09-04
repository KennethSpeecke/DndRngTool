using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateScrollProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scrolls_Spells_SpellId",
                table: "Scrolls");

            migrationBuilder.AlterColumn<Guid>(
                name: "SpellId",
                table: "Scrolls",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24dc8df3-9e4f-45fc-89cd-0e499cd25602", "AQAAAAEAACcQAAAAEA1OZ6IGKoG4MQGavmDkTAixx9Se7KtFlP+cN6ofKPqY/WjpJoT/FtEWK0hhYoGi0w==", "348afe50-0a0b-4bb4-8973-ba4ce30e7421" });

            migrationBuilder.AddForeignKey(
                name: "FK_Scrolls_Spells_SpellId",
                table: "Scrolls",
                column: "SpellId",
                principalTable: "Spells",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scrolls_Spells_SpellId",
                table: "Scrolls");

            migrationBuilder.AlterColumn<Guid>(
                name: "SpellId",
                table: "Scrolls",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9fce503-2993-411e-9871-5f1d548a6a7b", "AQAAAAEAACcQAAAAEFuY2cNXAw1TKwcctlhJBQEp3PYJWp5o8Y48HyvPNbCEeR675CQkq/DSfbATJC4iOA==", "7d5547cd-6ac3-4f48-9cb3-c4c2b89d688d" });

            migrationBuilder.AddForeignKey(
                name: "FK_Scrolls_Spells_SpellId",
                table: "Scrolls",
                column: "SpellId",
                principalTable: "Spells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
