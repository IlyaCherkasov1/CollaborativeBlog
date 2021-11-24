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
            var highlyRaitedPosts =   db.Posts.Include(i => i.Images).Include(t => t.Tags)
                .Include(c => c.Category).Where(r => r.Rating > 7).ToList();
            return View(highlyRaitedPosts);
        }
    }
}
