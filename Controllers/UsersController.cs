using CollaborativeBlog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly ApplicationContext db;

        private readonly UserManager<User> _userManager;

        public UsersController(UserManager<User> userManager, ApplicationContext db)
        {
            _userManager = userManager;
            this.db = db;
        }

        public IActionResult Index() => View(_userManager.Users.ToList());

        public IActionResult PostsList(string id)
        {
            List<string> publicationNames = db.Posts.Where(u => u.UserId == id).Select(t => t.Title).ToList();
            return View(publicationNames);
        }
    }
}
