using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba27_EntityFramework
{
    public class Sell
    {
        public Sell(int id, string medicine, int number, DateTime date, int discount)
        {
            this.id = id;
            Medicine = medicine;
            Number = number;
            Date = date;
            Discount = discount;
        }

        public Sell()
        {

        }

        public int id { get; set; }

        public string Medicine { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public int Discount { get; set; }
     
    }
}
