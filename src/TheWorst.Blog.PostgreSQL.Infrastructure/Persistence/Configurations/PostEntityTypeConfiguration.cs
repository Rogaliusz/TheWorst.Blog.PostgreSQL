using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheWorst.Blog.PostgreSQL.Domain.Models;

namespace TheWorst.Blog.PostgreSQL.Infrastructure.Persistance.Configurations
{
    public class PostEntityTypeConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}