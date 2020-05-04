using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPromotion.Models
{
    public class MockPostRepository : IPostRepository
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();
        public IEnumerable<Post> AllPost => new List<Post>
        {
            new Post{id = 1, AuthorName = "Илья Черкасов", Available= true, Name = "Тарелка здорового питания",  
                DateTime = DateTime.Now, ShortDescription = "Мы сделали красивую тарелку здорового питания", 
                Text ="", Image ="", PostOfWeek = true, Category = categoryRepository.AllCategories.First(x=> x.Id == 1)},

            new Post{id = 2, AuthorName = "Илья Черкасов", Available= true, Name = "Короновирус. Как защититься.",
                DateTime = DateTime.Now, ShortDescription = "Все, что известно на сегодня о защите от коронавируса.", 
                Text = "", Image ="", PostOfWeek = true,  Category = categoryRepository.AllCategories.First(x=> x.Id == 4)},

            new Post{id = 3, AuthorName = "Илья Черкасов", Available= true, Name = "7 стадий самомотивации",
              DateTime = DateTime.Now, ShortDescription = "Психотерапевт, научный сотрудник Института мозга человека РАН Денис написал статью",
              Text ="", Image="", PostOfWeek = true, Category = categoryRepository.AllCategories.First(x=> x.Id == 2)},

            new Post{id = 4, AuthorName = "Илья Черкасов", Available= true, Name ="ДО и ПОСЛЕ: 42 свежие фотоистории",
               DateTime = DateTime.Now, ShortDescription = "42 настоящие мотивирующие истории ДО и ПОСЛЕ",
               Text = "", Image ="", PostOfWeek = false, Category = categoryRepository.AllCategories.First(x=> x.Id == 2)},
        };
        

        public IEnumerable<Post> PostOfTheWeek => throw new NotImplementedException();

        public Post getPostById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
