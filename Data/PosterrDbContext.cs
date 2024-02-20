using Microsoft.EntityFrameworkCore;
using Posterr.api.Data.Models;

namespace Posterr.api.Data
{
    public class PosterrDbContext : DbContext, IPosterrDbContext
    {
        public PosterrDbContext(DbContextOptions<PosterrDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Repost> Reposts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(PosterrDbContext).Assembly);

            var userId1 = Guid.Parse("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d");
            var userId2 = Guid.Parse("20443dc9-5383-4baa-853a-9ad81a81d5e6");
            var userId3 = Guid.Parse("4d519f73-0225-449d-a6e2-2ee7782ff8a3");
            var userId4 = Guid.Parse("bed94755-a97d-4423-abb6-1a6a6785f387");

            modelBuilder.Entity<User>().HasData(
                new() { Id = userId1, UserName = "ross.geller", FirstName = "Ross", LastName = "Geller", Email = "ross.geller@posterr.com" },
                new() { Id = userId2, UserName = "monica.geller", FirstName = "Monica", LastName = "Geller", Email = "monica.geller@posterr.com" },
                new() { Id = userId3, UserName = "joey.tribiani", FirstName = "Joey", LastName = "Tribiani", Email = "joey.tribiani@posterr.com" },
                new() { Id = userId4, UserName = "chandler.bing", FirstName = "Chandler", LastName = "Bing", Email = "chandler.bing@posterr.com" }
            );

