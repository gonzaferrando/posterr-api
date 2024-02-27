using Microsoft.EntityFrameworkCore;
using Posterr.api.Contracts.Posts;
using Posterr.api.Data;
using Posterr.api.Data.EFCore;
using Posterr.api.Data.Models;
using Posterr.api.Extensions;
using Posterr.api.Repositories.Interfaces;
using Posterr.api.Specifications;

namespace Posterr.api.Repositories
{
    public class PostsRepository : EFRepository<Post, PosterrDbContext>, IPostsRepository
    {
        private readonly IPosterrDbContext _context;
        public PostsRepository(PosterrDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> TotalTodayUserPosts(Guid userId, CancellationToken cancellationToken)
        {
            return await ApplySpecification(new PostByUserSpecification(userId))
                            .Where(p => DateTime.Compare(p.CreatedAt.Date, DateTime.Today.Date) == 0)
                            .CountAsync(cancellationToken);
        }

        public async Task<PagedList<SearchPostResponse>> Search(SearchPostsParameters filters, CancellationToken cancellationToken)
        {
            return await ApplySpecification(new PostByKeywordsSpecification(filters.Keywords))
                                .Select(p => new SearchPostResponse
                                {
                                    Id = p.Id,
                                    Author = $"{p.Author.FirstName} {p.Author.LastName}",
                                    Content = p.Content,
                                    CreatedAt = p.CreatedAt
                                })
                                .ToPagedListAsync(filters.PageNumber, filters.PageSize, cancellationToken);
        }

        private IQueryable<Post> ApplySpecification(Specification<Post> specification)
        {
            return SpecificationEvaluator.GetQuery(_context.Posts, specification);
        }
    }
}
