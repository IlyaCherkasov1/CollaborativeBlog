
using HealthPromotion.Models;
using HealthPromotion.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Controllers
{
    public class PostController:Controller
    {
        private readonly IPostRepository postRepository;
        private readonly ICategoryRepository categoryRepository;

        public PostController(IPostRepository postRepository, ICategoryRepository categoryRepository)
        {
            this.postRepository = postRepository;
            this.categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Page of posts";
            PostListViewModel postListViewModel = new PostListViewModel();
            postListViewModel.getAllPosts = postRepository.AllPost;
            postListViewModel.currCategory = "Посты";
            return View(postListViewModel);
        }
    }
}
