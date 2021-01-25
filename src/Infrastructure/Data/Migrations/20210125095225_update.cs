using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "StockTransactionHistory",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "GiaBinhQuan",
                table: "StockTransactionHistory",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GiaCaoNhat",
                table: "StockTransactionHistory",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GiaDongCua",
                table: "StockTransactionHistory",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GiaDongCuaDieuChinh",
                table: "StockTransactionHistory",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GiaMoCua",
                table: "StockTransactionHistory",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GiaThapNhat",
                table: "StockTransactionHistory",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<long>(
                name: "KhoiLuongKhopLenh",
                table: "StockTransactionHistory",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "KhoiLuongThoaThuan",
                table: "StockTransactionHistory",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<float>(
                name: "ThayDoiDiem",
                table: "StockTransactionHistory",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ThayDoiPhanTram",
                table: "StockTransactionHistory",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<DateTime>(
                name: "TransactionDate",
                table: "StockTransactionHistory",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "StockTransactionHistory");

            migrationBuilder.DropColumn(
                name: "GiaBinhQuan",
                table: "StockTransactionHistory");

            migrationBuilder.DropColumn(
                name: "GiaCaoNhat",
                table: "StockTransactionHistory");

            migrationBuilder.DropColumn(
                name: "GiaDongCua",
                table: "StockTransactionHistory");

            migrationBuilder.DropColumn(
                name: "GiaDongCuaDieuChinh",
                table: "StockTransactionHistory");

            migrationBuilder.DropColumn(
                name: "GiaMoCua",
                table: "StockTransactionHistory");

            migrationBuilder.DropColumn(
                name: "GiaThapNhat",
                table: "StockTransactionHistory");

            migrationBuilder.DropColumn(
                name: "KhoiLuongKhopLenh",
                table: "StockTransactionHistory");

            migrationBuilder.DropColumn(
                name: "KhoiLuongThoaThuan",
                table: "StockTransactionHistory");

            migrationBuilder.DropColumn(
                name: "ThayDoiDiem",
                table: "StockTransactionHistory");

            migrationBuilder.DropColumn(
                name: "ThayDoiPhanTram",
                table: "StockTransactionHistory");

            migrationBuilder.DropColumn(
                name: "TransactionDate",
                table: "StockTransactionHistory");
        }
    }
}
