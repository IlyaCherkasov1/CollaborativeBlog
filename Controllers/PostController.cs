using CollaborativeBlog.Models;
using CollaborativeBlog.Services;
using CollaborativeBlog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

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
    [Authorize]
    public class PostController : Controller
    {
        private readonly ApplicationContext db;
        private readonly UserManager<User> _userManager;
        private readonly IBlobService _blobService;

        public PostController(ApplicationContext db, IBlobService blobService, UserManager<User> userManager)
        {
            this.db = db;
            _blobService = blobService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            string id = _userManager.GetUserId(User);
            List<Post> publicationNames = db.Posts.Where(u => u.UserId == id).ToList();
            return View(publicationNames);
        }

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
        public async Task<IActionResult> AddPost(PostViewModels postView)
        {
            Post post = new Post
            {
                Title = postView.Title,
                ShortDescription = postView.ShortDescription,
                Description = postView.Description,
                PublicationDate = DateTime.Now,
                Rating = postView.Rating,
                CategoryId = postView.CategoryId,
                UserId = _userManager.GetUserId(User),
                User = await _userManager.FindByNameAsync(User.Identity.Name),
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

            return Redirect("/Home/Index");
        }


        public IActionResult EditPost(int id)
        {
            Post post = db.Posts.Where(p => p.PostId == id).FirstOrDefault();
          
            var editPostModel = new EditPostViewModel
            {
                Post = post,
                Categories = db.Categories,
                Tags = db.Tags
            };
            return View(editPostModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditPost(PostViewModels postView)
        {
            Post post = new Post
            {
                Title = postView.Title,
                ShortDescription = postView.ShortDescription,
                Description = postView.Description,
                PublicationDate = DateTime.Now,
                Rating = postView.Rating,
                CategoryId = postView.CategoryId,
                UserId = _userManager.GetUserId(User),
                User = await _userManager.FindByNameAsync(User.Identity.Name),
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
            db.Posts.Update(post);

            await db.SaveChangesAsync();

            return Redirect("/Home/Index");
        }

        [AllowAnonymous]
        public IActionResult PostDetails(int postId)
        {
            Post post =  db.Posts.Where(p => p.PostId == postId).Include(i => i.Images)
                .Include(t => t.Tags).Include(c=>c.Category).First();

            return View(post);
        }


    }
}
