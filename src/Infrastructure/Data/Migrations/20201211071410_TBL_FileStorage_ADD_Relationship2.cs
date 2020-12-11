using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class TBL_FileStorage_ADD_Relationship2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileStorage_AspNetUsers_ApplicationUserId",
                table: "FileStorage");

            migrationBuilder.DropIndex(
                name: "IX_FileStorage_ApplicationUserId",
                table: "FileStorage");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "FileStorage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "FileStorage",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileStorage_ApplicationUserId",
                table: "FileStorage",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileStorage_AspNetUsers_ApplicationUserId",
                table: "FileStorage",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
