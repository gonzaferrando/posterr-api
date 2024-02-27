using Posterr.api.Contracts.Posts;
using Posterr.api.Data;
using Posterr.api.Data.Models;

namespace Posterr.api.Repositories.Interfaces
{
    public interface IPostsRepository : IRepository<Post>
    {
        Task<PagedList<SearchPostResponse>> Search(SearchPostsParameters filters, CancellationToken cancellationToken);
        Task<int> TotalTodayUserPosts(Guid userId, CancellationToken cancellationToken);
    }
}
