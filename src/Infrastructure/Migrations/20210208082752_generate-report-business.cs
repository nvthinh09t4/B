using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class generatereportbusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CacKhoanGiamTruDoanhThu",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ChiPhiBanHang",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

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
                name: "ChiPhiTaiChinh",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ChiPhiTaiChinh_ChiPhiLaiVay",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ChiPhiThueTNDN",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

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

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "StockReportBusiness",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "DoanhThuHoatDongTaiChinh",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DoanhThuThuan",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GiaVonHangBan",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiIchCoDongThieuSo",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanGop",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanHoacLoTrongCongTyLienKet",
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
                name: "LoiNhuanSauThueCuaCongTyMe",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanSauThueTNDN",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LoiNhuanThuanTuHoatDongKinhDoanh",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Quarter",
                table: "StockReportBusiness",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ThuNhapKhac",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TongDoanhThuHoatDongKinhDoanh",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TongLoiNhuanKeToanTruocThue",
                table: "StockReportBusiness",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "StockReportBusiness",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CacKhoanGiamTruDoanhThu",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "ChiPhiBanHang",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "ChiPhiKhac",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "ChiPhiQuanLyDoanhNghiep",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "ChiPhiTaiChinh",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "ChiPhiTaiChinh_ChiPhiLaiVay",
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
                name: "Code",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "DoanhThuHoatDongTaiChinh",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "DoanhThuThuan",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "GiaVonHangBan",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiIchCoDongThieuSo",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiNhuanGop",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "LoiNhuanHoacLoTrongCongTyLienKet",
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
                name: "Quarter",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "ThuNhapKhac",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "TongDoanhThuHoatDongKinhDoanh",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "TongLoiNhuanKeToanTruocThue",
                table: "StockReportBusiness");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "StockReportBusiness");
        }
    }
}
