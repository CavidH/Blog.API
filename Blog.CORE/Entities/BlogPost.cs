using System;

namespace Blog.CORE.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsModified { get; set; }
        public bool IsDelete { get; set; }
        public string CategoryId { get; set; }
        public PostCategory Category { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }


    }
}
