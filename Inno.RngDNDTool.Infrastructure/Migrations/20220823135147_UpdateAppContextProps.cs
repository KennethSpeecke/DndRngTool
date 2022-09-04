using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateAppContextProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterRaces_Race_RaceId",
                table: "CharacterRaces");

            migrationBuilder.DropForeignKey(
                name: "FK_RacesLanguages_Race_RaceId",
                table: "RacesLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceTraits_Race_RaceId",
                table: "RaceTraits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Race",
                table: "Race");

            migrationBuilder.RenameTable(
                name: "Race",
                newName: "Races");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Races",
                table: "Races",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48EECD0F-9D00-401C-A96C-C75F9C1ABBEA",
                column: "ConcurrencyStamp",
                value: "c31ad5e0-208c-49ea-8958-6ea2236e2626");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b46a06b3-4a13-404d-8860-7025c67f637b", "AQAAAAEAACcQAAAAEKEbeHEg0kP7W2Altonlwf/XJ8gk8EUhuRnRBMQ44rZJKKa//RX5UAt5xpG+Du4TKw==", "68d89f7d-3734-4d25-8209-13904ed9b2b2" });

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterRaces_Races_RaceId",
                table: "CharacterRaces",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RacesLanguages_Races_RaceId",
                table: "RacesLanguages",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceTraits_Races_RaceId",
                table: "RaceTraits",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterRaces_Races_RaceId",
                table: "CharacterRaces");

            migrationBuilder.DropForeignKey(
                name: "FK_RacesLanguages_Races_RaceId",
                table: "RacesLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceTraits_Races_RaceId",
                table: "RaceTraits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Races",
                table: "Races");

            migrationBuilder.RenameTable(
                name: "Races",
                newName: "Race");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Race",
                table: "Race",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterRaces_Race_RaceId",
                table: "CharacterRaces",
                column: "RaceId",
                principalTable: "Race",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RacesLanguages_Race_RaceId",
                table: "RacesLanguages",
                column: "RaceId",
                principalTable: "Race",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceTraits_Race_RaceId",
                table: "RaceTraits",
                column: "RaceId",
                principalTable: "Race",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
