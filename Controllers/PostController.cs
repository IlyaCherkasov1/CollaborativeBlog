using CollaborativeBlog.Models;
using CollaborativeBlog.Services;
using CollaborativeBlog.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationContext db;
        private readonly IBlobService _blobService;

        public PostController(ApplicationContext db, IBlobService blobService)
        {
            this.db = db;
            _blobService = blobService;
        }

        [HttpGet]
        public IActionResult AddPost()
        {
            var addpostviewmodel = new AddPostViewModel
            {
                Categories = db.Categories,
                Tags = db.Tags
            };

            return View(addpostviewmodel);
        }

        [HttpPost]
        public async Task<IActionResult> AddPostAsync(PostViewModels postView)
        {
            // var fileName = Guid.NewGuid() + Path.GetExtension(postView.Image.FileName);
            //   var res = await _blobService.UploadBlob(fileName, postView.Image, "images");

            var files = HttpContext.Request.Form.Files;
            //Post post = new Post
            //{
            //    Title = postView.Title,
            //    ShortDescription = postView.ShortDescription,
            //    Description = postView.Description,
            //    PublicationDate = postView.PublicationDate,
            //    //     Image = await _blobService.GetBlob(fileName, "images"),
            //    CategoryId = postView.CategoryId,
            //    Category = db.Categories.Where(x => x.CategoryId == postView.CategoryId).First(),
            //    Tags = db.Tags.Where(x => !postView.TagsId.Any(y => y == x.TagId)).ToList()
            //};

            //db.Posts.Add(post);
            //await db.SaveChangesAsync();

            return Redirect("~/Home/Index" );
        }

    
    }
}
