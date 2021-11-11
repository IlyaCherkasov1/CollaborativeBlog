using CollaborativeBlog.Models;
using CollaborativeBlog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationContext db;

        public PostController(ApplicationContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult AddPost()
        {
            return View(db.Categories);
        }

        //[HttpPost]
        //public RedirectResult AddPost(PostViewModels pst)
        //{

        //}
    }
}
