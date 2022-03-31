using Microsoft.EntityFrameworkCore.Migrations;

namespace Practical_16.Data.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a",
                column: "ConcurrencyStamp",
                value: "7c96d735-759b-4acb-bc25-99b7d9372d8a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075",
                column: "ConcurrencyStamp",
                value: "46e4e834-9f45-40a0-8280-4876a90b7d1d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b2546a3-3e7a-424e-ac18-52d4cae97b2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dbacf1f-8bc9-4b9c-bd3f-b01401c87cf6", "AQAAAAEAACcQAAAAEElMvAMcYqWoqkth5FPJNtbt3EtcSQ7t42lL4r3oizvdZSIRLzrSJS488GAi43FUGg==", "8f430f9e-f699-43a9-ba2d-f03740f7998d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b2546a3-3e7a-454e-ac18-52d4cae97b2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "513f3421-2331-48df-9545-963eb811bf0c", "AQAAAAEAACcQAAAAEHWmVmcY4mP/Tgzqhnns/BPCgSHSjfsqBkLGYi8Bx7KPt2rLilR3rtp8GWcLB7f39A==", "2021ac66-2fe8-4464-9e22-d93fd4efa207" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a",
                column: "ConcurrencyStamp",
                value: "61b80044-8316-46b4-8fe2-480df69bdd8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075",
                column: "ConcurrencyStamp",
                value: "c9d80518-3ded-4a13-8a94-e14cd3af6e6b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b2546a3-3e7a-424e-ac18-52d4cae97b2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43e6f7de-c08c-4c12-adfb-669838dec681", "AQAAAAEAACcQAAAAEBMkR9+yjGYd2QvvR+J6oFTfZGlkP62zH0aH529OWiyHtSrAKGGWj1qpSQ5D7ILA+Q==", "f33ef6e3-ed39-4f4a-837c-664165021343" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b2546a3-3e7a-454e-ac18-52d4cae97b2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a7ffa5f-7d98-404e-8d4e-535326f72900", "AQAAAAEAACcQAAAAEHwfD7+CViAH8Wtiu8feqm5faNqaaPL0nZeUb6Wd/7AnFuk4iw3D9uo/WNkDLQkwwg==", "b9cc49fa-0d6b-4ef1-8702-ad847a396cdf" });
        }
    }
}
