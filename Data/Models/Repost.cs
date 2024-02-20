namespace Posterr.api.Data.Models
{
    public class Repost
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
        public DateTime RepostedAt { get; set; }

    }
}
