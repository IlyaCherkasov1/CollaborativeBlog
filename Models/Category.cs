using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollaborativeBlog.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Display(Name = "Сategory")]
        public string CategoryName { get; set; }
        public List<Post> Posts { get; set; }
    }
}
