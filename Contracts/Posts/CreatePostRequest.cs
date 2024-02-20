using System.ComponentModel.DataAnnotations;

namespace Posterr.api.Contracts.Posts
{
    public class CreatePostRequest
    {
        [Required, MaxLength(777)]
        public string Content { get; set; } = string.Empty;
    }
}
