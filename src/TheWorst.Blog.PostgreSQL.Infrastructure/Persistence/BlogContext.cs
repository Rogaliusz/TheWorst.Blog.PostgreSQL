using Microsoft.EntityFrameworkCore;
using TheWorst.Blog.PostgreSQL.Domain.Models;

namespace TheWorst.Blog.PostgreSQL.Infrastructure.Persistance
{
    public class BlogContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}