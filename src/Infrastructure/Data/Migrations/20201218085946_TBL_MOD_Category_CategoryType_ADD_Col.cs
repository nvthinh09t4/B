using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class TBL_MOD_Category_CategoryType_ADD_Col : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "CategoryType",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Display",
                table: "Category",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Category",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "CategoryType");

            migrationBuilder.DropColumn(
                name: "Display",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Category");
        }
    }
}
