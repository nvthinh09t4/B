using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class ADD_TBL_Visitor2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Query",
                table: "Visitor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QueryString",
                table: "Visitor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RouteValue",
                table: "Visitor",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Query",
                table: "Visitor");

            migrationBuilder.DropColumn(
                name: "QueryString",
                table: "Visitor");

            migrationBuilder.DropColumn(
                name: "RouteValue",
                table: "Visitor");
        }
    }
}
