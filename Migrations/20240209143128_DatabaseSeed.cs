using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Posterr.api.Migrations
{
    public partial class DatabaseSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
