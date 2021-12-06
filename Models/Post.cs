using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollaborativeBlog.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "PublicationDate")]
        public DateTime PublicationDate { get; set; }
        [Display(Name = "AuthorRating")]
        public int Rating { get; set; }
        [Display(Name = "UserRating")]
        public double UserRating { get; set; }
        public List<Image> Images { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public List<Link> Links { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Like> Likes { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
