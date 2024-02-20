﻿namespace Posterr.api.Contracts.Posts
{
    public class SearchPostResponse
    {
        public Guid Id { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
