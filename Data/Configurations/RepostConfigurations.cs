using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Posterr.api.Data.Models;

namespace Posterr.api.Data.Configurations
{
    public class RepostConfigurations : IEntityTypeConfiguration<Repost>
    {
        public void Configure(EntityTypeBuilder<Repost> builder)
        {
            builder.HasKey(e => new { e.UserId, e.PostId });

            builder.HasOne(s => s.User)
                .WithMany(s => s.Reposts)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(s => s.Post)
                .WithMany(s => s.Reposts)
                .HasForeignKey(s => s.PostId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
