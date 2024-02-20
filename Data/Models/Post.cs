using Posterr.api.Data.Abstractions;

namespace Posterr.api.Data.Models
{
    public class Post : IEntity
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Guid AuthorId { get; set; }
        public User Author { get; set; }
        public virtual ICollection<Repost> Reposts { get; set; }

        public Post()
        {
            Reposts = new HashSet<Repost>();
        }
    }
}
