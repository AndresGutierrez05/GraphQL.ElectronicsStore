using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQL.ElectronicsStore.API.Services.Migrations
{
    /// <inheritdoc />
    public partial class addingQuantityToProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "ElectronicsStore",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 17, 18, 3, 57, 960, DateTimeKind.Local).AddTicks(2180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 16, 1, 34, 37, 736, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                schema: "ElectronicsStore",
                table: "OrderProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                schema: "ElectronicsStore",
                table: "OrderProducts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "ElectronicsStore",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 16, 1, 34, 37, 736, DateTimeKind.Local).AddTicks(8512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 17, 18, 3, 57, 960, DateTimeKind.Local).AddTicks(2180));
        }
    }
}
