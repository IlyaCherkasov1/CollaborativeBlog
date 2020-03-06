using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP8
{
    /// <summary>
    /// My bulding
    /// </summary>
     public class Castle : Building, IPay
    {
        /// <summary>
        /// constructor from buiding
        /// </summary>
        /// <param name="area"></param>
        /// <param name="price"></param>
        /// <param name="address"></param>
        public Castle(int area, int price, string address) : base(area, price, address)
        {
            this.Area = area;
            this.Price = price;
            this.Address = address;
        }
        /// <summary>
        /// method for pay
        /// </summary>
        void IPay.Pay()
        {
            Console.WriteLine("Оплата за аренду!");
        }

        public void Pay()
        {
            Console.WriteLine("Оплата");
        }
    }
}
