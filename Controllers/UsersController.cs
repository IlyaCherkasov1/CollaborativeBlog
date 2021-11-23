using CollaborativeBlog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly ApplicationContext db;

        private readonly UserManager<User> _userManager;

        public UsersController(UserManager<User> userManager, ApplicationContext db)
        {
            _userManager = userManager;
            this.db = db;
        }

        public async Task<IActionResult> Index() => View(await _userManager.Users.ToListAsync());

        public async Task<IActionResult> PostsList(string id)
        {
           List<Post> posts = await db.Posts.Where(u => u.UserId == id).ToListAsync();
           return View(posts);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("Index");
        }
    }
}
