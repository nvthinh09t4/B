using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class TBL_FileStorage_ADD_Relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "FileStorage",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileStorage_UserId",
                table: "FileStorage",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileStorage_AspNetUsers_UserId",
                table: "FileStorage",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileStorage_AspNetUsers_UserId",
                table: "FileStorage");

            migrationBuilder.DropIndex(
                name: "IX_FileStorage_UserId",
                table: "FileStorage");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FileStorage");
        }
    }
}
