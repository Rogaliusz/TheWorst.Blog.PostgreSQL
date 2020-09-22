using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TheWorst.Blog.PostgreSQL.Infrastructure.Persistence
{
    public class BlogDesignTimeDbContextFactory : IDesignTimeDbContextFactory<BlogContext>
    {
        public BlogContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();

            var settings = new SqlSettings();
            configuration.GetSection("Sql").Bind(settings);
            
            return new BlogContext(settings);
        }
    }
}