using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ChiPhiKhac",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ChiPhiQuanLyDoanhNghiep",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ChiPhiThueTNDN",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanHoacLoTrongCongTyLienKetTruoc2015",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanKhac",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanThuanTuHoatDongKinhDoanh",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ThuNhapKhac",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TongLoiNhuanKeToanTruocThue",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChiPhiKhac",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "ChiPhiQuanLyDoanhNghiep",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "ChiPhiThueTNDN",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiNhuanHoacLoTrongCongTyLienKetTruoc2015",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiNhuanKhac",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiNhuanThuanTuHoatDongKinhDoanh",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "ThuNhapKhac",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "TongLoiNhuanKeToanTruocThue",
                table: "StockReportBusiness");
        }
    }
}
