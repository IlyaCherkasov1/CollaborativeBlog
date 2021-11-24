using CollaborativeBlog.Models;
using CollaborativeBlog.Services;
using CollaborativeBlog.ViewModels;
using Korzh.EasyQuery.Linq;
using Korzh.EasyQuery.Services;
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

        public HomeController(ApplicationContext db, IStringLocalizer localizer, IServiceProvider services)
        {
            this.db = db;
            _localizer = localizer;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = new PostIndexViewModel
            {
                Posts = await db.Posts.Include(i => i.Images).Include(t => t.Tags)
                .Include(c => c.Category).ToListAsync()
            };
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(PostIndexViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Text))
            {
                model.Posts = await db.Posts.FullTextSearchQuery(model.Text)
                    .Include(i => i.Images).Include(t => t.Tags).Include(c => c.Category).Include(c => c.Comments).
                    ToListAsync();
            }
            else
            {
                model.Posts = await db.Posts.
                    Include(i => i.Images).Include(t => t.Tags).Include(c => c.Category).ToListAsync();
            }
            return View("Galery",model.Posts);
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
