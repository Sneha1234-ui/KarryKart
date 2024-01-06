using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class NewCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_category_ParentCategory_ProductCategoryNameId",
                table: "category");

            migrationBuilder.DropColumn(
                name: "ParentCategoryId",
                table: "category");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryNameId",
                table: "category",
                newName: "ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_category_ProductCategoryNameId",
                table: "category",
                newName: "IX_category_ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_category_ParentCategory_ProductCategoryId",
                table: "category",
                column: "ProductCategoryId",
                principalTable: "ParentCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_category_ParentCategory_ProductCategoryId",
                table: "category");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                table: "category",
                newName: "ProductCategoryNameId");

            migrationBuilder.RenameIndex(
                name: "IX_category_ProductCategoryId",
                table: "category",
                newName: "IX_category_ProductCategoryNameId");

            migrationBuilder.AddColumn<int>(
                name: "ParentCategoryId",
                table: "category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_category_ParentCategory_ProductCategoryNameId",
                table: "category",
                column: "ProductCategoryNameId",
                principalTable: "ParentCategory",
                principalColumn: "Id");
        }
    }
}
