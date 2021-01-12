using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class addstockgroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockGroup",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    AvgEPS = table.Column<float>(nullable: false),
                    AvgPE = table.Column<float>(nullable: false),
                    AvgROA = table.Column<float>(nullable: false),
                    AvgROE = table.Column<float>(nullable: false),
                    AvgPrice = table.Column<float>(nullable: false),
                    ComparePrice = table.Column<float>(nullable: false),
                    AvgPB = table.Column<float>(nullable: false),
                    AvgBeta = table.Column<float>(nullable: false),
                    TongKL = table.Column<long>(nullable: false),
                    NNSoHuu = table.Column<long>(nullable: false),
                    VonTT = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockGroup", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockGroup");
        }
    }
}
