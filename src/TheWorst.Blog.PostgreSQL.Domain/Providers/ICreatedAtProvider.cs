using System;

namespace TheWorst.Blog.PostgreSQL.Domain.Providers
{
    public interface ICreatedAtProvider
    {
        DateTime CreateAt { get; set; }
    }
}