using System;
using System.Collections.Generic;

namespace Blog.CORE.Entities
{
    public class BlogPost
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public string ImageSrc { get; set; }
        public bool IsModified { get; set; }
        public bool IsDelete { get; set; }

        #region Relation

        public string CategoryId { get; set; }
        public PostCategory Category { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Comment> Comments { get; set; }

        #endregion


    }
}
