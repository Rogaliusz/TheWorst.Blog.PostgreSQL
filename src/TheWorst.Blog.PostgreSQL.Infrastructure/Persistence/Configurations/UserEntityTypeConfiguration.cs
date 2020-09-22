using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheWorst.Blog.PostgreSQL.Domain.Models;

namespace TheWorst.Blog.PostgreSQL.Infrastructure.Persistance.Configurations
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Articles)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
        }
    }
}