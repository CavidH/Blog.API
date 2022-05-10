using System;
using System.Collections.Generic;

namespace Blog.CORE.Entities
{
    public class PostCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; }
        public bool IsDeleted { get; set; }
    }
}
