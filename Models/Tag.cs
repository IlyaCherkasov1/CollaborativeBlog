using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollaborativeBlog.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public List<Post> Posts { get; set; }
    }
}
