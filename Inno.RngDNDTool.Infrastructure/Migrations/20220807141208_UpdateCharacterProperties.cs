using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateCharacterProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Allignment",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Background",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bonds",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Experience",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Flaws",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ideals",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PersonalTraits",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Race",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36712751-8e38-4f4a-a40f-3564c2193800", "AQAAAAEAACcQAAAAEIgc3P+4imE+3Uh6X+uWrZ5KAeSne7NXXwHxHJyvcoArn+YOIu4igLd1l4vEFUMbYg==", "c9c33eb3-d2a6-41eb-b251-0d810ecf3a53" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: new Guid("29bcd574-1436-4a71-a750-4484d10cb105"),
                columns: new[] { "Allignment", "Background", "Bonds", "Flaws", "Ideals", "Level", "PersonalTraits", "Race" },
                values: new object[] { "Lawfull Evil", "Acolyte", "I will someday get revenge on the corrupt temple hierarchy who branded me a heretic.", "I am suspicious of strangers and expect the worst in them.", "Tradition. The ancient traditions of worship and sacrifice must be preserved and upheld.(Lawfull)", 1, "I see omens in every event and action. The gods try to speak to us, we just need to listen.", "Grung" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Allignment",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Background",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Bonds",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Flaws",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Ideals",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "PersonalTraits",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Race",
                table: "Characters");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24dc8df3-9e4f-45fc-89cd-0e499cd25602", "AQAAAAEAACcQAAAAEA1OZ6IGKoG4MQGavmDkTAixx9Se7KtFlP+cN6ofKPqY/WjpJoT/FtEWK0hhYoGi0w==", "348afe50-0a0b-4bb4-8973-ba4ce30e7421" });
        }
    }
}
