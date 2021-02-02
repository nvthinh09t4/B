using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class _32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "RPAB_VonChuSoHuu",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "RPAB_TaiSanNganHan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "RPAB_TaiSanDaiHan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "RPAB_NoPhaiTra",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "RPAB_VonChuSoHuu");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "RPAB_TaiSanNganHan");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "RPAB_TaiSanDaiHan");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "RPAB_NoPhaiTra");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015");
        }
    }
}
