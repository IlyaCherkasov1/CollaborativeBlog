using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Models
{
   public  interface IPostRepository
    {
        IEnumerable<Post> AllPost { get;  }
        IEnumerable<Post> PostOfTheWeek { get;  }
        Post getPostById(int pieId);
    }
}
