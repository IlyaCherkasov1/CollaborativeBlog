using CollaborativeBlog.Models;
using CollaborativeBlog.Services;
using CollaborativeBlog.ViewModels;
using Korzh.EasyQuery.Linq;
using Korzh.EasyQuery.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
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
        private readonly IStringLocalizer _localizer;
        private readonly UserManager<User> _userManager;


        public HomeController(ApplicationContext db, IStringLocalizer localizer, UserManager<User> userManager)
        {
            this.db = db;
            _localizer = localizer;
            _userManager = userManager;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = new PostViewModel
            {
                Posts = await db.Posts.OrderBy(p => p.PublicationDate).Include(i => i.Images).Include(t => t.Tags)
                .Include(c => c.Category).ToListAsync()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(PostViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Text))
            {
                model.Posts = await db.Posts.OrderBy(p => p.PublicationDate).FullTextSearchQuery(model.Text)
                    .Include(i => i.Images).Include(t => t.Tags).Include(c => c.Category).Include(c => c.Comments).
                    ToListAsync();
            }
            else
            {
                model.Posts = await db.Posts.OrderBy(p => p.PublicationDate).
                    Include(i => i.Images).Include(t => t.Tags).Include(c => c.Category).ToListAsync();
            }
            return View("Galery",model.Posts);
        }

        public async Task<IActionResult> LastPublication()
        {
            var posts = await db.Posts.OrderBy(p => p.PublicationDate).Include(i => i.Images).Include(t => t.Tags)
                .Include(c => c.Category).ToListAsync();
            return View(posts);
        }

        public async Task<IActionResult> HighlyRaitedPosts()
        {
            var posts = await db.Posts.OrderByDescending(u => u.UserRating).Include(i => i.Images).Include(t => t.Tags)
                .Include(c => c.Category).ToListAsync();
            return View(posts);
        }


        public async Task<IActionResult> Galery(string tag) 
        {
            IEnumerable<Post> posts = await db.Posts.Include(i => i.Images).Include(t => t.Tags)
                .Include(c => c.Category).Where(p => p.Tags.Any(t => t.TagName == tag)).ToListAsync();

            return View(posts);
        }


 
    }
}
