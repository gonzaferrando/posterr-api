using Posterr.api.Contracts.Posts;
using Posterr.api.Data;
using Posterr.api.Data.Models;

namespace Posterr.api.Repositories.Interfaces
{
    public interface IPostsRepository : IRepository<Post>
    {
        Task<PagedList<SearchPostResponse>> Search(int pageSize, int pageNumber, string? keyword);
        IQueryable<Post> GetUsersPost(Guid userId);
    }
}
