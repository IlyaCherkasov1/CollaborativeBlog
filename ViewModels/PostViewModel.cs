using CollaborativeBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.ViewModels
{
    public class PostViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public string Text { get; set; }
    }
}
