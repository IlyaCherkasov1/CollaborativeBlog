using CollaborativeBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.Components
{
    public class HighlyRaitedPosts : ViewComponent
    {
        private readonly ApplicationContext db;

        public HighlyRaitedPosts(ApplicationContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke()
        {
            var highlyRaitedPosts =  db.Posts.OrderByDescending(u => u.UserRating).Include(i => i.Images).Include(t => t.Tags)
                .Include(c => c.Category).AsNoTracking().ToList();
            return View(highlyRaitedPosts);
        }
    }
}
