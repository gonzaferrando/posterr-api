using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Posterr.api.Migrations
{
    public partial class AddUserIndexes_email_username : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12ccc641-89ce-4a13-bec8-fa48c3033303"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22d23612-8102-49c9-94a8-ded4315571f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5bd3b895-940e-457d-a6ba-cb13402bd7f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("feee69c1-3fc2-4076-8875-39326e89cd5e"));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "UserName" },
                values: new object[,]
                {
                    { new Guid("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"), "ross.geller@posterr.com", "Ross", "Geller", "ross.geller" },
                    { new Guid("20443dc9-5383-4baa-853a-9ad81a81d5e6"), "monica.geller@posterr.com", "Monica", "Geller", "monica.geller" },
                    { new Guid("4d519f73-0225-449d-a6e2-2ee7782ff8a3"), "joey.tribiani@posterr.com", "Joey", "Tribiani", "joey.tribiani" },
                    { new Guid("bed94755-a97d-4423-abb6-1a6a6785f387"), "chandler.bing@posterr.com", "Chandler", "Bing", "chandler.bing" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20443dc9-5383-4baa-853a-9ad81a81d5e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d519f73-0225-449d-a6e2-2ee7782ff8a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bed94755-a97d-4423-abb6-1a6a6785f387"));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "UserName" },
                values: new object[,]
                {
                    { new Guid("12ccc641-89ce-4a13-bec8-fa48c3033303"), "chandler.bing@posterr.com", "Chandler", "Bing", "chandler.bing" },
                    { new Guid("22d23612-8102-49c9-94a8-ded4315571f2"), "ross.geller@posterr.com", "Ross", "Geller", "ross.geller" },
                    { new Guid("5bd3b895-940e-457d-a6ba-cb13402bd7f1"), "ross.geller@posterr.com", "Monica", "Geller", "monica.geller" },
                    { new Guid("feee69c1-3fc2-4076-8875-39326e89cd5e"), "joey.tribiani@posterr.com", "Joey", "Tribiani", "joey.tribiani" }
                });
        }
    }
}
