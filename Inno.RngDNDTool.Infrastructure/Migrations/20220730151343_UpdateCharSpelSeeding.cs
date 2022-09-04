using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateCharSpelSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e071247d-ca71-4567-a548-0163fd82f45b", "AQAAAAEAACcQAAAAEAns7GUHwOt6TcSI8DU+GWgp8ZgYn9HSoVQArjkWQ/luCpCu5taObgt67mdOA1UhyQ==", "b4cd5e8a-09c0-4fac-8e91-3c4a078322d7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70a98f2e-0e48-4f00-9de5-5acae453c1e4", "AQAAAAEAACcQAAAAEIBm0Px+OZd6oWb/B/3DKQnBOJg6UH1MxDNe5syrMv1EJEEufFMpQIVsW+EatXGvwg==", "49c3612a-e35e-458b-a012-612576da1486" });
        }
    }
}
