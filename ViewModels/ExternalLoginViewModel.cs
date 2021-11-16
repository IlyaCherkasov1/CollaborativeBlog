using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.ViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        public string NameIdentifier { get; set; }

        [Required]
        public string GivenName { get; set; }
        [Required]
        public string ReturnUrl { get; set; }
        [Required]

        public string Email { get; set; }
    }
}
