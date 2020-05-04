using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUP13
{
   /// <summary>
   /// car serivice class
   /// </summary>
    [Serializable]
    public class CarService
    {
   
        /// <summary>
        /// constructor with params
        /// </summary>
        /// <param name="number"></param>
        /// <param name="mark"></param>
        /// <param name="mileage"></param>
        /// <param name="master"></param>
        /// <param name="sum"></param>
        public CarService(int number, Mark mark, int mileage, string master, int sum)
        {
            this.Number = number;
            this.Mark = mark;
            this.Mileage = mileage;
            this.Master = master;
            this.Sum = sum;
        }

        /// <summary>
        /// default constructor 
        /// </summary>
        public CarService()
        {
                
        }
   
        /// <summary>
        /// property of carservice
        /// </summary>
        public int Number { get; set; }
        public Mark Mark { get; set; }
        public int Mileage { get; set; }
        public string Master { get; set; }
        public int Sum { get; set; }



    }
}
