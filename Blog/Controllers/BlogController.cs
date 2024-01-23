using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Blog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private static readonly List<Post> Posts = new List<Post>();
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPosts")]
        public IEnumerable<Post> Get()
        {
            return Posts;
        }

        [HttpPost(Name = "CreatePost")]
        public IActionResult Create([FromBody] Post post)
        {
            try
            {
                if (
                    string.IsNullOrEmpty(post.Title)
                    || string.IsNullOrEmpty(post.Content)
                    || string.IsNullOrEmpty(post.Author)
                )
                {
                    return BadRequest("Please provide all required fields.");
                }

                post.Id = Guid.NewGuid();

                Posts.Add(post);

                return CreatedAtAction("GetPostById", new { id = post.Id }, post);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error creating post: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}", Name = "GetPostById")]
        public IActionResult GetById(Guid id)
        {
            var post = Posts.FirstOrDefault(p => p.Id == id);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }
    }

    public class PostModel
    {
        public Guid? Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Author { get; set; }
    }

    public class Post
    {
        public Guid? Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
