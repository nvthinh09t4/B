﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class modify_seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "537a8a68-56c4-4d17-b5e3-c5fdba649f87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afe5ac22-0d03-421c-870c-fb9860cc03fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d094632-b9f8-417d-9c5e-47632497e93d");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "537a8a68-56c4-4d17-b5e3-c5fdba649f87", "2601fb28-e386-4cab-909e-b0f20cea31ff", "Administrator", "administrator" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "afe5ac22-0d03-421c-870c-fb9860cc03fe", "d084f782-1875-4acb-8504-f9e62ab147b6", "NormalUser", "normaluser" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2d094632-b9f8-417d-9c5e-47632497e93d", 0, "a4a601af-1744-4f49-b1e9-83d2f97b6251", "nvthinh09t4@gmail.com", true, false, null, "nvthinh09t4@gmail.com", "nvthinh09t4@gmail.com", "AQAAAAEAACcQAAAAEKQi/cMO+6wj9n7a+6CCRCbyRhHzd1SNaviXHjW2cm9QFeo/bntDrbDGnRnmUn5fiw==", null, true, "e45b5aa0-4ab4-437c-b33e-9e014ec75bbd", false, "nvthinh09t4@gmail.com" });
        }
    }
}
