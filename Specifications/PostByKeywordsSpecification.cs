using Posterr.api.Data.Models;

namespace Posterr.api.Specifications
{
    public class PostByKeywordsSpecification : Specification<Post>
    {
        public PostByKeywordsSpecification(string? keywords)
            : base(post => string.IsNullOrEmpty(keywords) || (!string.IsNullOrEmpty(keywords) && post.Content.Contains(keywords.Trim())))
        {
            AddInclude(post => post.Author);
            AddOrderByDescending(post => post.CreatedAt);
        }
    }
}
