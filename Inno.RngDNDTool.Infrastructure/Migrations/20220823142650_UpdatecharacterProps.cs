using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdatecharacterProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Characters",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48EECD0F-9D00-401C-A96C-C75F9C1ABBEA",
                column: "ConcurrencyStamp",
                value: "2a1bdc2d-4243-49ff-a6ea-08923ecbb3d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87110ee8-5852-4f5c-b9ed-4fb646455e0e", "AQAAAAEAACcQAAAAEK4YcWLeeV9N1xjPBa3ENkeTB+UVfHXypjwEm36zY9yNM76dq2ZStiKx7/AmEEOhyQ==", "72b2da2b-dd32-40d1-8a95-addda872b62e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Characters");

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
        }
    }
}
