using CollaborativeBlog.Models;
using CollaborativeBlog.Services;
using CollaborativeBlog.ViewModels;
using Microsoft.AspNetCore.Http;
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

        public HomeController(ApplicationContext db, IStringLocalizer localizer)
        {
            this.db = db;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Post> posts = await db.Posts.Include(i => i.Images).Include(t => t.Tags)
                .Include(c => c.Category).ToListAsync();

            var tags = await db.Tags.Select(t => t.TagName).ToListAsync();
            IEnumerable<Post> highlyRaitedPosts = posts.Where(r => r.Rating > 7);

            var postModel = new HomePostViewModel
            {
                AllPosts = posts,
                AllTags = tags,
                HighlyRatedPublications = highlyRaitedPosts,
            };

            return View(postModel);
        }

        public async Task<IActionResult> Galery(string tag) 
        {
            IEnumerable<Post> posts = await db.Posts.Include(i => i.Images).Include(t => t.Tags)
                .Include(c => c.Category).Where(p => p.Tags.Any(t => t.TagName == tag)).ToListAsync();

            return View(posts);
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
