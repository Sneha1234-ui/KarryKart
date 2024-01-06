using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class Newww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_category_ParentCategory_ParentCategoryId",
                table: "category");

            migrationBuilder.AlterColumn<int>(
                name: "ParentCategoryId",
                table: "category",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_category_ParentCategory_ParentCategoryId",
                table: "category",
                column: "ParentCategoryId",
                principalTable: "ParentCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_category_ParentCategory_ParentCategoryId",
                table: "category");

            migrationBuilder.AlterColumn<int>(
                name: "ParentCategoryId",
                table: "category",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_category_ParentCategory_ParentCategoryId",
                table: "category",
                column: "ParentCategoryId",
                principalTable: "ParentCategory",
                principalColumn: "Id");
        }
    }
}
