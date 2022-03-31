using Microsoft.EntityFrameworkCore.Migrations;

namespace Practical_16.Data.Migrations
{
    public partial class role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "094afa8c-69e3-4103-a542-8aee12940f9a", "5a2146c0-5167-492a-b1ab-62cefcb586e6", "User", "USER" },
                    { "9f074bba-372c-474e-81a2-92e877a73075", "e4419a99-8573-4e4d-80dd-961e92996bea", "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5b2546a3-3e7a-454e-ac18-52d4cae97b2f", 0, "e23b6838-11c9-4b71-ad94-73df05a0ccf7", "User@gmail.com", true, "User", "user", false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEDZaE/iROrP64Qfd4hBdMHhP5ANrMcYHfOr2o4/LrxsxsTpM1pROUJYEjTroGy7GYg==", null, false, "1c51efa7-8640-44bc-bdc3-2049a9f5d687", false, "User@gmail.com" },
                    { "4b2546a3-3e7a-424e-ac18-52d4cae97b2f", 0, "102c1cb8-f5c5-4850-af7a-7bf691c0eccc", "student@gmail.com", true, "Student", "student", false, null, "student@GMAIL.COM", "STUDENT@GMAIL.COM", "AQAAAAEAACcQAAAAEH10rzMF90OB7rPoBYnRjSGwR6ggst0xlkPHpIPcDyjbef9SYjtW6AgYXrTodh83cA==", null, false, "3310b4cb-ddce-4cea-9d8c-02b706fa36e9", false, "student@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "094afa8c-69e3-4103-a542-8aee12940f9a", "5b2546a3-3e7a-454e-ac18-52d4cae97b2f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9f074bba-372c-474e-81a2-92e877a73075", "4b2546a3-3e7a-424e-ac18-52d4cae97b2f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9f074bba-372c-474e-81a2-92e877a73075", "4b2546a3-3e7a-424e-ac18-52d4cae97b2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "094afa8c-69e3-4103-a542-8aee12940f9a", "5b2546a3-3e7a-454e-ac18-52d4cae97b2f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "094afa8c-69e3-4103-a542-8aee12940f9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f074bba-372c-474e-81a2-92e877a73075");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b2546a3-3e7a-424e-ac18-52d4cae97b2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b2546a3-3e7a-454e-ac18-52d4cae97b2f");
        }
    }
}
