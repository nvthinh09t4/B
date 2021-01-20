using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class testdelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockCompanyLeadership_StockCompany_CompanyId",
                table: "StockCompanyLeadership");

            migrationBuilder.DropForeignKey(
                name: "FK_StockForeignerHolderRate_StockCompany_CompanyId",
                table: "StockForeignerHolderRate");

            migrationBuilder.DropForeignKey(
                name: "FK_StockShareholder_StockCompany_CompanyId",
                table: "StockShareholder");

            migrationBuilder.AddForeignKey(
                name: "FK_StockCompanyLeadership_StockCompany_CompanyId",
                table: "StockCompanyLeadership",
                column: "CompanyId",
                principalTable: "StockCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockForeignerHolderRate_StockCompany_CompanyId",
                table: "StockForeignerHolderRate",
                column: "CompanyId",
                principalTable: "StockCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockShareholder_StockCompany_CompanyId",
                table: "StockShareholder",
                column: "CompanyId",
                principalTable: "StockCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockCompanyLeadership_StockCompany_CompanyId",
                table: "StockCompanyLeadership");

            migrationBuilder.DropForeignKey(
                name: "FK_StockForeignerHolderRate_StockCompany_CompanyId",
                table: "StockForeignerHolderRate");

            migrationBuilder.DropForeignKey(
                name: "FK_StockShareholder_StockCompany_CompanyId",
                table: "StockShareholder");

            migrationBuilder.AddForeignKey(
                name: "FK_StockCompanyLeadership_StockCompany_CompanyId",
                table: "StockCompanyLeadership",
                column: "CompanyId",
                principalTable: "StockCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockForeignerHolderRate_StockCompany_CompanyId",
                table: "StockForeignerHolderRate",
                column: "CompanyId",
                principalTable: "StockCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockShareholder_StockCompany_CompanyId",
                table: "StockShareholder",
                column: "CompanyId",
                principalTable: "StockCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
