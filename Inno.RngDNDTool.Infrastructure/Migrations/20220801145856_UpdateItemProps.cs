using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inno.RngDNDTool.Infrastructure.Migrations
{
    public partial class UpdateItemProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "WeightInKg",
                table: "Weapons",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Range",
                table: "Weapons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "WeightInKg",
                table: "Scrolls",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "WeightInKg",
                table: "Potions",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "WeightInKg",
                table: "Foods",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "WeightInKg",
                table: "Armors",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d788d99-191e-493a-a980-99e9dd5c4b52", "AQAAAAEAACcQAAAAEFh20fzJOilppVQm4ukC0CGWRdODDKQax3dTRD9Wme4SDYPnzcCXlq31bENyx6768w==", "107dd7f0-f4b3-44ea-a1fe-3bca4583f398" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Range",
                table: "Weapons");

            migrationBuilder.AlterColumn<int>(
                name: "WeightInKg",
                table: "Weapons",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "WeightInKg",
                table: "Scrolls",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "WeightInKg",
                table: "Potions",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "WeightInKg",
                table: "Foods",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "WeightInKg",
                table: "Armors",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faa97b2c-8771-4aea-b899-e560fd892455",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee71f39f-99d4-4396-9659-81a4e43ca562", "AQAAAAEAACcQAAAAEEWUVFV4aJDNUWMnRH1AlQoEahbB0+j00rGxTT3SBp4rBSXVbNq/nKOZzA7Zej/USg==", "4c35343a-4033-4e05-aa34-0b0fe50eef1d" });
        }
    }
}
