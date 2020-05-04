using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie{PieId = 1, Name="Strawberry pie", Price = 15.95M, ShortDescription = "yummy", LongDescription="default description",
                    AllergyInformation ="", ImageUrl="/images/cheesecake1.png", ImageThumbnailUrl="",IsPieOfTheWeek = false, InStock = true,
                    CotegoryId=1,  Category = categoryRepository.AllCategories.First(x=> x.CategoryId == 2 ) },

                new Pie{PieId = 2, Name="Chese cake", Price = 30.95M, ShortDescription = "delicious", LongDescription="default description",
                    AllergyInformation ="", ImageUrl="/images/cheesecake2.png", ImageThumbnailUrl="",IsPieOfTheWeek = true, InStock = true,
                    CotegoryId=2, Category = categoryRepository.AllCategories.First(x=> x.CategoryId == 3)},

                new Pie{PieId = 3, Name="Rhubarb Pie", Price = 10.95M, ShortDescription = "savory", LongDescription="default description", 
                    AllergyInformation ="", ImageUrl="/images/cheesecake3.png", ImageThumbnailUrl="",IsPieOfTheWeek = true, InStock = true,
                    CotegoryId=3, Category = categoryRepository.AllCategories.First(x=> x.CategoryId == 1)},

                new Pie{PieId = 4, Name="Pumpking pie", Price = 12.95M, ShortDescription = "tasty", LongDescription="default description", 
                    AllergyInformation ="", ImageUrl="/images/cheesecake4.png", ImageThumbnailUrl="",IsPieOfTheWeek = false, InStock = true, 
                    CotegoryId=1, Category = categoryRepository.AllCategories.First(x=> x.CategoryId == 2)},
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.First(p => p.PieId == pieId);
        }
    }
}
