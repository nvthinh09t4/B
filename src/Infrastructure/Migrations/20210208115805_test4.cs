using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ChiPhiThueTNDN_HienHanh",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ChiPhiThueTNDN_HoanLai",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiIchCoDongThieuSo",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanSauThueCuaCongTyMe",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanSauThueTNDN",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChiPhiThueTNDN_HienHanh",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "ChiPhiThueTNDN_HoanLai",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiIchCoDongThieuSo",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiNhuanSauThueCuaCongTyMe",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiNhuanSauThueTNDN",
                table: "StockReportBusiness");
        }
    }
}
