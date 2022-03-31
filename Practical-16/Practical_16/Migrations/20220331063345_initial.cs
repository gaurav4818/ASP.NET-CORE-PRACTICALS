using Microsoft.EntityFrameworkCore.Migrations;

namespace Practical_16.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a",
                column: "ConcurrencyStamp",
                value: "5a2146c0-5167-492a-b1ab-62cefcb586e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075",
                column: "ConcurrencyStamp",
                value: "e4419a99-8573-4e4d-80dd-961e92996bea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b2546a3-3e7a-424e-ac18-52d4cae97b2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "102c1cb8-f5c5-4850-af7a-7bf691c0eccc", "AQAAAAEAACcQAAAAEH10rzMF90OB7rPoBYnRjSGwR6ggst0xlkPHpIPcDyjbef9SYjtW6AgYXrTodh83cA==", "3310b4cb-ddce-4cea-9d8c-02b706fa36e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b2546a3-3e7a-454e-ac18-52d4cae97b2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e23b6838-11c9-4b71-ad94-73df05a0ccf7", "AQAAAAEAACcQAAAAEDZaE/iROrP64Qfd4hBdMHhP5ANrMcYHfOr2o4/LrxsxsTpM1pROUJYEjTroGy7GYg==", "1c51efa7-8640-44bc-bdc3-2049a9f5d687" });
        }
    }
}
