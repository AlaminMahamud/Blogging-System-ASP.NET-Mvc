using System.Collections.Generic;

namespace blog_CRUD.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}