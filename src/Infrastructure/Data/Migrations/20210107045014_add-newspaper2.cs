using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class addnewspaper2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewspaperSubCategoryUserSubcribes_NewspaperSubCategories_NewspaperSubCategoryId",
                table: "NewspaperSubCategoryUserSubcribes");

            migrationBuilder.DropIndex(
                name: "IX_NewspaperSubCategoryUserSubcribes_NewspaperSubCategoryId",
                table: "NewspaperSubCategoryUserSubcribes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewspaperSubCategories",
                table: "NewspaperSubCategories");

            migrationBuilder.DropIndex(
                name: "IX_NewspaperSubCategories_CategoryId",
                table: "NewspaperSubCategories");

            migrationBuilder.DropColumn(
                name: "NewspaperSubCategoryId",
                table: "NewspaperSubCategoryUserSubcribes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "NewspaperSubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "NewspaperSubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "NewspaperSubCategories");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "NewspaperSubCategories");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "NewspaperSubCategories");

            migrationBuilder.AddColumn<long>(
                name: "NewspaperSubCategoryCategoryId",
                table: "NewspaperSubCategoryUserSubcribes",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NewspaperSubCategoryNewspaperId",
                table: "NewspaperSubCategoryUserSubcribes",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewspaperSubCategories",
                table: "NewspaperSubCategories",
                columns: new[] { "CategoryId", "NewspaperId" });

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperSubCategoryUserSubcribes_NewspaperSubCategoryCategoryId_NewspaperSubCategoryNewspaperId",
                table: "NewspaperSubCategoryUserSubcribes",
                columns: new[] { "NewspaperSubCategoryCategoryId", "NewspaperSubCategoryNewspaperId" });

            migrationBuilder.AddForeignKey(
                name: "FK_NewspaperSubCategoryUserSubcribes_NewspaperSubCategories_NewspaperSubCategoryCategoryId_NewspaperSubCategoryNewspaperId",
                table: "NewspaperSubCategoryUserSubcribes",
                columns: new[] { "NewspaperSubCategoryCategoryId", "NewspaperSubCategoryNewspaperId" },
                principalTable: "NewspaperSubCategories",
                principalColumns: new[] { "CategoryId", "NewspaperId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewspaperSubCategoryUserSubcribes_NewspaperSubCategories_NewspaperSubCategoryCategoryId_NewspaperSubCategoryNewspaperId",
                table: "NewspaperSubCategoryUserSubcribes");

            migrationBuilder.DropIndex(
                name: "IX_NewspaperSubCategoryUserSubcribes_NewspaperSubCategoryCategoryId_NewspaperSubCategoryNewspaperId",
                table: "NewspaperSubCategoryUserSubcribes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewspaperSubCategories",
                table: "NewspaperSubCategories");

            migrationBuilder.DropColumn(
                name: "NewspaperSubCategoryCategoryId",
                table: "NewspaperSubCategoryUserSubcribes");

            migrationBuilder.DropColumn(
                name: "NewspaperSubCategoryNewspaperId",
                table: "NewspaperSubCategoryUserSubcribes");

            migrationBuilder.AddColumn<long>(
                name: "NewspaperSubCategoryId",
                table: "NewspaperSubCategoryUserSubcribes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "NewspaperSubCategories",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "NewspaperSubCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "NewspaperSubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "NewspaperSubCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "NewspaperSubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewspaperSubCategories",
                table: "NewspaperSubCategories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperSubCategoryUserSubcribes_NewspaperSubCategoryId",
                table: "NewspaperSubCategoryUserSubcribes",
                column: "NewspaperSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperSubCategories_CategoryId",
                table: "NewspaperSubCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewspaperSubCategoryUserSubcribes_NewspaperSubCategories_NewspaperSubCategoryId",
                table: "NewspaperSubCategoryUserSubcribes",
                column: "NewspaperSubCategoryId",
                principalTable: "NewspaperSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
