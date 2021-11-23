using CollaborativeBlog.Models;
using CollaborativeBlog.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationContext db;
        private readonly UserManager<User> _userManager;


        public ChatHub(ApplicationContext db, UserManager<User> userManager)
        {
            this.db = db;
            _userManager = userManager;
        }

        public async Task Send(int postId, string message)
        {
            Post post = await db.Posts.Where(p => p.PostId == postId).FirstAsync();
            string userId = _userManager.GetUserId(Context.User);
            User user = await _userManager.FindByNameAsync(Context.User.Identity.Name);

            Comment comment = new Comment
            {
                Text = message,
                Date = DateTime.Now,
                PostId = postId,
                Post = post,
                UserId = userId,
                User = user
            };

            await db.Comments.AddAsync(comment);
            await db.SaveChangesAsync();

            await Clients.All.SendAsync("Send", comment.Text, user.GivenName, comment.Date.ToShortDateString());
        }


        public override async Task OnConnectedAsync()
        {
            var comments = await db.Comments
                .Select(x => new CommentsViewModel() {
                    Text = x.Text, UserName = x.User.GivenName,Date = x.Date
                }).ToListAsync();

            if (comments.Count != 0)
            {
                await Clients.All.SendAsync("ConnectedMessages", comments);
            }
     
            await base.OnConnectedAsync();
        
        }
    }
}
