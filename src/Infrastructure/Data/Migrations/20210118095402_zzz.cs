using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class zzz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockGroup",
                table: "StockCompany");

            migrationBuilder.AddColumn<string>(
                name: "GroupCode",
                table: "StockCompany",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "StockCompany",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupCode",
                table: "StockCompany");

            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "StockCompany");

            migrationBuilder.AddColumn<string>(
                name: "StockGroup",
                table: "StockCompany",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
