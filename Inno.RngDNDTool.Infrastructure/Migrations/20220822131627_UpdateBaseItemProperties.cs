using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateBaseItemProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsUsed",
                table: "Weapons",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsUsed",
                table: "Scrolls",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsUsed",
                table: "Potions",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsUsed",
                table: "Foods",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsUsed",
                table: "Armors",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48EECD0F-9D00-401C-A96C-C75F9C1ABBEA",
                column: "ConcurrencyStamp",
                value: "ffed9d25-620b-49e7-aef8-c3954b2504e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76842942-dde9-4306-869c-c9dd5bc93360", "AQAAAAEAACcQAAAAEPHfP1nv7WWlCG6fpzERA89jYZKsHZ1VWOsxBPsyVkBhWndbDJwZqgEbqFwwkmFEwA==", "0c264227-df64-42c9-83b4-954a91832337" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsUsed",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "IsUsed",
                table: "Scrolls");

            migrationBuilder.DropColumn(
                name: "IsUsed",
                table: "Potions");

            migrationBuilder.DropColumn(
                name: "IsUsed",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "IsUsed",
                table: "Armors");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48EECD0F-9D00-401C-A96C-C75F9C1ABBEA",
                column: "ConcurrencyStamp",
                value: "02c2b82e-7668-4928-9935-07215f7155a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8ab9b84-0f60-4728-b69a-f07143bdb8cd", "AQAAAAEAACcQAAAAEEBFkfdXH/psEFeE3m4psrUjggthu8CJ1/8dDqwFuotDP8mIrhc6LNk8xSW5P3cRSQ==", "96dab4e0-df57-484b-b3a0-dd1fdf2bf2bb" });
        }
    }
}
