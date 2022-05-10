using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Blog.CORE.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; }

    }
}