            modelBuilder.Entity<Post>().HasData(
                new Post { Id = Guid.Parse("7bdc2aaa-3194-42bb-b1ee-6336bfb21567"), Content = "This is the content of post 1", CreatedAt = new DateTime(2023, 1, 1, 11, 11, 0), AuthorId = userId1 },
                new Post { Id = Guid.Parse("9358da1b-326a-42d6-b4eb-0238e599ae3e"), Content = "This is the content of post 2", CreatedAt = new DateTime(2023, 2, 1, 11, 11, 0), AuthorId = userId2 },
                new Post { Id = Guid.Parse("f6305746-75cb-47ba-89b8-f2bc41a31f3e"), Content = "This is the content of post 3", CreatedAt = new DateTime(2023, 3, 1, 11, 11, 0), AuthorId = userId3 },
                new Post { Id = Guid.Parse("27ec4e7b-8545-43e7-82d1-58f77cc21784"), Content = "This is the content of post 4", CreatedAt = new DateTime(2023, 4, 1, 11, 11, 0), AuthorId = userId4 },
                new Post { Id = Guid.Parse("f80c0f27-0ded-4cfc-805a-0f01874a30b2"), Content = "This is the content of post 5", CreatedAt = new DateTime(2023, 5, 1, 11, 11, 0), AuthorId = userId1 },
                new Post { Id = Guid.Parse("a6dfef05-f786-4583-8c87-c92709011d14"), Content = "This is the content of post 6", CreatedAt = new DateTime(2023, 6, 1, 11, 11, 0), AuthorId = userId2 },
                new Post { Id = Guid.Parse("352b0d4f-6a40-4bab-b935-923d957507d5"), Content = "This is the content of post 7", CreatedAt = new DateTime(2023, 7, 1, 11, 11, 0), AuthorId = userId3 },
                new Post { Id = Guid.Parse("267f8255-d03e-4f9f-8737-10e7e9202f84"), Content = "This is the content of post 8", CreatedAt = new DateTime(2023, 8, 1, 11, 11, 0), AuthorId = userId4 },
                new Post { Id = Guid.Parse("bf093646-d91e-486d-8c50-6c2d46f9f9e2"), Content = "This is the content of post 9", CreatedAt = new DateTime(2023, 9, 1, 11, 11, 0), AuthorId = userId1 },
                new Post { Id = Guid.Parse("98b8a9a7-056c-4b8d-bbb9-29ca7b5e7264"), Content = "This is the content of post 10", CreatedAt = new DateTime(2023, 10, 1, 11, 11, 0), AuthorId = userId2 },
                new Post { Id = Guid.Parse("87ed131d-9fe4-4fab-92bc-19c8a4ceea8d"), Content = "This is the content of post 11", CreatedAt = new DateTime(2023, 11, 1, 11, 11, 0), AuthorId = userId3 },
                new Post { Id = Guid.Parse("1a9b942f-4340-42e6-a019-ecfed2efd5ef"), Content = "This is the content of post 12", CreatedAt = new DateTime(2023, 12, 1, 11, 11, 0), AuthorId = userId4 },
                new Post { Id = Guid.Parse("6dc0ec28-9642-4e1e-8ce0-c357101e7483"), Content = "This is the content of post 13", CreatedAt = new DateTime(2023, 12, 2, 11, 11, 0), AuthorId = userId1 },
                new Post { Id = Guid.Parse("705b2d11-68c1-4e0e-bbfa-f46e838d46c7"), Content = "This is the content of post 14", CreatedAt = new DateTime(2023, 12, 3, 11, 11, 0), AuthorId = userId2 },
                new Post { Id = Guid.Parse("f2974844-3c80-487a-9cbf-31f6e6a36c68"), Content = "This is the content of post 15", CreatedAt = new DateTime(2023, 12, 4, 11, 11, 0), AuthorId = userId3 },
                new Post { Id = Guid.Parse("b0d7d203-b9a2-4b94-910b-1bfcebd38368"), Content = "This is the content of post 16", CreatedAt = new DateTime(2023, 12, 5, 11, 11, 0), AuthorId = userId4 },
                new Post { Id = Guid.Parse("ef40579a-5609-4b92-bba3-c4ec6d8bbfc2"), Content = "This is the content of post 17", CreatedAt = new DateTime(2023, 12, 6, 11, 11, 0), AuthorId = userId1 },
                new Post { Id = Guid.Parse("8dc323f5-7b82-43c4-928d-cf4558549c6d"), Content = "This is the content of post 18", CreatedAt = new DateTime(2023, 12, 7, 11, 11, 0), AuthorId = userId2 },
                new Post { Id = Guid.Parse("3c00df53-6b0a-4def-8110-4cc8fa0c0adf"), Content = "This is the content of post 19", CreatedAt = new DateTime(2023, 12, 8, 11, 11, 0), AuthorId = userId3 },
                new Post { Id = Guid.Parse("36d09a34-f0e4-498e-89ae-de52647c09cc"), Content = "This is the content of post 20", CreatedAt = new DateTime(2023, 12, 9, 11, 11, 0), AuthorId = userId4 },
                new Post { Id = Guid.Parse("b938296b-6efa-4b1c-8f08-a893620f6953"), Content = "This is the content of post 21", CreatedAt = new DateTime(2023, 12, 10, 11, 11, 0), AuthorId = userId1 },
                new Post { Id = Guid.Parse("d936eb2c-d4f6-4725-a49b-f50fd1c4a719"), Content = "This is the content of post 22", CreatedAt = new DateTime(2023, 12, 11, 11, 11, 0), AuthorId = userId2 },
                new Post { Id = Guid.Parse("d0c04c9e-ca41-46c7-af86-39ed994c160d"), Content = "This is the content of post 23", CreatedAt = new DateTime(2023, 12, 12, 11, 11, 0), AuthorId = userId3 },
                new Post { Id = Guid.Parse("246f31d1-6379-416e-a725-f85de2b91e8e"), Content = "This is the content of post 24", CreatedAt = new DateTime(2023, 12, 13, 11, 11, 0), AuthorId = userId4 },
                new Post { Id = Guid.Parse("f362d36c-d949-40ba-97a2-4e91abd85c71"), Content = "This is the content of post 25", CreatedAt = new DateTime(2023, 12, 14, 11, 11, 0), AuthorId = userId1 },
                new Post { Id = Guid.Parse("279071fb-ab24-4af6-933c-e0f7b703c0db"), Content = "This is the content of post 26", CreatedAt = new DateTime(2023, 12, 15, 11, 11, 0), AuthorId = userId2 },
                new Post { Id = Guid.Parse("d51f83b2-d19c-4f9f-987a-ded3c600f971"), Content = "This is the content of post 27", CreatedAt = new DateTime(2023, 12, 16, 11, 11, 0), AuthorId = userId3 },
                new Post { Id = Guid.Parse("9d64f209-e3eb-4286-9477-bd094f8cc55c"), Content = "This is the content of post 28", CreatedAt = new DateTime(2023, 12, 17, 11, 11, 0), AuthorId = userId4 },
                new Post { Id = Guid.Parse("800c3a4f-696c-48b2-a807-fe4887b85f80"), Content = "This is the content of post 29", CreatedAt = new DateTime(2023, 12, 18, 11, 11, 0), AuthorId = userId1 },
                new Post { Id = Guid.Parse("7315b7f5-6e9d-4800-9c22-c6913a900783"), Content = "This is the content of post 30", CreatedAt = new DateTime(2023, 12, 19, 11, 11, 0), AuthorId = userId2 },
                new Post { Id = Guid.Parse("036e16ed-dfbe-4423-87db-cd9e5f0569e0"), Content = "This is the content of post 31", CreatedAt = new DateTime(2023, 12, 20, 11, 11, 0), AuthorId = userId3 },
                new Post { Id = Guid.Parse("ad76ee94-1e7d-4e12-9834-fe7c1fde4b4c"), Content = "This is the content of post 32", CreatedAt = new DateTime(2023, 12, 21, 11, 11, 0), AuthorId = userId4 },
                new Post { Id = Guid.Parse("18db3103-af83-4575-9384-148b739e54e7"), Content = "This is the content of post 33", CreatedAt = new DateTime(2023, 12, 22, 11, 11, 0), AuthorId = userId1 },
                new Post { Id = Guid.Parse("dd4e3040-c62b-4bd5-8fd6-31c967fc1ee8"), Content = "This is the content of post 34", CreatedAt = new DateTime(2023, 12, 23, 11, 11, 0), AuthorId = userId2 },
                new Post { Id = Guid.Parse("136e2fe7-d6d1-4867-9ee7-9200b480fd66"), Content = "This is the content of post 35", CreatedAt = new DateTime(2023, 12, 24, 11, 11, 0), AuthorId = userId3 },
                new Post { Id = Guid.Parse("c3a33893-37c5-4f58-9f2d-c181ad85087b"), Content = "This is the content of post 36", CreatedAt = new DateTime(2023, 12, 25, 11, 11, 0), AuthorId = userId4 },
                new Post { Id = Guid.Parse("fbe533bb-5cb3-499f-aafa-c2f4f8224798"), Content = "This is the content of post 37", CreatedAt = new DateTime(2023, 12, 26, 11, 11, 0), AuthorId = userId1 }
            );
        }
    }
}
