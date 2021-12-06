 using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.Models
{
    public class User : IdentityUser
    {
        public User(string userName, string email, string givenName) : base(userName)
        {
            Email = email;
            GivenName = givenName;
            Posts = new List<Post>();
        }

        public string GivenName { get; set; } 
        public string Language { get; set; } = "ru";

        public bool IsDarkTheme { get; set; } = false;

        public List<Post> Posts { get; set; }

        public IList<Like> Likes { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
