using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class ADD_SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4688614-ca06-4284-acd9-fc780c4945a6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c02f37a6-b386-4a40-9bde-04ab2948e95a", 0, "ee1380b1-c827-4384-b603-1cf4d54170c7", "nvthinh09t4@gmail.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEKbmsn8NJmodJ6lrOfQkWlUFlBfxSrB1N+ycMflgcH3QMN0SNPt4Dc3K6sv/I1oKqw==", null, true, "c91edefd-201d-4d5b-add9-75cb4bcf2050", false, "nvthinh09t4@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c02f37a6-b386-4a40-9bde-04ab2948e95a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a4688614-ca06-4284-acd9-fc780c4945a6", 0, "27fe24b8-5f7b-4bf8-8d58-6ef714b5645e", "nvthinh09t4@gmail.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEHObDGuQKx6tzmWofp4jZCleXeUf9AxSt+sqttsEp2vVo9a/l8y18DPe4+Vm+ZPh1g==", null, true, "f8336b6b-fe4a-42e0-a308-f7034f9cb8bd", false, "nvthinh09t4" });
        }
    }
}
