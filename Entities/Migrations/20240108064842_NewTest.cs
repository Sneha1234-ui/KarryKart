using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class NewTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Tax_TaxId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_TaxId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "vendors",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "unitOfProduct",
                table: "Product",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceUnit",
                table: "Product",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ProductType",
                table: "Product",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ProductTemplate",
                table: "Product",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LimitedToStores",
                table: "Product",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerRoles",
                table: "Product",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TaxId",
                table: "category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingEnabled = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    FreeShipping = table.Column<bool>(type: "bit", nullable: false),
                    Shippingseperately = table.Column<bool>(type: "bit", nullable: false),
                    AdditionalShippingCharges = table.Column<double>(type: "float", nullable: false),
                    deliveryDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_category_TaxId",
                table: "category",
                column: "TaxId");

            migrationBuilder.AddForeignKey(
                name: "FK_category_Tax_TaxId",
                table: "category",
                column: "TaxId",
                principalTable: "Tax",
                principalColumn: "TaxId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_category_Tax_TaxId",
                table: "category");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropIndex(
                name: "IX_category_TaxId",
                table: "category");

            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "category");

            migrationBuilder.AlterColumn<int>(
                name: "unitOfProduct",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<int>(
                name: "ReferenceUnit",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<int>(
                name: "ProductType",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<int>(
                name: "ProductTemplate",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<int>(
                name: "LimitedToStores",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerRoles",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddColumn<int>(
                name: "TaxId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "vendors",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_TaxId",
                table: "Product",
                column: "TaxId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Tax_TaxId",
                table: "Product",
                column: "TaxId",
                principalTable: "Tax",
                principalColumn: "TaxId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
