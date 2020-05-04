using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDBContext;
        public CategoryRepository(AppDbContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Category> AllCategories => appDBContext.Categories;
    }
}
