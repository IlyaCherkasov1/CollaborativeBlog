using HelloApp.Data.Interfaces;
using HelloApp.Data.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory categoryCars = new MockCategory(); 

        public IEnumerable<Car> cars {
            get
            {
                return new List<Car>
                {
                    new Car{
                name = "Tesla Model 5",
                shortDesc = "Быстрый автомобиль",
                longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                img = "/img/Tesla.jpg",
                price = 45000,
                isFavourite = true,
                available = true,
                Category = categoryCars.Allcategories.First(f => f.name == "электромобиль")},

                new Car
                {
                    name = "Ford Fiesta",
                    shortDesc = "Тихий и спокойный",
                    longDesc = "Удобный автомобиль для городской жизни",
                    img = "/img/Ford.jpg",
                    price = 11000,
                    isFavourite = false,
                    available = true,
                    Category = categoryCars.Allcategories.First(f => f.name == "Классический автомобиль")
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
                    Category = categoryCars.Allcategories.First(f => f.name == "Классический автомобиль")
                }

                };
        }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
