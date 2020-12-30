using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class ADD_SeedData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c02f37a6-b386-4a40-9bde-04ab2948e95a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "477d94cd-137b-4a9b-8722-2d0a74d0019e", 0, "18cb5342-0bf0-4b73-a320-77fbc19b602d", "nvthinh09t4@gmail.com", true, false, null, "nvthinh09t4@gmail.com", "nvthinh09t4@gmail.com", "AQAAAAEAACcQAAAAENRDuZCoBpTrKrvPwSZJbxkiPfnORdfg9O3VJcJUZZ8aZfCKxi5CqF45BxKvR8kSRg==", null, true, "4d63126c-c725-495b-bbb5-53e83f110693", false, "nvthinh09t4@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "477d94cd-137b-4a9b-8722-2d0a74d0019e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c02f37a6-b386-4a40-9bde-04ab2948e95a", 0, "ee1380b1-c827-4384-b603-1cf4d54170c7", "nvthinh09t4@gmail.com", true, false, null, null, null, "AQAAAAEAACcQAAAAEKbmsn8NJmodJ6lrOfQkWlUFlBfxSrB1N+ycMflgcH3QMN0SNPt4Dc3K6sv/I1oKqw==", null, true, "c91edefd-201d-4d5b-add9-75cb4bcf2050", false, "nvthinh09t4@gmail.com" });
        }
    }
}
