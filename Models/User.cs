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
        public User(string userName, string email) : base(userName)
        {
            Email = email;

            Posts = new List<Post>();
        }

        public List<Post> Posts { get; set; }

        public List<Like> Likes { get; set; }  
    }
}
