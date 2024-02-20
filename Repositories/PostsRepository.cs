using Microsoft.EntityFrameworkCore;
using Posterr.api.Contracts.Posts;
using Posterr.api.Data;
using Posterr.api.Data.EFCore;
using Posterr.api.Data.Models;
using Posterr.api.Extensions;
using Posterr.api.Repositories.Interfaces;

namespace Posterr.api.Repositories
{
    public class PostsRepository : EFRepository<Post, PosterrDbContext>, IPostsRepository
    {
        private readonly IPosterrDbContext _context;
        public PostsRepository(PosterrDbContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Post> GetUsersPost(Guid userId)
        {
            return _context.Posts.Where(p => p.AuthorId == userId);
        }

        public async Task<PagedList<SearchPostResponse>> Search(int pageSize, int pageNumber, string? keyword)
        {
            return await _context.Posts
                                    .Include(p => p.Author)
                                    .Where(m => string.IsNullOrEmpty(keyword) || (!string.IsNullOrEmpty(keyword) && m.Content.Contains(keyword.Trim())))
                                    .OrderByDescending(p => p.CreatedAt)
                                    .Select(p => new SearchPostResponse
                                    {
                                        Id = p.Id,
                                        Author = $"{p.Author.FirstName} {p.Author.LastName}",
                                        Content = p.Content,
                                        CreatedAt = p.CreatedAt
                                    })
                                    .ToPagedListAsync(pageNumber, pageSize);
        }
    }
}
