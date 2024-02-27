using Microsoft.AspNetCore.Mvc;
using Posterr.api.Contracts.Posts;
using Posterr.api.Data;
using Posterr.api.Repositories.Interfaces;

namespace Posterr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostsRepository _repository;

        public PostsController(IPostsRepository repository)
        {
            _repository = repository;
        }

        ///<summary>Gets a list of existing post.</summary>
        ///<param name="pageSize">Amount of records to get.</param>
        ///<param name="pageNumber">Page number.</param>
        ///<param name="keyword">Find any post that contains this words.</param>
        /// <returns>List of post found.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<PagedList<SearchPostResponse>>> Search([FromQuery] SearchPostsParameters filters, CancellationToken cancellationToken)
        {
            return Ok(await _repository.Search(filters, cancellationToken));
        }

        /// <summary>Creates a post.</summary>
        /// <param name="model">Post content to be created.</param>
        /// <returns>The created post.</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> Post(CreatePostRequest model, CancellationToken cancellationToken)
        {
            var userId = Guid.Parse("1c7e6d15-b97e-4076-b1a4-8d5de0257f0d"); // Hardcoded user id.


            var userPosts = await _repository.TotalTodayUserPosts(userId, cancellationToken);
            if (userPosts == 5)
            {
                return BadRequest("You reached max amount of posts for today.");
            }

            var newEntity = new Data.Models.Post
            {
                Id = Guid.NewGuid(),
                Content = model.Content,
                CreatedAt = DateTime.UtcNow,
                AuthorId = userId
            };

            _repository.Insert(newEntity);

            await _repository.SaveChangesAsync();

            return CreatedAtAction("Post", new { id = newEntity.Id }, newEntity);
        }
    }
}
