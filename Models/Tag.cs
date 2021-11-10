using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollaborativeBlog.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public int TagName { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
