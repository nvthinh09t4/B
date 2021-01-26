using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class add_RPAB_TaiSanNganHan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "StockReportAccountingBalance",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Quarter",
                table: "StockReportAccountingBalance",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Year",
                table: "StockReportAccountingBalance",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "RPAB_TaiSanNganHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    StockReportAccountingBalanceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPAB_TaiSanNganHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RPAB_TaiSanNganHan_StockReportAccountingBalance_StockReportAccountingBalanceId",
                        column: x => x.StockReportAccountingBalanceId,
                        principalTable: "StockReportAccountingBalance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_CacKhoanDauTuTaiChinhNganHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    DauTuNganHan = table.Column<float>(nullable: false),
                    DuPhongGiamGiaDauTuNganHan = table.Column<float>(nullable: false),
                    DauTuGiuDenNgayDaoHan = table.Column<float>(nullable: false),
                    RPAB_TaiSanNganHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_CacKhoanDauTuTaiChinhNganHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_CacKhoanDauTuTaiChinhNganHan_RPAB_TaiSanNganHan_RPAB_TaiSanNganHanId",
                        column: x => x.RPAB_TaiSanNganHanId,
                        principalTable: "RPAB_TaiSanNganHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_CacKhoanPhaiThuNganHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    PhaiThuKhachHang = table.Column<float>(nullable: false),
                    TraTruocChoNguoiBan = table.Column<float>(nullable: false),
                    PhaiThuNoiBoNganHan = table.Column<float>(nullable: false),
                    PhaiThuTheoTienDoKeHoachHopDongXayDung = table.Column<float>(nullable: false),
                    PhaiThuVeChoVayNganHan = table.Column<float>(nullable: false),
                    CacKhoanPhaiThuKhac = table.Column<float>(nullable: false),
                    DuPhongPhaiThuNganHanKhoDoi = table.Column<float>(nullable: false),
                    TaiSanThieuChoXuLy = table.Column<float>(nullable: false),
                    RPAB_TaiSanNganHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_CacKhoanPhaiThuNganHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_CacKhoanPhaiThuNganHan_RPAB_TaiSanNganHan_RPAB_TaiSanNganHanId",
                        column: x => x.RPAB_TaiSanNganHanId,
                        principalTable: "RPAB_TaiSanNganHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_HangTonKho",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    HangTonKho = table.Column<float>(nullable: false),
                    DuPhongGiamGiaHangTonKho = table.Column<float>(nullable: false),
                    RPAB_TaiSanNganHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_HangTonKho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_HangTonKho_RPAB_TaiSanNganHan_RPAB_TaiSanNganHanId",
                        column: x => x.RPAB_TaiSanNganHanId,
                        principalTable: "RPAB_TaiSanNganHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_TaiSanNganHanKhac",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    ChiPhiTraTruocNganHan = table.Column<float>(nullable: false),
                    ThueGTGTDuocKhauTru = table.Column<float>(nullable: false),
                    ThueVaCacKhoanKhacPhaiThuNhaNuoc = table.Column<float>(nullable: false),
                    GiaoDichMuaBanLaiTraiPhieuChinhPhu = table.Column<float>(nullable: false),
                    TaiSanNganHanKhac = table.Column<float>(nullable: false),
                    RPAB_TaiSanNganHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_TaiSanNganHanKhac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_TaiSanNganHanKhac_RPAB_TaiSanNganHan_RPAB_TaiSanNganHanId",
                        column: x => x.RPAB_TaiSanNganHanId,
                        principalTable: "RPAB_TaiSanNganHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_TienVaCacKhoanTuongDuongTien",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    Tien = table.Column<float>(nullable: false),
                    CacKhoanTuongDuongTien = table.Column<float>(nullable: false),
                    RPAB_TaiSanNganHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_TienVaCacKhoanTuongDuongTien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_TienVaCacKhoanTuongDuongTien_RPAB_TaiSanNganHan_RPAB_TaiSanNganHanId",
                        column: x => x.RPAB_TaiSanNganHanId,
                        principalTable: "RPAB_TaiSanNganHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_CacKhoanDauTuTaiChinhNganHan_RPAB_TaiSanNganHanId",
                table: "Criteria_CacKhoanDauTuTaiChinhNganHan",
                column: "RPAB_TaiSanNganHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_CacKhoanPhaiThuNganHan_RPAB_TaiSanNganHanId",
                table: "Criteria_CacKhoanPhaiThuNganHan",
                column: "RPAB_TaiSanNganHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_HangTonKho_RPAB_TaiSanNganHanId",
                table: "Criteria_HangTonKho",
                column: "RPAB_TaiSanNganHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_TaiSanNganHanKhac_RPAB_TaiSanNganHanId",
                table: "Criteria_TaiSanNganHanKhac",
                column: "RPAB_TaiSanNganHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_TienVaCacKhoanTuongDuongTien_RPAB_TaiSanNganHanId",
                table: "Criteria_TienVaCacKhoanTuongDuongTien",
                column: "RPAB_TaiSanNganHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_TaiSanNganHan_StockReportAccountingBalanceId",
                table: "RPAB_TaiSanNganHan",
                column: "StockReportAccountingBalanceId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Criteria_CacKhoanDauTuTaiChinhNganHan");

            migrationBuilder.DropTable(
                name: "Criteria_CacKhoanPhaiThuNganHan");

            migrationBuilder.DropTable(
                name: "Criteria_HangTonKho");

            migrationBuilder.DropTable(
                name: "Criteria_TaiSanNganHanKhac");

            migrationBuilder.DropTable(
                name: "Criteria_TienVaCacKhoanTuongDuongTien");

            migrationBuilder.DropTable(
                name: "RPAB_TaiSanNganHan");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropColumn(
                name: "Quarter",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "StockReportAccountingBalance");
        }
    }
}
