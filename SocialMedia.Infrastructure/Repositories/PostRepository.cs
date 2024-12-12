using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
        {
            var posts = Enumerable.Range(1, 19).Select( p => new Post { 
                PostId = p,
                Description = $"Descripcion {p}",
                Date = DateTime.Now,
                ImageUrl = $"https://placehold.co/{p*50}x300",
                UserId = p++,
            });

            return posts;
        }
    }
}
