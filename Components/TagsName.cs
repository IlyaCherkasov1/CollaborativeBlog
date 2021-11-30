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
    public class TagsName : ViewComponent
    {
        private readonly ApplicationContext db;

        public TagsName(ApplicationContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke()
        {
            var tags = db.Tags.Select(t => t.TagName).AsNoTracking().ToList();
            return View(tags);
        }
    }
}
