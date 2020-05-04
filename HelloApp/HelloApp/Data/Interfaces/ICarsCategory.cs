using HelloApp.Data.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> Allcategories { get; }
    }
}
