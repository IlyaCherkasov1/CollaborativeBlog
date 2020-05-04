using HelloApp.Data.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
       

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(new Car
                {
                    name = "Tesla Model 5",
                    shortDesc = "Быстрый автомобиль",
                    longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                    img = "/img/Tesla.jpg",
                    price = 45000,
                    isFavourite = true,
                    available = true,
                    Category = Categories["электромобиль"]
                },

                new Car
                {
                    name = "Ford Fiesta",
                    shortDesc = "Тихий и спокойный",
                    longDesc = "Удобный автомобиль для городской жизни",
                    img = "/img/Ford.jpg",
                    price = 11000,
                    isFavourite = false,
                    available = true,
                    Category = Categories["Классический автомобиль"]
                },

                  new Car
                  {
                      name = "BMW M3",
                      shortDesc = "Дерзкий и стильный",
                      longDesc = "Удобный автомобиль для городской жизни",
                      img = "/img/BMW.jpg",
                      price = 65000,
                      isFavourite = true,
                      available = true,
                      Category = Categories["Классический автомобиль"]
                  }
                  ); 
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;   
            public static Dictionary<string, Category> Categories
            {
            get
            {
                if(category == null)
                {
                    var list = new Category[] {
                    new Category{name = "электромобиль" , desc = "Современный вид транспосрата"},
                    new Category{name = "Классический автомобиль" , desc = "Машины с двигателем внутреннего сгорания"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.name, el);
                    }
                }
                return category;
            }
             }


         
    }
}
