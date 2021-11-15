using CollaborativeBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollaborativeBlog.ViewModels
{
    public class HomePostViewModel
    {

        public IEnumerable<Post> PostsWithTags { get; set; }
        public IEnumerable<Post> AllPosts { get; set; }
        public IEnumerable<Post> HighlyRatedPublications { get; set; }
        public IEnumerable<string> AllTags { get; set; }

    }
}
