using Microsoft.EntityFrameworkCore;
using Posterr.api.Data.Models;

namespace Posterr.api.Data
{
    public interface IPosterrDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<Repost> Reposts { get; set; }
    }
}
