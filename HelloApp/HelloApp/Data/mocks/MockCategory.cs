using HelloApp.Data.Interfaces;
using HelloApp.Data.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> Allcategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{name = "электромобиль" , desc = "Современный вид транспосрата"},
                    new Category{name = "Классический автомобиль" , desc = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
