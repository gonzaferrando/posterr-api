using Posterr.api.Data.Models;

namespace Posterr.api.Specifications
{
    public class PostByUserSpecification : Specification<Post>
    {
        public PostByUserSpecification(Guid userId)
            : base(post => post.AuthorId == userId)
        {
            AddInclude(post => post.Author);
            AddOrderByDescending(post => post.CreatedAt);
        }
    }
}
