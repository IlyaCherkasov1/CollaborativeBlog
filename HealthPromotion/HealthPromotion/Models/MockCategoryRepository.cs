using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{Id = 1, CategoryName = "Food"},
            new Category{Id = 2, CategoryName = "Motivation"},
            new Category{Id = 3, CategoryName = "Training"},
            new Category{Id = 4, CategoryName = "Science and medicine"}
        };
    }
}
