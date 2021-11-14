using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollaborativeBlog.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public Post Post { get; set; }
    }
}
