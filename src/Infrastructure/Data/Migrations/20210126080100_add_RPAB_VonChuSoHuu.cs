using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class add_RPAB_VonChuSoHuu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "TongCongNguonVon",
                table: "StockReportAccountingBalance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TongCongTaiSan",
                table: "StockReportAccountingBalance",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TongCong",
                table: "RPAB_TaiSanNganHan",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TongCong",
                table: "RPAB_TaiSanDaiHan",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    StockReportAccountingBalanceId = table.Column<long>(nullable: false),
                    TongCong = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015_StockReportAccountingBalance_StockReportAccountingBalanceId",
                        column: x => x.StockReportAccountingBalanceId,
                        principalTable: "StockReportAccountingBalance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RPAB_NoPhaiTra",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    StockReportAccountingBalanceId = table.Column<long>(nullable: false),
                    TongCong = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPAB_NoPhaiTra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RPAB_NoPhaiTra_StockReportAccountingBalance_StockReportAccountingBalanceId",
                        column: x => x.StockReportAccountingBalanceId,
                        principalTable: "StockReportAccountingBalance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RPAB_VonChuSoHuu",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    StockReportAccountingBalanceId = table.Column<long>(nullable: false),
                    TongCong = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPAB_VonChuSoHuu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RPAB_VonChuSoHuu_StockReportAccountingBalance_StockReportAccountingBalanceId",
                        column: x => x.StockReportAccountingBalanceId,
                        principalTable: "StockReportAccountingBalance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_NoDaiHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    PhaiTraDaiHanNguoiBan = table.Column<float>(nullable: false),
                    NguoiMuaTraTruocDaiHan = table.Column<float>(nullable: false),
                    ChiPhiPhaiTraDaiHan = table.Column<float>(nullable: false),
                    PhaiTraNoiBoVeVonKinhDoanh = table.Column<float>(nullable: false),
                    PhaiTraDaiHanNoiBo = table.Column<float>(nullable: false),
                    PhaiTraDaiHanKhac = table.Column<float>(nullable: false),
                    VayVaNoDaiHan = table.Column<float>(nullable: false),
                    TraiPhieuChuyenDoi = table.Column<float>(nullable: false),
                    CoPhieuUuDai = table.Column<float>(nullable: false),
                    ThueThuNhapHoanLaiPhaiTra = table.Column<float>(nullable: false),
                    DuPhongTroCapMatViecLam = table.Column<float>(nullable: false),
                    DoanhThuChuaThucHienDaiHan = table.Column<float>(nullable: false),
                    QuyPhatTrienKhoaHocVaCongNghe = table.Column<float>(nullable: false),
                    DuPhongPhaiTraDaiHan = table.Column<float>(nullable: false),
                    RPAB_NoPhaiTraId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_NoDaiHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_NoDaiHan_RPAB_NoPhaiTra_RPAB_NoPhaiTraId",
                        column: x => x.RPAB_NoPhaiTraId,
                        principalTable: "RPAB_NoPhaiTra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_NoNganHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    VayVaNoNganHan = table.Column<float>(nullable: false),
                    PhaiTraNguoiBan = table.Column<float>(nullable: false),
                    NguoiMuaTraTienTruoc = table.Column<float>(nullable: false),
                    ThueVaCacKhoanPhaiNopNhaNuoc = table.Column<float>(nullable: false),
                    PhaiTraNguoiLaoDong = table.Column<float>(nullable: false),
                    ChiPhiPhaiTra = table.Column<float>(nullable: false),
                    PhaiTraNoiBo = table.Column<float>(nullable: false),
                    PhaiTraTheoTienDoKeHoachHopDongXayDung = table.Column<float>(nullable: false),
                    CacKhoanPhaiTraPhaiNopNganHanKhac = table.Column<float>(nullable: false),
                    QuyKhenThuongPhucLoi = table.Column<float>(nullable: false),
                    DoanhThuChuaThucHienNganHan = table.Column<float>(nullable: false),
                    DuPhongPhaiTraNganHan = table.Column<float>(nullable: false),
                    QuyBinhOnGia = table.Column<float>(nullable: false),
                    GiaoDichMuaBanLaiTraiPhieuChinhPhu = table.Column<float>(nullable: false),
                    RPAB_NoPhaiTraId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_NoNganHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_NoNganHan_RPAB_NoPhaiTra_RPAB_NoPhaiTraId",
                        column: x => x.RPAB_NoPhaiTraId,
                        principalTable: "RPAB_NoPhaiTra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_NguonKinhPhiVanQuyKhac",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    RPAB_VonChuSoHuuId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_NguonKinhPhiVanQuyKhac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_NguonKinhPhiVanQuyKhac_RPAB_VonChuSoHuu_RPAB_VonChuSoHuuId",
                        column: x => x.RPAB_VonChuSoHuuId,
                        principalTable: "RPAB_VonChuSoHuu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_VonVaCacQuy",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    VonGop = table.Column<float>(nullable: false),
                    ThangDuVonCoPhan = table.Column<float>(nullable: false),
                    QuyenChonChuyenDoiTraiPhieu = table.Column<float>(nullable: false),
                    VonKhacCuaChuSoHuu = table.Column<float>(nullable: false),
                    CoPhieuQuy = table.Column<float>(nullable: false),
                    ChenhLenhDanhGiaLaiTaiSan = table.Column<float>(nullable: false),
                    ChenhLechTyGiaHoiDoai = table.Column<float>(nullable: false),
                    QuyDauTuPhatTrien = table.Column<float>(nullable: false),
                    QuyDuPhongTaiChinh = table.Column<float>(nullable: false),
                    QuyKhacThuocVonChuSoHuu = table.Column<float>(nullable: false),
                    LoiNhuanSauThueChuaPhanPhoi = table.Column<float>(nullable: false),
                    LoiIchCoDongKhongKiemSoat = table.Column<float>(nullable: false),
                    QuyHoTroSapXepDoanhNghiep = table.Column<float>(nullable: false),
                    NguonVonDauTuXDCB = table.Column<float>(nullable: false),
                    RPAB_VonChuSoHuuId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_VonVaCacQuy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_VonVaCacQuy_RPAB_VonChuSoHuu_RPAB_VonChuSoHuuId",
                        column: x => x.RPAB_VonChuSoHuuId,
                        principalTable: "RPAB_VonChuSoHuu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_NguonKinhPhiVanQuyKhac_RPAB_VonChuSoHuuId",
                table: "Criteria_NguonKinhPhiVanQuyKhac",
                column: "RPAB_VonChuSoHuuId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_NoDaiHan_RPAB_NoPhaiTraId",
                table: "Criteria_NoDaiHan",
                column: "RPAB_NoPhaiTraId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_NoNganHan_RPAB_NoPhaiTraId",
                table: "Criteria_NoNganHan",
                column: "RPAB_NoPhaiTraId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_VonVaCacQuy_RPAB_VonChuSoHuuId",
                table: "Criteria_VonVaCacQuy",
                column: "RPAB_VonChuSoHuuId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015_StockReportAccountingBalanceId",
                table: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015",
                column: "StockReportAccountingBalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_NoPhaiTra_StockReportAccountingBalanceId",
                table: "RPAB_NoPhaiTra",
                column: "StockReportAccountingBalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_VonChuSoHuu_StockReportAccountingBalanceId",
                table: "RPAB_VonChuSoHuu",
                column: "StockReportAccountingBalanceId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Criteria_NguonKinhPhiVanQuyKhac");

            migrationBuilder.DropTable(
                name: "Criteria_NoDaiHan");

            migrationBuilder.DropTable(
                name: "Criteria_NoNganHan");

            migrationBuilder.DropTable(
                name: "Criteria_VonVaCacQuy");

            migrationBuilder.DropTable(
                name: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015");

            migrationBuilder.DropTable(
                name: "RPAB_NoPhaiTra");

            migrationBuilder.DropTable(
                name: "RPAB_VonChuSoHuu");

            migrationBuilder.DropColumn(
                name: "TongCongNguonVon",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropColumn(
                name: "TongCongTaiSan",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropColumn(
                name: "TongCong",
                table: "RPAB_TaiSanNganHan");

            migrationBuilder.DropColumn(
                name: "TongCong",
                table: "RPAB_TaiSanDaiHan");
        }
    }
}
