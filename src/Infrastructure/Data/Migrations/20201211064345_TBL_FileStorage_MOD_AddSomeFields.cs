using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class TBL_FileStorage_MOD_AddSomeFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginalFileName",
                table: "FileStorage");

            migrationBuilder.AddColumn<string>(
                name: "OriginFileExtension",
                table: "FileStorage",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginFileName",
                table: "FileStorage",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginFullPath",
                table: "FileStorage",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StorageFileExtension",
                table: "FileStorage",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StorageFileName",
                table: "FileStorage",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StorageFullPath",
                table: "FileStorage",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginFileExtension",
                table: "FileStorage");

            migrationBuilder.DropColumn(
                name: "OriginFileName",
                table: "FileStorage");

            migrationBuilder.DropColumn(
                name: "OriginFullPath",
                table: "FileStorage");

            migrationBuilder.DropColumn(
                name: "StorageFileExtension",
                table: "FileStorage");

            migrationBuilder.DropColumn(
                name: "StorageFileName",
                table: "FileStorage");

            migrationBuilder.DropColumn(
                name: "StorageFullPath",
                table: "FileStorage");

            migrationBuilder.AddColumn<string>(
                name: "OriginalFileName",
                table: "FileStorage",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
