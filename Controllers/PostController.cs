using CollaborativeBlog.Models;
using CollaborativeBlog.Services;
using CollaborativeBlog.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            Post post = new Post
            {
                Title = postView.Title,
                ShortDescription = postView.ShortDescription,
                Description = postView.Description,
                PublicationDate = DateTime.Now,
                Rating = postView.Rating,
                CategoryId = postView.CategoryId,
                Category = db.Categories.Where(x => x.CategoryId == postView.CategoryId).First(),
                Tags = db.Tags.Where(t => postView.TagsId.Contains(t.TagId)).ToList()
            };
            List<Image> images = new List<Image>();                   
            List<string> fileNames = new List<string>();
            List<Uri> imageBlobs = new List<Uri>();

            foreach (var image in postView.Images)
            {
                string fileName = Guid.NewGuid() + Path.GetExtension(image.FileName);
             
                fileNames.Add(fileName);
                var uploadRes = await _blobService.UploadBlob(fileName, image, "images");
                var getRes = await _blobService.GetBlob(fileName, "images");
                Uri uri = new Uri(getRes);
                imageBlobs.Add(uri);
                images.Add(new Image { ImageUri = uri, Post = post });
            }

            post.Images = images;
            db.Posts.Add(post);
          
            await db.SaveChangesAsync();

             return Json(Url.Action("Index", "Home"));
        }

        public IActionResult PostDetails(int postId)
        {
            Post post =  db.Posts.Where(p => p.PostId == postId).Include(i => i.Images)
                .Include(t => t.Tags).Include(c=>c.Category).First();

            return View(post);
        }


    }
}
