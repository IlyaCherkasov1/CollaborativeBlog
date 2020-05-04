using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba27
{
   public class StockAvailabillity
    {
        public Medecine medecine { get; set; }
        public int Dosage { get; set; }
        public int Price { get; set; }
        public int NumberInStock { get; set; }
        public string Photo { get; set; }
        public int Id { get; set; }

        public StockAvailabillity(Medecine medecine, int dosage, int price, int numberInStock, string photo,int id)
        {
            Id = id;
            this.medecine = medecine;
            Dosage = dosage;
            Price = price;
            NumberInStock = numberInStock;
            Photo = photo;
        }
    }
}
