using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class MOD_TBL_FileCategory_Relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileCategory_FileStorage_CategoryId",
                table: "FileCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_FileCategory_Category_FileStorageId",
                table: "FileCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_FileCategory_Category_CategoryId",
                table: "FileCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FileCategory_FileStorage_FileStorageId",
                table: "FileCategory",
                column: "FileStorageId",
                principalTable: "FileStorage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileCategory_Category_CategoryId",
                table: "FileCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_FileCategory_FileStorage_FileStorageId",
                table: "FileCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_FileCategory_FileStorage_CategoryId",
                table: "FileCategory",
                column: "CategoryId",
                principalTable: "FileStorage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FileCategory_Category_FileStorageId",
                table: "FileCategory",
                column: "FileStorageId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
