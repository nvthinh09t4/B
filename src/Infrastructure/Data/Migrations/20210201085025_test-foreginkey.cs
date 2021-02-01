using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class testforeginkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015_StockReportAccountingBalance_StockReportAccountingBalanceId",
                table: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015");

            migrationBuilder.DropForeignKey(
                name: "FK_RPAB_NoPhaiTra_StockReportAccountingBalance_StockReportAccountingBalanceId",
                table: "RPAB_NoPhaiTra");

            migrationBuilder.DropForeignKey(
                name: "FK_RPAB_TaiSanDaiHan_StockReportAccountingBalance_StockReportAccountingBalanceId",
                table: "RPAB_TaiSanDaiHan");

            migrationBuilder.DropForeignKey(
                name: "FK_RPAB_TaiSanNganHan_StockReportAccountingBalance_StockReportAccountingBalanceId",
                table: "RPAB_TaiSanNganHan");

            migrationBuilder.DropForeignKey(
                name: "FK_RPAB_VonChuSoHuu_StockReportAccountingBalance_StockReportAccountingBalanceId",
                table: "RPAB_VonChuSoHuu");

            migrationBuilder.DropIndex(
                name: "IX_RPAB_VonChuSoHuu_StockReportAccountingBalanceId",
                table: "RPAB_VonChuSoHuu");

            migrationBuilder.DropIndex(
                name: "IX_RPAB_TaiSanNganHan_StockReportAccountingBalanceId",
                table: "RPAB_TaiSanNganHan");

            migrationBuilder.DropIndex(
                name: "IX_RPAB_TaiSanDaiHan_StockReportAccountingBalanceId",
                table: "RPAB_TaiSanDaiHan");

            migrationBuilder.DropIndex(
                name: "IX_RPAB_NoPhaiTra_StockReportAccountingBalanceId",
                table: "RPAB_NoPhaiTra");

            migrationBuilder.DropIndex(
                name: "IX_RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015_StockReportAccountingBalanceId",
                table: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015");

            migrationBuilder.DropColumn(
                name: "StockReportAccountingBalanceId",
                table: "RPAB_VonChuSoHuu");

            migrationBuilder.DropColumn(
                name: "StockReportAccountingBalanceId",
                table: "RPAB_TaiSanNganHan");

            migrationBuilder.DropColumn(
                name: "StockReportAccountingBalanceId",
                table: "RPAB_TaiSanDaiHan");

            migrationBuilder.DropColumn(
                name: "StockReportAccountingBalanceId",
                table: "RPAB_NoPhaiTra");

            migrationBuilder.DropColumn(
                name: "StockReportAccountingBalanceId",
                table: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015");

            migrationBuilder.AddColumn<long>(
                name: "CriteriaLoiIchCuaCoDongKhongKiemSoatTruoc2015Id",
                table: "StockReportAccountingBalance",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CriteriaNoPhaiTraId",
                table: "StockReportAccountingBalance",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CriteriaTaiSanDaiHanId",
                table: "StockReportAccountingBalance",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CriteriaTaiSanNganHanId",
                table: "StockReportAccountingBalance",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CriteriaVonChuSuHuuId",
                table: "StockReportAccountingBalance",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockReportAccountingBalance_CriteriaLoiIchCuaCoDongKhongKiemSoatTruoc2015Id",
                table: "StockReportAccountingBalance",
                column: "CriteriaLoiIchCuaCoDongKhongKiemSoatTruoc2015Id");

            migrationBuilder.CreateIndex(
                name: "IX_StockReportAccountingBalance_CriteriaNoPhaiTraId",
                table: "StockReportAccountingBalance",
                column: "CriteriaNoPhaiTraId");

            migrationBuilder.CreateIndex(
                name: "IX_StockReportAccountingBalance_CriteriaTaiSanDaiHanId",
                table: "StockReportAccountingBalance",
                column: "CriteriaTaiSanDaiHanId");

            migrationBuilder.CreateIndex(
                name: "IX_StockReportAccountingBalance_CriteriaTaiSanNganHanId",
                table: "StockReportAccountingBalance",
                column: "CriteriaTaiSanNganHanId");

            migrationBuilder.CreateIndex(
                name: "IX_StockReportAccountingBalance_CriteriaVonChuSuHuuId",
                table: "StockReportAccountingBalance",
                column: "CriteriaVonChuSuHuuId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockReportAccountingBalance_RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015_CriteriaLoiIchCuaCoDongKhongKiemSoatTruoc2015Id",
                table: "StockReportAccountingBalance",
                column: "CriteriaLoiIchCuaCoDongKhongKiemSoatTruoc2015Id",
                principalTable: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockReportAccountingBalance_RPAB_NoPhaiTra_CriteriaNoPhaiTraId",
                table: "StockReportAccountingBalance",
                column: "CriteriaNoPhaiTraId",
                principalTable: "RPAB_NoPhaiTra",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockReportAccountingBalance_RPAB_TaiSanDaiHan_CriteriaTaiSanDaiHanId",
                table: "StockReportAccountingBalance",
                column: "CriteriaTaiSanDaiHanId",
                principalTable: "RPAB_TaiSanDaiHan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockReportAccountingBalance_RPAB_TaiSanNganHan_CriteriaTaiSanNganHanId",
                table: "StockReportAccountingBalance",
                column: "CriteriaTaiSanNganHanId",
                principalTable: "RPAB_TaiSanNganHan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockReportAccountingBalance_RPAB_VonChuSoHuu_CriteriaVonChuSuHuuId",
                table: "StockReportAccountingBalance",
                column: "CriteriaVonChuSuHuuId",
                principalTable: "RPAB_VonChuSoHuu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockReportAccountingBalance_RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015_CriteriaLoiIchCuaCoDongKhongKiemSoatTruoc2015Id",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropForeignKey(
                name: "FK_StockReportAccountingBalance_RPAB_NoPhaiTra_CriteriaNoPhaiTraId",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropForeignKey(
                name: "FK_StockReportAccountingBalance_RPAB_TaiSanDaiHan_CriteriaTaiSanDaiHanId",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropForeignKey(
                name: "FK_StockReportAccountingBalance_RPAB_TaiSanNganHan_CriteriaTaiSanNganHanId",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropForeignKey(
                name: "FK_StockReportAccountingBalance_RPAB_VonChuSoHuu_CriteriaVonChuSuHuuId",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropIndex(
                name: "IX_StockReportAccountingBalance_CriteriaLoiIchCuaCoDongKhongKiemSoatTruoc2015Id",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropIndex(
                name: "IX_StockReportAccountingBalance_CriteriaNoPhaiTraId",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropIndex(
                name: "IX_StockReportAccountingBalance_CriteriaTaiSanDaiHanId",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropIndex(
                name: "IX_StockReportAccountingBalance_CriteriaTaiSanNganHanId",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropIndex(
                name: "IX_StockReportAccountingBalance_CriteriaVonChuSuHuuId",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropColumn(
                name: "CriteriaLoiIchCuaCoDongKhongKiemSoatTruoc2015Id",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropColumn(
                name: "CriteriaNoPhaiTraId",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropColumn(
                name: "CriteriaTaiSanDaiHanId",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropColumn(
                name: "CriteriaTaiSanNganHanId",
                table: "StockReportAccountingBalance");

            migrationBuilder.DropColumn(
                name: "CriteriaVonChuSuHuuId",
                table: "StockReportAccountingBalance");

            migrationBuilder.AddColumn<long>(
                name: "StockReportAccountingBalanceId",
                table: "RPAB_VonChuSoHuu",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StockReportAccountingBalanceId",
                table: "RPAB_TaiSanNganHan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StockReportAccountingBalanceId",
                table: "RPAB_TaiSanDaiHan",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StockReportAccountingBalanceId",
                table: "RPAB_NoPhaiTra",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StockReportAccountingBalanceId",
                table: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_VonChuSoHuu_StockReportAccountingBalanceId",
                table: "RPAB_VonChuSoHuu",
                column: "StockReportAccountingBalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_TaiSanNganHan_StockReportAccountingBalanceId",
                table: "RPAB_TaiSanNganHan",
                column: "StockReportAccountingBalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_TaiSanDaiHan_StockReportAccountingBalanceId",
                table: "RPAB_TaiSanDaiHan",
                column: "StockReportAccountingBalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_NoPhaiTra_StockReportAccountingBalanceId",
                table: "RPAB_NoPhaiTra",
                column: "StockReportAccountingBalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015_StockReportAccountingBalanceId",
                table: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015",
                column: "StockReportAccountingBalanceId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015_StockReportAccountingBalance_StockReportAccountingBalanceId",
                table: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015",
                column: "StockReportAccountingBalanceId",
                principalTable: "StockReportAccountingBalance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RPAB_NoPhaiTra_StockReportAccountingBalance_StockReportAccountingBalanceId",
                table: "RPAB_NoPhaiTra",
                column: "StockReportAccountingBalanceId",
                principalTable: "StockReportAccountingBalance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RPAB_TaiSanDaiHan_StockReportAccountingBalance_StockReportAccountingBalanceId",
                table: "RPAB_TaiSanDaiHan",
                column: "StockReportAccountingBalanceId",
                principalTable: "StockReportAccountingBalance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RPAB_TaiSanNganHan_StockReportAccountingBalance_StockReportAccountingBalanceId",
                table: "RPAB_TaiSanNganHan",
                column: "StockReportAccountingBalanceId",
                principalTable: "StockReportAccountingBalance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RPAB_VonChuSoHuu_StockReportAccountingBalance_StockReportAccountingBalanceId",
                table: "RPAB_VonChuSoHuu",
                column: "StockReportAccountingBalanceId",
                principalTable: "StockReportAccountingBalance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
