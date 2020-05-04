using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba27
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                Medecine medecine = new Medecine("название", "ОООЛучшаяАптека", "хлор",1);
                StockAvailabillity stockAvailabillity = new StockAvailabillity(medecine, 5, 200, 20, "image1",1);
                Sale sale = new Sale(medecine, 50, DateTime.Now, 10,1);
                db.Medecines.Add(medecine);
                db.StockAvailabillities.Add(stockAvailabillity);
                db.Sales.Add(sale);
                db.SaveChanges();

                var medecines = db.Medecines;
                Console.WriteLine("Список объектов:");
                foreach (Medecine u in medecines)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Producer, u.Name, u.Substance);
                }
            }
        }
    }
}
