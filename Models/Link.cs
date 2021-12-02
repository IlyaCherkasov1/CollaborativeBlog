using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollaborativeBlog.Models
{
    public class Link
    {
        public int LinkId { get; set; }
        public List<Post> Posts { get; set; }

    }
}
