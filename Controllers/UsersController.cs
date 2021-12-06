using CollaborativeBlog.Models;
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

    public class UsersController : Controller
    {
        private readonly ApplicationContext db;

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IStringLocalizer _localizer;


        public UsersController(UserManager<User> userManager, ApplicationContext db, SignInManager<User> signInManager, IStringLocalizer localizer)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _localizer = localizer;
            this.db = db;

        }

        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> Index() => View(await _userManager.Users.ToListAsync());

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PostsList(string id)
        {
            User user = await db.Users.FindAsync(id);
            ViewBag.UserName = user.UserName;
            List<Post> posts = await db.Posts.Where(u => u.UserId == id).ToListAsync();
            return View(posts);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(string id)
        {
            User user = await db.Users.Include(u => u.Likes).Include(r => r.Ratings)
                .Include(c => c.Comments).Include(u => u.Posts).Where(u => u.Id == id)
                .FirstOrDefaultAsync();

            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
            }

            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Lock(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
       
            if (user.LockoutEnd == null || user.LockoutEnd < DateTime.UtcNow)
            {
                DateTime dateTime = new DateTime(2031,12,31);
                IdentityResult result = await _userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(dateTime));
            }
            else
            {
                IdentityResult result = await _userManager.SetLockoutEndDateAsync(user, DateTimeOffset.UtcNow);
            }

            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [Authorize]
        [HttpGet]
        public async Task<JsonResult> InitTheme()
        {
            User user = await _userManager.GetUserAsync(User);
            string theme;
            if (user.IsDarkTheme)
            {
                theme = _localizer["Dark"];
            }
            else
            {
                theme = _localizer["Light"];
            }

            return Json(new { Status = "success", IsDark = user.IsDarkTheme, Theme = theme });
        }

        [Authorize]
        [HttpPost]
        public async Task<JsonResult> ThemeSwitch(string userName)
        {
            User user = await _userManager.FindByNameAsync(userName);
            user.IsDarkTheme = !user.IsDarkTheme;
            await db.SaveChangesAsync();

            string theme;
            if (user.IsDarkTheme)
            {
                theme = _localizer["Dark"];
            }
            else
            {
                theme = _localizer["Light"];
            }

            return Json(new { Status = "success", IsDark = user.IsDarkTheme, Theme = theme });
        }

        [Authorize]
        public async Task<IActionResult> SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Language = culture;
            await db.SaveChangesAsync();

            return LocalRedirect(returnUrl);
        }

    }
}
