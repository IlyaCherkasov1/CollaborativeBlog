using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Models
{
    public class Post
    {
        public int id { get; set; }
        public string AuthorName { get; set; }
        public bool Available { get; set; }

        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public string ShortDescription { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public bool PostOfWeek { get; set; }
       // public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
