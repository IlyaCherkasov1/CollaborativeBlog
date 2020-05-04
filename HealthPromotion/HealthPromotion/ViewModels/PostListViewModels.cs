using HealthPromotion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.ViewModels
{
    public class PostListViewModel
    {
        public IEnumerable<Post> getAllPosts { get; set; }
        public string currCategory { get; set; }
    }
}
