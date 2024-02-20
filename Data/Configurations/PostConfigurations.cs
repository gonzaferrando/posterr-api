using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Posterr.api.Data.Models;

namespace Posterr.api.Data.Configurations
{
    public class PostConfigurations : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(s => s.Content)
                .IsRequired()
                .HasMaxLength(777);

            builder.HasOne(d => d.Author)
                .WithMany(p => p.Posts)
                .HasForeignKey(p => p.AuthorId);
        }
    }
}
