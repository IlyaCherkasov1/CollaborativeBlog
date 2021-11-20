using CollaborativeBlog.Models;
using CollaborativeBlog.Services;
using CollaborativeBlog.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext db;

        public HomeController(ApplicationContext db)
        {
            this.db = db;
        }

        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Index(string? tag)
        {
            IEnumerable<Post> posts = db.Posts.Include(i => i.Images).Include(t => t.Tags).Include(c => c.Category).ToList();
            var tags = posts.SelectMany(t => t.Tags.Select(n => n.TagName));
            IEnumerable<Post> highlyRaitedPosts = posts.Where(r => r.Rating > 7);

            IEnumerable<Post> postWithTags;
            if (!string.IsNullOrEmpty(tag))
            {
                postWithTags = posts.Where(p => p.Tags.All(t => t.TagName == tag)).ToList();
            }
            else
            {
               postWithTags = posts;
            }

            var postModel = new HomePostViewModel
            {
                AllPosts = posts,
                AllTags = tags,
                HighlyRatedPublications = highlyRaitedPosts,
                PostsWithTags = postWithTags
            };

            return View(postModel);
        }

    }
}
