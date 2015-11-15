using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Collections;

namespace blog_CRUD.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<BlogDBContext>
    {
        protected override void Seed(BlogDBContext context)
        {


            var categorys = new List<Category>
            {
                new Category { Name = "Cat1" },
                new Category { Name = "Cat2" },
                new Category { Name = "Cat3" },
            };

            categorys.ForEach(s=>context.Categorys.Add(s));
            context.SaveChanges();

            var posts = new List<Post>
            {
                new Post { Title = "This is a Simple Title", Published=DateTime.Now, Author="Md. Alamin Mahamud", Body= "this is the Body", Category = categorys.Single(c=>c.Name=="Cat1") },
                new Post { Title = "This is a Simple Title2", Published=DateTime.Now, Author="Md. Alamin Mahamud", Body= "this is the Body", Category = categorys.Single(c=>c.Name=="Cat2") },
                new Post { Title = "This is a Simple Title3", Published=DateTime.Now, Author="Md. Alamin Mahamud", Body= "this is the Body", Category = categorys.Single(c=>c.Name=="Cat3") }
            };

            posts.ForEach(p=>context.Posts.Add(p));
            context.SaveChanges();
        }

    }
}