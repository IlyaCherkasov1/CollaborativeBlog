using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollaborativeBlog.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public Uri ImageUri { get; set; }
        public Post Post { get; set; }
    }
}
