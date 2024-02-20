using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Posterr.api.Migrations
{
    public partial class AddData_Posts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "Content", "CreatedAt" },
                values: new object[,]
                {
                    { new Guid("036e16ed-dfbe-4423-87db-cd9e5f0569e0"), new Guid("4d519f73-0225-449d-a6e2-2ee7782ff8a3"), "This is the content of post 31", new DateTime(2023, 12, 20, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("136e2fe7-d6d1-4867-9ee7-9200b480fd66"), new Guid("4d519f73-0225-449d-a6e2-2ee7782ff8a3"), "This is the content of post 35", new DateTime(2023, 12, 24, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("18db3103-af83-4575-9384-148b739e54e7"), new Guid("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"), "This is the content of post 33", new DateTime(2023, 12, 22, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1a9b942f-4340-42e6-a019-ecfed2efd5ef"), new Guid("bed94755-a97d-4423-abb6-1a6a6785f387"), "This is the content of post 12", new DateTime(2023, 12, 1, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("246f31d1-6379-416e-a725-f85de2b91e8e"), new Guid("bed94755-a97d-4423-abb6-1a6a6785f387"), "This is the content of post 24", new DateTime(2023, 12, 13, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("267f8255-d03e-4f9f-8737-10e7e9202f84"), new Guid("bed94755-a97d-4423-abb6-1a6a6785f387"), "This is the content of post 8", new DateTime(2023, 8, 1, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("279071fb-ab24-4af6-933c-e0f7b703c0db"), new Guid("20443dc9-5383-4baa-853a-9ad81a81d5e6"), "This is the content of post 26", new DateTime(2023, 12, 15, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27ec4e7b-8545-43e7-82d1-58f77cc21784"), new Guid("bed94755-a97d-4423-abb6-1a6a6785f387"), "This is the content of post 4", new DateTime(2023, 4, 1, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("352b0d4f-6a40-4bab-b935-923d957507d5"), new Guid("4d519f73-0225-449d-a6e2-2ee7782ff8a3"), "This is the content of post 7", new DateTime(2023, 7, 1, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("36d09a34-f0e4-498e-89ae-de52647c09cc"), new Guid("bed94755-a97d-4423-abb6-1a6a6785f387"), "This is the content of post 20", new DateTime(2023, 12, 9, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c00df53-6b0a-4def-8110-4cc8fa0c0adf"), new Guid("4d519f73-0225-449d-a6e2-2ee7782ff8a3"), "This is the content of post 19", new DateTime(2023, 12, 8, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6dc0ec28-9642-4e1e-8ce0-c357101e7483"), new Guid("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"), "This is the content of post 13", new DateTime(2023, 12, 2, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("705b2d11-68c1-4e0e-bbfa-f46e838d46c7"), new Guid("20443dc9-5383-4baa-853a-9ad81a81d5e6"), "This is the content of post 14", new DateTime(2023, 12, 3, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7315b7f5-6e9d-4800-9c22-c6913a900783"), new Guid("20443dc9-5383-4baa-853a-9ad81a81d5e6"), "This is the content of post 30", new DateTime(2023, 12, 19, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bdc2aaa-3194-42bb-b1ee-6336bfb21567"), new Guid("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"), "This is the content of post 1", new DateTime(2023, 1, 1, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("800c3a4f-696c-48b2-a807-fe4887b85f80"), new Guid("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"), "This is the content of post 29", new DateTime(2023, 12, 18, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("87ed131d-9fe4-4fab-92bc-19c8a4ceea8d"), new Guid("4d519f73-0225-449d-a6e2-2ee7782ff8a3"), "This is the content of post 11", new DateTime(2023, 11, 1, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8dc323f5-7b82-43c4-928d-cf4558549c6d"), new Guid("20443dc9-5383-4baa-853a-9ad81a81d5e6"), "This is the content of post 18", new DateTime(2023, 12, 7, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9358da1b-326a-42d6-b4eb-0238e599ae3e"), new Guid("20443dc9-5383-4baa-853a-9ad81a81d5e6"), "This is the content of post 2", new DateTime(2023, 2, 1, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("98b8a9a7-056c-4b8d-bbb9-29ca7b5e7264"), new Guid("20443dc9-5383-4baa-853a-9ad81a81d5e6"), "This is the content of post 10", new DateTime(2023, 10, 1, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9d64f209-e3eb-4286-9477-bd094f8cc55c"), new Guid("bed94755-a97d-4423-abb6-1a6a6785f387"), "This is the content of post 28", new DateTime(2023, 12, 17, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6dfef05-f786-4583-8c87-c92709011d14"), new Guid("20443dc9-5383-4baa-853a-9ad81a81d5e6"), "This is the content of post 6", new DateTime(2023, 6, 1, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad76ee94-1e7d-4e12-9834-fe7c1fde4b4c"), new Guid("bed94755-a97d-4423-abb6-1a6a6785f387"), "This is the content of post 32", new DateTime(2023, 12, 21, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b0d7d203-b9a2-4b94-910b-1bfcebd38368"), new Guid("bed94755-a97d-4423-abb6-1a6a6785f387"), "This is the content of post 16", new DateTime(2023, 12, 5, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b938296b-6efa-4b1c-8f08-a893620f6953"), new Guid("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"), "This is the content of post 21", new DateTime(2023, 12, 10, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf093646-d91e-486d-8c50-6c2d46f9f9e2"), new Guid("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"), "This is the content of post 9", new DateTime(2023, 9, 1, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3a33893-37c5-4f58-9f2d-c181ad85087b"), new Guid("bed94755-a97d-4423-abb6-1a6a6785f387"), "This is the content of post 36", new DateTime(2023, 12, 25, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d0c04c9e-ca41-46c7-af86-39ed994c160d"), new Guid("4d519f73-0225-449d-a6e2-2ee7782ff8a3"), "This is the content of post 23", new DateTime(2023, 12, 12, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d51f83b2-d19c-4f9f-987a-ded3c600f971"), new Guid("4d519f73-0225-449d-a6e2-2ee7782ff8a3"), "This is the content of post 27", new DateTime(2023, 12, 16, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d936eb2c-d4f6-4725-a49b-f50fd1c4a719"), new Guid("20443dc9-5383-4baa-853a-9ad81a81d5e6"), "This is the content of post 22", new DateTime(2023, 12, 11, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd4e3040-c62b-4bd5-8fd6-31c967fc1ee8"), new Guid("20443dc9-5383-4baa-853a-9ad81a81d5e6"), "This is the content of post 34", new DateTime(2023, 12, 23, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef40579a-5609-4b92-bba3-c4ec6d8bbfc2"), new Guid("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"), "This is the content of post 17", new DateTime(2023, 12, 6, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2974844-3c80-487a-9cbf-31f6e6a36c68"), new Guid("4d519f73-0225-449d-a6e2-2ee7782ff8a3"), "This is the content of post 15", new DateTime(2023, 12, 4, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f362d36c-d949-40ba-97a2-4e91abd85c71"), new Guid("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"), "This is the content of post 25", new DateTime(2023, 12, 14, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f6305746-75cb-47ba-89b8-f2bc41a31f3e"), new Guid("4d519f73-0225-449d-a6e2-2ee7782ff8a3"), "This is the content of post 3", new DateTime(2023, 3, 1, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f80c0f27-0ded-4cfc-805a-0f01874a30b2"), new Guid("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"), "This is the content of post 5", new DateTime(2023, 5, 1, 11, 11, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fbe533bb-5cb3-499f-aafa-c2f4f8224798"), new Guid("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"), "This is the content of post 37", new DateTime(2023, 12, 26, 11, 11, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("036e16ed-dfbe-4423-87db-cd9e5f0569e0"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("136e2fe7-d6d1-4867-9ee7-9200b480fd66"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("18db3103-af83-4575-9384-148b739e54e7"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("1a9b942f-4340-42e6-a019-ecfed2efd5ef"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("246f31d1-6379-416e-a725-f85de2b91e8e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("267f8255-d03e-4f9f-8737-10e7e9202f84"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("279071fb-ab24-4af6-933c-e0f7b703c0db"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("27ec4e7b-8545-43e7-82d1-58f77cc21784"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("352b0d4f-6a40-4bab-b935-923d957507d5"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("36d09a34-f0e4-498e-89ae-de52647c09cc"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("3c00df53-6b0a-4def-8110-4cc8fa0c0adf"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("6dc0ec28-9642-4e1e-8ce0-c357101e7483"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("705b2d11-68c1-4e0e-bbfa-f46e838d46c7"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("7315b7f5-6e9d-4800-9c22-c6913a900783"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("7bdc2aaa-3194-42bb-b1ee-6336bfb21567"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("800c3a4f-696c-48b2-a807-fe4887b85f80"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("87ed131d-9fe4-4fab-92bc-19c8a4ceea8d"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("8dc323f5-7b82-43c4-928d-cf4558549c6d"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9358da1b-326a-42d6-b4eb-0238e599ae3e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("98b8a9a7-056c-4b8d-bbb9-29ca7b5e7264"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9d64f209-e3eb-4286-9477-bd094f8cc55c"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("a6dfef05-f786-4583-8c87-c92709011d14"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("ad76ee94-1e7d-4e12-9834-fe7c1fde4b4c"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b0d7d203-b9a2-4b94-910b-1bfcebd38368"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b938296b-6efa-4b1c-8f08-a893620f6953"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("bf093646-d91e-486d-8c50-6c2d46f9f9e2"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("c3a33893-37c5-4f58-9f2d-c181ad85087b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d0c04c9e-ca41-46c7-af86-39ed994c160d"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d51f83b2-d19c-4f9f-987a-ded3c600f971"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d936eb2c-d4f6-4725-a49b-f50fd1c4a719"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("dd4e3040-c62b-4bd5-8fd6-31c967fc1ee8"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("ef40579a-5609-4b92-bba3-c4ec6d8bbfc2"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f2974844-3c80-487a-9cbf-31f6e6a36c68"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f362d36c-d949-40ba-97a2-4e91abd85c71"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f6305746-75cb-47ba-89b8-f2bc41a31f3e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f80c0f27-0ded-4cfc-805a-0f01874a30b2"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("fbe533bb-5cb3-499f-aafa-c2f4f8224798"));
        }
    }
}
