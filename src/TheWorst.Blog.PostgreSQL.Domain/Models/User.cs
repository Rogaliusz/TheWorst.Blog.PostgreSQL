using System.Collections.Generic;
using TheWorst.Blog.PostgreSQL.Domain.Providers;

namespace TheWorst.Blog.PostgreSQL.Domain.Models
{
    public class User : IIdProvider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        
        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    }
}