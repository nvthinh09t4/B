using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "ChiPhiThueTNDN_HienHanh",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "ChiPhiThueTNDN_HoanLai",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiIchCoDongThieuSo",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiNhuanHoacLoTrongCongTyLienKetTruoc2015",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiNhuanKhac",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiNhuanSauThueCuaCongTyMe",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiNhuanSauThueTNDN",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ChiPhiKhac",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ChiPhiQuanLyDoanhNghiep",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ChiPhiThueTNDN",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ChiPhiThueTNDN_HienHanh",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ChiPhiThueTNDN_HoanLai",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiIchCoDongThieuSo",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanHoacLoTrongCongTyLienKetTruoc2015",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanKhac",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanSauThueCuaCongTyMe",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanSauThueTNDN",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanThuanTuHoatDongKinhDoanh",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ThuNhapKhac",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TongLoiNhuanKeToanTruocThue",
                table: "StockReportBusiness",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
