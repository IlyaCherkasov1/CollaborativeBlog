using CollaborativeBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.ViewModels
{
    public class AllTagsViewModel
    {
        public IEnumerable<Tag> Tags { get; set; }

    }
}
