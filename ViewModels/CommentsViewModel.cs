using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.ViewModels
{
    public class CommentsViewModel
    {
        public string Text { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
    }
}
