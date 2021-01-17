using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class addstockcompanyinformation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stock_StockCompany_CompanyId",
                table: "Stock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stock",
                table: "Stock");

            migrationBuilder.RenameTable(
                name: "Stock",
                newName: "StockCompanyLeadership");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_CompanyId",
                table: "StockCompanyLeadership",
                newName: "IX_StockCompanyLeadership_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockCompanyLeadership",
                table: "StockCompanyLeadership",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockCompanyLeadership_StockCompany_CompanyId",
                table: "StockCompanyLeadership",
                column: "CompanyId",
                principalTable: "StockCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockCompanyLeadership_StockCompany_CompanyId",
                table: "StockCompanyLeadership");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockCompanyLeadership",
                table: "StockCompanyLeadership");

            migrationBuilder.RenameTable(
                name: "StockCompanyLeadership",
                newName: "Stock");

            migrationBuilder.RenameIndex(
                name: "IX_StockCompanyLeadership_CompanyId",
                table: "Stock",
                newName: "IX_Stock_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stock",
                table: "Stock",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_StockCompany_CompanyId",
                table: "Stock",
                column: "CompanyId",
                principalTable: "StockCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
