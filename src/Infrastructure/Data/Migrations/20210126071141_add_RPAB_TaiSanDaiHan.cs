using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class add_RPAB_TaiSanDaiHan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RPAB_TaiSanDaiHan",
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
                    table.PrimaryKey("PK_RPAB_TaiSanDaiHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RPAB_TaiSanDaiHan_StockReportAccountingBalance_StockReportAccountingBalanceId",
                        column: x => x.StockReportAccountingBalanceId,
                        principalTable: "StockReportAccountingBalance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_BatDongSanDauTu",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    NguyenGiaBatDongSanDauTu = table.Column<float>(nullable: false),
                    HaoMonBatDongSanDauTu = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_BatDongSanDauTu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_BatDongSanDauTu_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_CacKhoanDauTuTaiChinhDaiHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    DauTuVaoCongTyCon = table.Column<float>(nullable: false),
                    DauTuVaoCongTyLienKetLienDoanh = table.Column<float>(nullable: false),
                    DauTuDaiHanKhac = table.Column<float>(nullable: false),
                    DuPhongGiamGiaDauTuTaiChinhDaiHan = table.Column<float>(nullable: false),
                    DauTuDaiHanGiuDenNgayDaoHan = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_CacKhoanDauTuTaiChinhDaiHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_CacKhoanDauTuTaiChinhDaiHan_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_CacKhoanPhaiThuDaiHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    PhaiThuDaiHanCuaKhachHang = table.Column<float>(nullable: false),
                    TraTruocDaiHanNguoiBan = table.Column<float>(nullable: false),
                    VonKinhDoanhODonViTrucThuoc = table.Column<float>(nullable: false),
                    PhaiThuDaiHanNoiBo = table.Column<float>(nullable: false),
                    PhaiThuVeChoVayDaiHan = table.Column<float>(nullable: false),
                    PhaiThuDaiHanKhac = table.Column<float>(nullable: false),
                    DuPhongPhaiThuDaiHanKhoDoi = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_CacKhoanPhaiThuDaiHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_CacKhoanPhaiThuDaiHan_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_LoiTheThuongMaiTruoc2015",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_LoiTheThuongMaiTruoc2015", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_LoiTheThuongMaiTruoc2015_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_TaiSanCoDinh",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    TaiSanCoDinhHuuHinh = table.Column<float>(nullable: false),
                    TaiSanCoDinhThueTaiChinh = table.Column<float>(nullable: false),
                    TaiSanCoDinhVoHinh = table.Column<float>(nullable: false),
                    ChiPhiXayDungCoBanDoDang = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_TaiSanCoDinh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_TaiSanCoDinh_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_TaiSanDaiHanKhac",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    ChiPhiTraTruocDaiHan = table.Column<float>(nullable: false),
                    TaiSanThueThuNhapHoanLai = table.Column<float>(nullable: false),
                    ThietBiVatTuPhuTungThayTheDaiHan = table.Column<float>(nullable: false),
                    TaiSanDaiHanKhac = table.Column<float>(nullable: false),
                    LoiTheThuongMai = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_TaiSanDaiHanKhac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_TaiSanDaiHanKhac_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_TaiSanDoDangDaiHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    ChiPhiSanXuatKinhDoanhDoDangDaiHan = table.Column<float>(nullable: false),
                    ChiPhiXayDungCoBanDoDang = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_TaiSanDoDangDaiHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_TaiSanDoDangDaiHan_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_BatDongSanDauTu_RPAB_TaiSanDaiHanId",
                table: "Criteria_BatDongSanDauTu",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_CacKhoanDauTuTaiChinhDaiHan_RPAB_TaiSanDaiHanId",
                table: "Criteria_CacKhoanDauTuTaiChinhDaiHan",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_CacKhoanPhaiThuDaiHan_RPAB_TaiSanDaiHanId",
                table: "Criteria_CacKhoanPhaiThuDaiHan",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_LoiTheThuongMaiTruoc2015_RPAB_TaiSanDaiHanId",
                table: "Criteria_LoiTheThuongMaiTruoc2015",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_TaiSanCoDinh_RPAB_TaiSanDaiHanId",
                table: "Criteria_TaiSanCoDinh",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_TaiSanDaiHanKhac_RPAB_TaiSanDaiHanId",
                table: "Criteria_TaiSanDaiHanKhac",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_TaiSanDoDangDaiHan_RPAB_TaiSanDaiHanId",
                table: "Criteria_TaiSanDoDangDaiHan",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_TaiSanDaiHan_StockReportAccountingBalanceId",
                table: "RPAB_TaiSanDaiHan",
                column: "StockReportAccountingBalanceId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Criteria_BatDongSanDauTu");

            migrationBuilder.DropTable(
                name: "Criteria_CacKhoanDauTuTaiChinhDaiHan");

            migrationBuilder.DropTable(
                name: "Criteria_CacKhoanPhaiThuDaiHan");

            migrationBuilder.DropTable(
                name: "Criteria_LoiTheThuongMaiTruoc2015");

            migrationBuilder.DropTable(
                name: "Criteria_TaiSanCoDinh");

            migrationBuilder.DropTable(
                name: "Criteria_TaiSanDaiHanKhac");

            migrationBuilder.DropTable(
                name: "Criteria_TaiSanDoDangDaiHan");

            migrationBuilder.DropTable(
                name: "RPAB_TaiSanDaiHan");
        }
    }
}
