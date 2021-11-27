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
   


        public UsersController(UserManager<User> userManager, ApplicationContext db, IStringLocalizer localizer)
        {
            _userManager = userManager;
            this.db = db;
         
        }

        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> Index() => View(await _userManager.Users.ToListAsync());

    [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PostsList(string id)
        {
           List<Post> posts = await db.Posts.Where(u => u.UserId == id).ToListAsync();
           return View(posts);
        }

        [HttpPost]
    [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("Index");
        }


        [Authorize]
        [HttpGet]
        public async Task<JsonResult> InitTheme()
        {
            User user = await _userManager.GetUserAsync(User);

            return Json(new { Status = "success", IsDark = user.IsDarkTheme });
        }


        [Authorize]
        [HttpPost]
        public async Task<JsonResult> ThemeSwitch(string userName)
        {
            User user = await _userManager.FindByNameAsync(userName);
            user.IsDarkTheme = !user.IsDarkTheme;
            await db.SaveChangesAsync();
            
            return Json(new { Status = "success", IsDark = user.IsDarkTheme });
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
