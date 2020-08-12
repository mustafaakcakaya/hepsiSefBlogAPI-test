using hepsiSefBlog.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace hepsiSefBlog.Data.Context
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {}

        public DbSet<Recipe> Recipes { get; set; }
    }
}
