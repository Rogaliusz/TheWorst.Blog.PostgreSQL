using System;
using TheWorst.Blog.PostgreSQL.Domain.Providers;

namespace TheWorst.Blog.PostgreSQL.Domain.Models
{
    public class Article : IIdProvider,
        ICreatedAtProvider
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public int UserId { get; set; }
        
        public User User { get; set; }
    }
}