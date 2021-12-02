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
    public class LinkPublications : ViewComponent
    {
        private readonly ApplicationContext db;

        public LinkPublications(ApplicationContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke(int postId)
        {
            IEnumerable<Post> linkPosts = default;
            if (db.Links.Any(p => p.Posts.Any(p => p.PostId == postId)))
            {
                 linkPosts = db.Links.Include(p => p.Posts).ThenInclude(i => i.Images)
                .Where(l => l.Posts.Any(p => p.PostId == postId)).SelectMany(l => l.Posts.Where(p => p.PostId != postId))
                .AsEnumerable().Distinct().TakeLast(5).ToList();

                ViewBag.AvverageRating = Math.Round(linkPosts.Average(p => p.UserRating), 1);

            }
            else
            {
                linkPosts = db.Posts.Include(p => p.Images).Where(p => p.PostId != postId).AsEnumerable().TakeLast(5).ToList();
            }

            return View(linkPosts);
        }
    }
}
