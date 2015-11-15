using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog_CRUD.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public DateTime Published { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category{get;set;}
    }
}