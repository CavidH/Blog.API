using System;
using System.Collections.Generic;

namespace Blog.CORE.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime SenderDate { get; set; }
        public bool IsDeleted { get; set; }

        #region Relation

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int PostId { get; set; }
        public BlogPost Post { get; set; }

        #endregion

    }
}
