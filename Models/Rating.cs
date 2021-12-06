using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public double RatingNumber { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
