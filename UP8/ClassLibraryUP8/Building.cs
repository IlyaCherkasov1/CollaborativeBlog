using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP8
{
    /// <summary>
    /// main abstract class
    /// </summary>
    public abstract class Building
    {
        int area;
        int price;
        string address;
        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="area"></param>
        /// <param name="price"></param>
        /// <param name="address"></param>
        protected Building(int area, int price, string address)
        {
            this.Area = area;
            this.Price = price;
            this.Address = address;
        }
        /// <summary>
        /// metod for buiding
        /// </summary>
        public virtual void PayR()
        {
            if (this.area > 100)
            {
                Console.WriteLine(this.price * 2 );
                return;
            }
            if (this.area <= 100)
            {
                Console.WriteLine(this.price);
                return;
            }
            return;
        }
        /// <summary>
        /// property for get and set value
        /// </summary>
        public int Area { get => area; set => area = value; }
        public int Price { get => price; set => price = value; }
        public string Address { get => address; set => address = value; }
        /// <summary>
        /// object toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Area: {this.area}, price: {this.price}, address: {this.address}";
        }
    }
}
