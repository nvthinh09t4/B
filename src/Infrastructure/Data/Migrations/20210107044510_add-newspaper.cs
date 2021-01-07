using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class addnewspaper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Newspaper",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newspaper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewspaperCategoryUserSubcribes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    CategoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewspaperCategoryUserSubcribes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewspaperCategoryUserSubcribes_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewspaperCategoryUserSubcribes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NewspaperSubCategories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    NewspaperId = table.Column<long>(nullable: false),
                    CategoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewspaperSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewspaperSubCategories_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewspaperSubCategories_Newspaper_NewspaperId",
                        column: x => x.NewspaperId,
                        principalTable: "Newspaper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewspaperUserSubcribes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    NewspaperId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewspaperUserSubcribes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewspaperUserSubcribes_Newspaper_NewspaperId",
                        column: x => x.NewspaperId,
                        principalTable: "Newspaper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewspaperUserSubcribes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewspaperSubCategoryUserSubcribes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    NewspaperSubCategoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewspaperSubCategoryUserSubcribes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewspaperSubCategoryUserSubcribes_NewspaperSubCategories_NewspaperSubCategoryId",
                        column: x => x.NewspaperSubCategoryId,
                        principalTable: "NewspaperSubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewspaperSubCategoryUserSubcribes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperCategoryUserSubcribes_CategoryId",
                table: "NewspaperCategoryUserSubcribes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperCategoryUserSubcribes_UserId",
                table: "NewspaperCategoryUserSubcribes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperSubCategories_CategoryId",
                table: "NewspaperSubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperSubCategories_NewspaperId",
                table: "NewspaperSubCategories",
                column: "NewspaperId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperSubCategoryUserSubcribes_NewspaperSubCategoryId",
                table: "NewspaperSubCategoryUserSubcribes",
                column: "NewspaperSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperSubCategoryUserSubcribes_UserId",
                table: "NewspaperSubCategoryUserSubcribes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperUserSubcribes_NewspaperId",
                table: "NewspaperUserSubcribes",
                column: "NewspaperId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperUserSubcribes_UserId",
                table: "NewspaperUserSubcribes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewspaperCategoryUserSubcribes");

            migrationBuilder.DropTable(
                name: "NewspaperSubCategoryUserSubcribes");

            migrationBuilder.DropTable(
                name: "NewspaperUserSubcribes");

            migrationBuilder.DropTable(
                name: "NewspaperSubCategories");

            migrationBuilder.DropTable(
                name: "Newspaper");
        }
    }
}
