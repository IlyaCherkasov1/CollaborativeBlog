using CollaborativeBlog.Models;
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

        public IActionResult Index()
        {
            IEnumerable<Post> posts = default;
            posts = db.Posts;

            return View();
        }

    }
}
