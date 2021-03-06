using System;
using System.Collections.Generic;

namespace Blog.CORE.Entities
{
    public class PostCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }

        #region Relation
        public ICollection<BlogPost> BlogPosts { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        #endregion
    }
}
