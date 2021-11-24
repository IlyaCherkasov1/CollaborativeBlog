using CollaborativeBlog.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.ViewModels
{
    public class PostCreateViewModels
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public IEnumerable<IFormFile> Images { get; set; }
        public int CategoryId { get; set; }
        public List<int> TagsId { get; set; }

    }
}
