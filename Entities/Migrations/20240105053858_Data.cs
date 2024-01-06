using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_category_ParentCategory_ProductCategoryId",
                table: "category");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                table: "category",
                newName: "ParentCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_category_ProductCategoryId",
                table: "category",
                newName: "IX_category_ParentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_category_ParentCategory_ParentCategoryId",
                table: "category",
                column: "ParentCategoryId",
                principalTable: "ParentCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_category_ParentCategory_ParentCategoryId",
                table: "category");

            migrationBuilder.RenameColumn(
                name: "ParentCategoryId",
                table: "category",
                newName: "ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_category_ParentCategoryId",
                table: "category",
                newName: "IX_category_ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_category_ParentCategory_ProductCategoryId",
                table: "category",
                column: "ProductCategoryId",
                principalTable: "ParentCategory",
                principalColumn: "Id");
        }
    }
}
