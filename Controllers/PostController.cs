using CollaborativeBlog.Models;
using CollaborativeBlog.Services;
using CollaborativeBlog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
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

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AllPosts()
        {
            List<Post> posts = await db.Posts.ToListAsync();
            return View(posts);
        }
   
        public async Task<IActionResult> Index()
        {
            string id = _userManager.GetUserId(User);
            List<Post> posts = await db.Posts.Where(u => u.UserId == id).ToListAsync();
            return View(posts);
        }

        public IActionResult AddPost(string userName)
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName");
            ViewBag.TagsId = new SelectList(db.Tags, "TagId", "TagName");
            ViewBag.UserName = userName;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPost(CreatePostViewModels postView)
        {
            if (ModelState.IsValid)
            {
                Post post = new Post
                {
                    Title = postView.Title,
                    ShortDescription = postView.ShortDescription,
                    Description = postView.Description,
                    PublicationDate = DateTime.Now,
                    Rating = postView.Rating,
                    User = await _userManager.FindByNameAsync(postView.userName),
                    Category = await db.Categories.Where(x => x.CategoryId == postView.CategoryId).FirstOrDefaultAsync(),
                    Tags = await db.Tags.Where(t => postView.TagsId.Contains(t.TagId)).ToListAsync()
                };
                await db.Posts.AddAsync(post);
                await db.SaveChangesAsync();

                return RedirectToAction("AddPostImage", new { id = post.PostId });
            }
            else
            {
                return RedirectToAction("AddPost", new { userName = postView.userName }); 
            }
        }

        public IActionResult AddPostImage(int id)
        {
            return View(id);
        }

        [HttpPost]
        public async Task<JsonResult> AddPostImage(IEnumerable<IFormFile> images, int postId)
        {
            Post post = await db.Posts.Include(i => i.Images).Where(p => p.PostId == postId).FirstAsync();

            List<Image> imgs = new List<Image>();
            List<string> fileNames = new List<string>();
            List<Uri> imageBlobs = new List<Uri>();

            if (post.Images != null)
            {
                foreach (var image in post.Images)
                {
                    await _blobService.DeleteBlob(image.ImageUri.Segments[2], "images");
                }
            }

            foreach (var image in images)
            {
                string fileName = Guid.NewGuid() + Path.GetExtension(image.FileName);

                fileNames.Add(fileName);
                var uploadRes = await _blobService.UploadBlob(fileName, image, "images");
                
                var getRes = await _blobService.GetBlob(fileName, "images");
                Uri uri = new Uri(getRes);
                imageBlobs.Add(uri);
                imgs.Add(new Image { ImageUri = uri, Post = post });
            }

            post.Images = imgs;          
         
            await db.SaveChangesAsync();

            return Json(new { Status = "success" });
        }

       
        public async Task<IActionResult> DeletePost(int postId, string returnUrl)
        {
            Post post = await db.Posts.Include(i => i.Images).Where(p => p.PostId == postId).FirstAsync();
            db.Posts.Remove(post);
            await db.SaveChangesAsync();

            foreach (var image in post.Images)
            {
                await _blobService.DeleteBlob(image.ImageUri.Segments[2], "images");
            }

            return Redirect(returnUrl);
        }


        public async Task<IActionResult> EditPost(int id)
        {
            Post post = await db.Posts.Include(t => t.Tags).Include(c => c.Category).Where(p => p.PostId == id).FirstAsync();
           
            CreatePostViewModels createPostViewModels = new CreatePostViewModels
            {
                PostId = post.PostId,
                Title = post.Title,
                ShortDescription = post.ShortDescription,
                Description = post.Description,
                Rating = post.Rating,
                CategoryId = post.CategoryId,
                TagsId = post.Tags.Select(t => t.TagId).ToList()
            };

            ViewBag.CategoryId = new SelectList(await db.Categories.ToListAsync(), "CategoryId","CategoryName", createPostViewModels.CategoryId);

            IEnumerable<SelectListItem> tagItems =  db.Tags.Select(t => new SelectListItem
            {
                  Value = t.TagId.ToString(),
                  Text = t.TagName,
                  Selected = createPostViewModels.TagsId.Contains(t.TagId)
            });
            ViewBag.TagsId = tagItems;

            return View(createPostViewModels);
        }


        [HttpPost]
        public async Task<IActionResult> EditPost(CreatePostViewModels postView)
        {
            if (ModelState.IsValid)
            {
                Post post = await db.Posts.Include(t => t.Tags).Include(c => c.Category)
             .Where(p => p.PostId == postView.PostId).FirstAsync();

                post.Title = postView.Title;
                post.ShortDescription = postView.ShortDescription;
                post.Description = postView.Description;
                post.Rating = postView.Rating;
                post.Category = await db.Categories.Where(x => x.CategoryId == postView.CategoryId).FirstOrDefaultAsync();
                post.Tags = await db.Tags.Where(t => postView.TagsId.Contains(t.TagId)).ToListAsync();

                await db.SaveChangesAsync();

                return RedirectToAction("AddPostImage", new { id = post.PostId });
            }
            else
            {
                return RedirectToAction("EditPost", new { id = postView.PostId });
            }
        }

        [AllowAnonymous]
        public async Task<IActionResult> PostDetails(int postId)
        {
            string userId = _userManager.GetUserId(User);
       
            Post post =  await db.Posts.Where(p => p.PostId == postId).Include(i => i.Images)
                .Include(t => t.Tags).Include(c=>c.Category).FirstAsync();

            int countLike = await db.Posts.Where(p => p.PostId == postId).Include(l => l.Likes).
             Select(p => p.Likes.Count()).FirstAsync();

            ViewBag.CountLike = countLike;
            ViewBag.IsLike =  await db.Likes.AnyAsync(p => p.PostId == postId && p.UserId == userId);

            if (await db.Ratings.AnyAsync(p => p.PostId == postId && p.UserId == userId))
            {
               ViewBag.MyRaiting = await db.Ratings.Where(p => p.PostId == postId && p.UserId == userId)
               .Select(r => r.RatingNumber).FirstOrDefaultAsync();
            }
            else
            {
                ViewBag.MyRaiting = 0;
            }
       
            return View(post);
        }

     
        [HttpPost]
        public async Task<JsonResult> Rate(int postId, double ratingNumber)
        {
            Post post = await db.Posts.Where(p => p.PostId == postId).FirstAsync();
            string userId = _userManager.GetUserId(User);
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
                        
            if (await db.Ratings.AnyAsync(p => p.PostId == postId && p.UserId == userId))
            {
                Rating rating = await db.Ratings.Where(p => p.PostId == postId && p.UserId == userId).FirstAsync();
                rating.RatingNumber = ratingNumber;
                db.Ratings.Update(rating);
            }
            else
            {
                Rating rating = new Rating
                {
                    RatingNumber = ratingNumber,
                    PostId = postId,
                    Post = post,
                    User = user
                };
                 await db.Ratings.AddAsync(rating);
            }
            await db.SaveChangesAsync();
            double rate = await db.Ratings.Where(p => p.PostId == postId).AverageAsync(p => p.RatingNumber);
            rate = Math.Round(rate, 1);
            post.UserRating = rate;

            await db.SaveChangesAsync();
            return Json(new { Status = "success", AvverageRate = rate });
        }

        [HttpPost]
        public async Task<JsonResult> Like(int postId)
        {
            Post post = await db.Posts.Where(p => p.PostId == postId).FirstAsync();
            string userId =  _userManager.GetUserId(User);
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
  
            if (await db.Likes.AnyAsync(p => p.PostId == postId && p.UserId == userId))
            {
                Like likedPost = await db.Likes.Where(p => p.PostId == postId && p.UserId == userId).FirstAsync();
                db.Likes.Remove(likedPost);
            }
            else
            {
                Like like = new Like
                {
                    PostId = postId,
                    Post = post,
                    User = user
                };

                await db.Likes.AddAsync(like);
            }
            await db.SaveChangesAsync();

            int countLike = await db.Posts.Where(p => p.PostId == postId).Include(l => l.Likes).
             Select(p => p.Likes.Count()).FirstAsync();

            bool isLike = await db.Likes.AnyAsync(p => p.PostId == postId && p.UserId == userId);

            return Json(new { Status = "success", PostLikes = countLike , IsLike = isLike});
        }

        [HttpPost]
        public async Task<RedirectToActionResult> CreateLink(int[] postsId)
        {
            if (postsId.Length != 0)
            {
                List<Post> posts = await db.Posts.Where(p => postsId.Contains(p.PostId)).ToListAsync();
                Link link = new Link { Posts = posts };
                await db.Links.AddAsync(link);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("AllPosts");
        }
    }
}
