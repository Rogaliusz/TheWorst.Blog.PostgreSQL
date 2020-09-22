using Microsoft.EntityFrameworkCore;
using TheWorst.Blog.PostgreSQL.Domain.Models;

namespace TheWorst.Blog.PostgreSQL.Infrastructure.Persistence
{
    public class BlogContext : DbContext
    {
        private readonly SqlSettings _settings;
        
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        public BlogContext(SqlSettings settings)
        {
            _settings = settings;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_settings.ConnectionString);
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogContext).Assembly);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}