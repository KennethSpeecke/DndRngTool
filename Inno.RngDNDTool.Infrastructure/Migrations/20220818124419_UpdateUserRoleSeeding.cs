using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateUserRoleSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48EECD0F-9D00-401C-A96C-C75F9C1ABBEA", "02c2b82e-7668-4928-9935-07215f7155a2", "admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8ab9b84-0f60-4728-b69a-f07143bdb8cd", "AQAAAAEAACcQAAAAEEBFkfdXH/psEFeE3m4psrUjggthu8CJ1/8dDqwFuotDP8mIrhc6LNk8xSW5P3cRSQ==", "96dab4e0-df57-484b-b3a0-dd1fdf2bf2bb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "48EECD0F-9D00-401C-A96C-C75F9C1ABBEA", "faa97b2c-8771-4aea-b899-e560fd892455" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "48EECD0F-9D00-401C-A96C-C75F9C1ABBEA", "faa97b2c-8771-4aea-b899-e560fd892455" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48EECD0F-9D00-401C-A96C-C75F9C1ABBEA");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2288818-91b6-4cbb-9001-fe607a4cc8a5", "AQAAAAEAACcQAAAAEJOBJ/NGDO5o2L3U3s6LWaDaI9lc8o0jdrPyXf5BxYB45pbl80Az7NoudUQnL2R85A==", "4009468b-ffba-4c5b-9094-823b6a5e90e5" });
        }
    }
}
