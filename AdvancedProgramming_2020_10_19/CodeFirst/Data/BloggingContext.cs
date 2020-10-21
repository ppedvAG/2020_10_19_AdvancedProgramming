using CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.Data
{
    public class BloggingContext :DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            //=> options.UseSqlite("Data Source=blogging.db");
            => options.UseSqlServer("Data Source=SURFACE-KW4;Initial Catalog=MyNewBloggingDB;Integrated Security=True;");
    }
}
