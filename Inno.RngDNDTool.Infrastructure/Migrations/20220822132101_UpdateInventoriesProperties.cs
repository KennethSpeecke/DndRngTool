using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateInventoriesProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsEquiped",
                table: "InventoryWeapons",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsConsumed",
                table: "InventoryScrolls",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsConsumed",
                table: "InventoryPotions",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsConsumed",
                table: "InventoryFoods",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsEquiped",
                table: "InventoryArmors",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48EECD0F-9D00-401C-A96C-C75F9C1ABBEA",
                column: "ConcurrencyStamp",
                value: "513c9fed-81f3-40c1-9baa-bb562f89e8e3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "867ac167-6328-41fa-813c-a012abc7c703", "AQAAAAEAACcQAAAAEAm9DKz3s0M40KFAF+R/e5CYip1G931cdf+s8/Wi81aMHKcaJzq9ArBz61jFz08/DQ==", "bd73db43-c3f7-4172-9ea1-665cc0e47c65" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEquiped",
                table: "InventoryWeapons");

            migrationBuilder.DropColumn(
                name: "IsConsumed",
                table: "InventoryScrolls");

            migrationBuilder.DropColumn(
                name: "IsConsumed",
                table: "InventoryPotions");

            migrationBuilder.DropColumn(
                name: "IsConsumed",
                table: "InventoryFoods");

            migrationBuilder.DropColumn(
                name: "IsEquiped",
                table: "InventoryArmors");

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
    }
}
