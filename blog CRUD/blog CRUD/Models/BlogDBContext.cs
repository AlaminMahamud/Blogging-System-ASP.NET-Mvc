using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace blog_CRUD.Models
{
    public class BlogDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categorys { get; set; }

        static BlogDBContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BlogDBContext>());
        }
    }
}