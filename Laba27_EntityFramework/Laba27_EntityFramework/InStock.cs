using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba27_EntityFramework
{
   public  class InStock
    {
        public InStock(int id, string medicine, int dosage, int shelfLife, int price, int number, string photo)
        {
            this.id = id;
            Medicine = medicine;
            Dosage = dosage;
            ShelfLife = shelfLife;
            Price = price;
            Number = number;
            Photo = photo;
        }

        public InStock()
        {

        }

        public int id { get; set; }
        public string Medicine { get; set; }
        public int Dosage { get; set; }
        public int ShelfLife { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }
        public string Photo { get; set; }
    }
}
