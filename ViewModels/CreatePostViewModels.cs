using CollaborativeBlog.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.ViewModels
{
    public class CreatePostViewModels
    {
        public int PostId { get; set; }

        [Required(ErrorMessage = "TitleRequired")]
        [StringLength(100, ErrorMessage = "TitleLength", MinimumLength = 6)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "ShortDescriptionRequired")]
        [Display(Name = "ShortDescription")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "DescriptionRequired")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "RatingRequired")]
        [Range(1, 10, ErrorMessage = "RatingRange")]
        [Display(Name = "Rating")]
        public int Rating { get; set; }
        public IEnumerable<IFormFile> Images { get; set; }

        [Required]
        [Display(Name = "Сategory")]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Tags")]
        public List<int> TagsId { get; set; }
    
        public string userName { get; set; }
    }
}
