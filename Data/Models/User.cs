using Posterr.api.Data.Abstractions;

namespace Posterr.api.Data.Models
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Repost> Reposts { get; set; }

        public User()
        {
            Posts = new HashSet<Post>();
            Reposts = new HashSet<Repost>();
        }
    }
}
