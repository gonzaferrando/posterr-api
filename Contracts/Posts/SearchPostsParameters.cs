namespace Posterr.api.Contracts.Posts
{
    public class SearchPostsParameters
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public string? Keywords { get; set; } = string.Empty;
    }
}
