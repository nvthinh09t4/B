using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class addstockindex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockIndex",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    KLGDTrongPhien = table.Column<long>(nullable: false),
                    GiaTran = table.Column<float>(nullable: false),
                    GiaSan = table.Column<float>(nullable: false),
                    GiaMoCua = table.Column<float>(nullable: false),
                    GiaCaoNhat = table.Column<float>(nullable: false),
                    GiaThapNhat = table.Column<float>(nullable: false),
                    VonHoaThiTruong = table.Column<string>(nullable: true),
                    KLGDTrungBinh10Phien = table.Column<long>(nullable: false),
                    CaoNhat52Tuan = table.Column<float>(nullable: false),
                    ThapNhat52Tuan = table.Column<float>(nullable: false),
                    SoCPLuuHanh = table.Column<string>(nullable: true),
                    FreeFloat = table.Column<float>(nullable: false),
                    Beta = table.Column<float>(nullable: false),
                    PE = table.Column<string>(nullable: true),
                    PB = table.Column<string>(nullable: true),
                    ROAE = table.Column<string>(nullable: true),
                    ROAA = table.Column<string>(nullable: true),
                    TySuatCoTuc = table.Column<string>(nullable: true),
                    EPS = table.Column<long>(nullable: false),
                    BVPS = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockIndex", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockIndex");
        }
    }
}
