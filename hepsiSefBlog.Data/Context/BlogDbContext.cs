using hepsiSefBlog.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace hepsiSefBlog.Data.Context
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        { }

        public DbSet<Recipe> Recipe { get; set; }
    }
}